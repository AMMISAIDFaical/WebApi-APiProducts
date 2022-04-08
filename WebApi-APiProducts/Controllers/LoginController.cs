using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using WebApi_APiProducts.Models;
using WebApi_APiProducts.Services;

namespace WebApi_APiProducts.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public LoginController(IContibuterRepesitory contributerRepesitory, IMapper mapper)
        {
            _contibuterRepesitory = contributerRepesitory;
            _mapper = mapper;
        }

        private readonly IContibuterRepesitory _contibuterRepesitory;

        public IMapper _mapper { get; }

        [HttpPost, Route("login")]
        public IActionResult Login ([FromBody] LoginModel user)
        {
            if (user == null)
            {
                return BadRequest("invalide client request ");
            }

            if (_contibuterRepesitory.GetContByEmailAndPw(user.email, user.password, false))
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:1028",
                    audience: "http://localhost:1028",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}
