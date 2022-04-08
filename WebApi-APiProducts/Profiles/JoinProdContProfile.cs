using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_APiProducts.Entities;
using WebApi_APiProducts.Models;

namespace WebApi_APiProducts.Profiles
{
    public class JoinProdContProfile : Profile
    {
        public JoinProdContProfile()
        {
            CreateMap<JoinContributerProduct, JoinProdContModel>();
            CreateMap<JoinProdContModel, JoinContributerProduct>();
        }
    }
}
