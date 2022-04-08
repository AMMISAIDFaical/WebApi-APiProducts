using Microsoft.EntityFrameworkCore;
using WebApi_APiProducts.Entities;

namespace WebApi_APiProducts.Context
{
    public class ProductApiContext : DbContext
    {

        public DbSet<OwnersEntity> Owners { set; get; }
        public DbSet<ContributereEntity> Contributeres { set; get; }
        public DbSet<ProductEntity> Products { set; get; }
        public DbSet<JoinContributerProduct> JoinContributerProduct { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ApiProductDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public ProductApiContext(DbContextOptions<ProductApiContext> options) : base(options)
        {
              //Database.EnsureCreated(); 
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {   
            modelBuilder.Entity<ContributereEntity>().HasData(
            new ContributereEntity()
            {
                Id=1,
                Name="faiçal",
                Email = "faicalammisaid2000@gmail.com",
                Password = "0123azerty",
                OwnerEntityId = 3
             },
            new ContributereEntity()
            {
                Id = 2,
                Name = "atha",
                Email = "slumerican@oulook.com",
                Password = "mudmouth21",
                OwnerEntityId = 2 
             },
            new ContributereEntity()
            {
                Id = 3,
                Name="mark",
                Email = "facebook@oulook.com",
                Password = "facebook21",
                OwnerEntityId = 1
            },
            new ContributereEntity()
            {
                Id = 4,
                Name = "tesla",
                Email = "tesla@oulook.com",
                Password = "teslak21",
                OwnerEntityId = 4
            },
            new ContributereEntity()
            {
                Id = 5,
                Name = "ufc",
                Email = "dena@UFC.us",
                Password = "UFC21",
                OwnerEntityId = 5
            }

            );



            modelBuilder.Entity<OwnersEntity>().HasData(
            new OwnersEntity()
            {
                Id=1,
                Email = "admin1@gmail.com",
                Password = "admin1234" 
             },
            new OwnersEntity()
            {
                Id=2,
                Email = "admin2@oulook.com",
                Password = "admin9876" 
             },
            new OwnersEntity()
            {
                Id=3,
                Email = "admin3@oulook.com",
                Password = "admin5544" 
            });

            modelBuilder.Entity<ProductEntity>().HasData(
            new ProductEntity()
            {
                Id = 1,
                ProdName = "FacebookAPI",
                LinkApi = "www.facebookApi.com",
                LinkDoc = "www.facebookApi-doc.com",
                Status = "active",
                ContributerId = 1
            },
            new ProductEntity()
            {
                Id = 2,
                ProdName = "GoogleMapsAPI",
                LinkApi = "www.GoogleMapsAPI.com",
                LinkDoc = "www.GoogleMapsAPI-doc.com",
                Status = "paused",
                ContributerId = 2
            },
            new ProductEntity()
            {
                Id = 3,
                ProdName = "YoutubeAPI",
                LinkApi = "www.YoutubeAPI.com",
                LinkDoc = "www.YoutubeAPI-doc.com",
                Status = "active",
                ContributerId = 3
            },
            new ProductEntity()
            {
                Id = 4,
                ProdName = "TeslaAPI",
                LinkApi = "www.TeslaAPI.com",
                LinkDoc = "www.TeslaAPI-doc.com",
                Status = "paused",
                ContributerId = 4
            },
            new ProductEntity()
            {
                Id = 5,
                ProdName = "UFCAPI",
                LinkApi = "www.UFCAPI.com",
                LinkDoc = "www.UFCAPI-doc.com",
                Status = "paused",
                ContributerId = 5
            }
            );

         
            base.OnModelCreating(modelBuilder);

        }
    }
}

