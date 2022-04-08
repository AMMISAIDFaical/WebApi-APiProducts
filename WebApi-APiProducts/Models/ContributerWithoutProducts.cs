using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_APiProducts.Models
{
    public class ContributerWithoutProducts
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public int OwnerEntityId { set; get; }

    }
}
