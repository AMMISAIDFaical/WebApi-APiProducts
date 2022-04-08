using AutoMapper;
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
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerRepesitory  _ownerRepesitory;
        private readonly IMapper _mapper;

        public OwnerController(IOwnerRepesitory ownerRepesitory, IMapper mapper)
        {
            _ownerRepesitory = ownerRepesitory;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetOwners()
        {
            var adminsEntities = _ownerRepesitory.GetOwners();

            return Ok(_mapper.Map<IEnumerable<OwnerWithoutContributers>>(adminsEntities));
        }

        [HttpGet("owners/{ownerId}")]
        public IActionResult GetSingleOwner(int ownerId)
        {
            var singleAdminEntity = _ownerRepesitory.GetOwner(ownerId, false);
            return Ok(_mapper.Map<OwnerWithoutContributers>(singleAdminEntity));
        }

        // POST api/<OwnersController>
        [HttpPost("owners")]
        public void Post([FromBody] OwnerWithoutContributers ownerModel)
        {
            var finalOwnerEntity = _mapper.Map<Entities.OwnersEntity>(ownerModel);
            _ownerRepesitory.AddOwner(finalOwnerEntity);
            _ownerRepesitory.Save();
        }

        // PUT api/<OwnersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OwnersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
