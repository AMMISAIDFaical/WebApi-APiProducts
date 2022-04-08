using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_APiProducts.Entities;

namespace WebApi_APiProducts.Services
{
    public interface IContibuterRepesitory
    {
        IEnumerable<ContributereEntity> GetContributers();
        ContributereEntity GetContributer(int contributerId, bool includeProducts);
        void AddContributer(ContributereEntity contributereEntity);
        Boolean GetContByEmailAndPw(string contributerEmail, string password, bool includeProducts);
        ContributereEntity GetContByName(string contributerEmail, string password, bool includeProducts);
        bool Save();
    }
}
