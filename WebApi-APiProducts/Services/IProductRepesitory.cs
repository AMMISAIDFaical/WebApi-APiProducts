using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_APiProducts.Entities;


namespace WebApi_APiProducts.Services
{
    public interface IProductRepesitory
    {
        IEnumerable<JoinContributerProduct> GetProductsByContributer();
        void AddProduct(ProductEntity productEntity);
        void AddJoinProduct(JoinContributerProduct productEntity);
        IEnumerable<ProductEntity> GetProducts();
        ProductEntity GetProduct(int productId);
        IEnumerable<ProductEntity> GetProductsByStatus(string status);
        bool Save();
        bool ComplexQCntxSave();
    }
}
