using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_APiProducts.Context;
using WebApi_APiProducts.Entities;

namespace WebApi_APiProducts.Services
{
    public class ContributerRepesitory : IContibuterRepesitory
    {
        private readonly ProductApiContext _context;
        private ContributereEntity Cont_FinalEntity;

        public ContributerRepesitory(ProductApiContext context)
        {
            _context = context;
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void AddContributer(ContributereEntity contributereEntity)
        {
            _context.Contributeres.Add(contributereEntity);
        }

        public ContributereEntity GetContributer(int contributerId, bool includeProducts)
        {
            
            return _context.Contributeres.Where(c => c.Id == contributerId).FirstOrDefault();
        }

        public Boolean GetContByEmailAndPw(string contributerEmail, string password,  bool includeProducts)
        {
            var entityExists = false;
            var EntityToBereturn = new ContributereEntity(); 
            var Cont_Entity = _context.Contributeres.Where(c => c.Email == contributerEmail).FirstOrDefault();
            if (Cont_Entity.Password==password)
            {
                EntityToBereturn = Cont_Entity;
                entityExists = true;
            }
            return entityExists;
        }

        public IEnumerable<ContributereEntity> GetContributers()
        {
            return _context.Contributeres.OrderBy(c => c.Email).ToList();                                                               
        }

        public ContributereEntity GetContByName(string contributerEmail, string password, bool includeProducts)
        {
            var entityExists = false;
            var EntityToBereturn = new ContributereEntity();
            var Cont_Entity = _context.Contributeres.Where(c => c.Email == contributerEmail).FirstOrDefault();
            if (Cont_Entity.Password == password)
            {
                EntityToBereturn = Cont_Entity;
                entityExists = true;
            }
            return EntityToBereturn;
        }
    }
}
