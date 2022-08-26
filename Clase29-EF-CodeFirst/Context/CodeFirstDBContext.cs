using Clase29_EF_CodeFirst.Modelo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase29_EF_CodeFirst.Context
{
    public class CodeFirstDBContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas{ get; set; }
        public DbSet<Deposito> Depositos { get; set; }
        public DbSet<Sucursal> Sucursales{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Conectamos con neustra base SQL Server usando un string de conexión
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=ClaseCodeFirst;Integrated Security=true;");

            base.OnConfiguring(optionsBuilder);
        }



    }
}
