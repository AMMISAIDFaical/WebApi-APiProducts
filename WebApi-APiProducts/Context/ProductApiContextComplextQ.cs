using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_APiProducts.Entities;

namespace WebApi_APiProducts.Context
{
    public class ProductApiContextComplextQ : DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ApiProductDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public ProductApiContextComplextQ(DbContextOptions<ProductApiContextComplextQ> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        public DbSet<JoinContributerProduct> JoinContributerProduct {set; get;}

      

    }



}



