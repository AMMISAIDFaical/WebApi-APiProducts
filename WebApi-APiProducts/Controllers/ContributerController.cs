using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_APiProducts.Models;
using WebApi_APiProducts.Services;

 
namespace WebApi_APiProducts.Controllers
{
    [ApiController]
    [Route("api")]
    public class ContributerController : ControllerBase
    {
        private readonly IContibuterRepesitory _contibuterRepesitory;
        private readonly IMapper _mapper;

        public ContributerController(IContibuterRepesitory contributerRepesitory, IMapper mapper)
        {
            _contibuterRepesitory = contributerRepesitory;
            _mapper = mapper;
        }

        [HttpGet("contributer")]
        public IActionResult GetContributers()
        {
            var contributersEntities = _contibuterRepesitory.GetContributers();
            return Ok(_mapper.Map<IEnumerable<ContributerWithoutProducts>>(contributersEntities));
        }

        [HttpGet("contributer/{contributerId}")]
        public IActionResult GetSingleContributer(int contributerId)
        {
            var singleContributerEntity = _contibuterRepesitory.GetContributer(contributerId, false);
            return Ok(_mapper.Map<ContributerWithoutProducts>(singleContributerEntity));
        }

        [HttpGet("contributer/{email}/{password}")]
        public IActionResult getContByNameAndPw(string email, string password)
        {
            var singleContributerEntity = _contibuterRepesitory.GetContByName(email, password, false);
            return Ok(_mapper.Map<ContributerWithoutProducts>(singleContributerEntity));
        }

        // POST api/<ContributerController>
        [HttpPost("contributer")]
        public void Post([FromBody] ContributerWithoutProducts contributerModel)
        {
            var finalContributerEntity = _mapper.Map<Entities.ContributereEntity>(contributerModel);
            _contibuterRepesitory.AddContributer(finalContributerEntity);
            _contibuterRepesitory.Save();
        }

        // PUT api/<ContributerController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ContributerController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
