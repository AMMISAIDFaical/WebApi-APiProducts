using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi_APiProducts.Models;
using WebApi_APiProducts.Services;

namespace WebApi_APiProducts.Controllers
{
    [ApiController]
    [Route("api")]
    public class ProductController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProductRepesitory _productRepesitory;

        public ProductController (IProductRepesitory productRepesitory, IMapper mapper)
        {
            _mapper = mapper;
            _productRepesitory = productRepesitory;
        }

        [HttpGet("products")]
        public IActionResult Getproducts()
        {
            var productsEntities = _productRepesitory.GetProducts();
            return Ok(_mapper.Map<IEnumerable<Product>>(productsEntities));
        }

        [HttpGet("products/{status}")]
        public IActionResult GetProductsByStatus(string status)
        {
            var productsEntities = _productRepesitory.GetProductsByStatus(status);

            return Ok(_mapper.Map<IEnumerable < Product >> (productsEntities));
        }

        [HttpGet("productsJoinContributer")]
        public IActionResult JoinProductAndContributer()
        {
            var JoinprodContEnt = _productRepesitory.GetProductsByContributer();
            return Ok(_mapper.Map<IEnumerable<JoinProdContModel>>(JoinprodContEnt));
        }

        // POST api
        [HttpPost("productsJoinContributer")]
        public void Post([FromBody] JoinProdContModel productContModelToAdd)
        {
            var finalProductEntity = _mapper.Map<Entities.JoinContributerProduct>(productContModelToAdd);
            _productRepesitory.AddJoinProduct(finalProductEntity);
            _productRepesitory.ComplexQCntxSave();
            }

        // POST api/<OwnersController>
        [HttpPost("products")]
        public void Post([FromBody] Product productModel)
        {
            var finalProductEntity = _mapper.Map<Entities.ProductEntity>(productModel);
            _productRepesitory.AddProduct(finalProductEntity);
            _productRepesitory.Save();
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
