using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_APiProducts.Context;
using WebApi_APiProducts.Entities;
using WebApi_APiProducts.Models;

namespace WebApi_APiProducts.Services
{
    public class ProductRepesitory : IProductRepesitory
    {
        private readonly ProductApiContext _context;
        private readonly ProductApiContextComplextQ _complextQuerycntx;

        public ProductRepesitory(ProductApiContext context, ProductApiContextComplextQ complextQuerycntx)
        {
            _context = context;
            _complextQuerycntx = complextQuerycntx;
        }


        public void AddProduct(ProductEntity productEntity)
        {
            _context.Products.Add(productEntity);
        }

        public ProductEntity GetProduct(int productId)
        {
            return _context.Products.Where(c => c.Id == productId).FirstOrDefault();
        }
       
        public IEnumerable<ProductEntity> GetProducts()
        {
            return _context.Products.OrderBy(c => c.ProdName).ToList();
        }

        public IEnumerable<JoinContributerProduct> GetProductsByContributer()
        {
            return _complextQuerycntx.JoinContributerProduct.OrderBy(c => c.ProdName).ToList();

        }


        public void AddJoinProduct(JoinContributerProduct productContJoinEntity)
        {
            _complextQuerycntx.JoinContributerProduct.Add(productContJoinEntity);

        }

        public IEnumerable<ProductEntity> GetProductsByStatus(string status)
        {
            return _context.Products.Where(c => c.Status == status).ToList();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
        public bool ComplexQCntxSave()
        {
            return (_complextQuerycntx.SaveChanges() >= 0);
        }


    }
}


