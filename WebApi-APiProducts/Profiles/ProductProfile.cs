using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_APiProducts.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Entities.ProductEntity, Models.Product>();
            CreateMap<Models.Product, Entities.ProductEntity>();
        }

    }
}
