using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_APiProducts.Context;
using WebApi_APiProducts.Entities;

namespace WebApi_APiProducts.Services
{
    public class OwnerRepesitory : IOwnerRepesitory
    {
        private readonly ProductApiContext _context;

        public OwnerRepesitory(ProductApiContext context)
        {
            _context = context;
        }

        public void AddOwner(OwnersEntity ownerEntity)
        {
            _context.Owners.Add(ownerEntity);
        }

        public OwnersEntity GetOwner(int ownerId, bool includeContributers)
        {
            return _context.Owners.Where(c => c.Id == ownerId).FirstOrDefault();
        }

        public IEnumerable<OwnersEntity> GetOwners()
        {
            return _context.Owners.OrderBy(c => c.Id).ToList();
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
