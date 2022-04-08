using System;
using System.Collections.Generic;
 using System.Linq;
using System.Threading.Tasks;
using WebApi_APiProducts.Entities;

namespace WebApi_APiProducts.Models
{
    public class Owner
    {
  
        public int Id { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public ICollection<Contributer> Contributer { set; get; } = new List<Contributer>();

    }
}
