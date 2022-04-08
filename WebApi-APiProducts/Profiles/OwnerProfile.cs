using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_APiProducts.Profiles
{
    public class OwnerProfile : Profile
    {
        public OwnerProfile()
        {
            CreateMap<Models.OwnerWithoutContributers, Entities.OwnersEntity>();
            CreateMap<Entities.OwnersEntity, Models.OwnerWithoutContributers>();

        }
    }
}
