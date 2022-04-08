using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_APiProducts.Profiles
{
    public class ContributerProfile : Profile
    {
        public ContributerProfile()
        {
            CreateMap<Entities.ContributereEntity, Models.ContributerWithoutProducts>();
            CreateMap<Models.ContributerWithoutProducts, Entities.ContributereEntity>();

        }
    }
}
