using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_APiProducts.Entities;

namespace WebApi_APiProducts.Services
{
    public interface IOwnerRepesitory
    {
        IEnumerable<OwnersEntity> GetOwners();
        OwnersEntity GetOwner(int adminId, bool includeContributers);
        void AddOwner(OwnersEntity ownerEntity); 
        bool Save();
    }
}
