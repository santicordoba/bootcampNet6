using Clase33_MVC.Data.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Clase33_MVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext() 
        { 
        }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-GTL004C\\SQLEXPRESS;Initial Catalog=aspnet-Clase33_MVC-29BF2703-0F49-4CD1-B61B-93A09AE84BF5;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
    }
}