    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_APiProducts.Models
{
    public class Product
    {
        public int Id { set; get; }
        public string ProdName { set; get; }
        public string LinkDoc { set; get; }
        public string LinkApi { set; get; }
        public string Status { set; get; }
        public int ContributerId { set; get; }
    }
}
