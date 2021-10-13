using System;
using Microsoft.EntityFrameworkCore;


namespace Simulacion_PC.Data
{
    public class ApplicationDbContext:DbContext
    {
        
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }


        public DbSet<Simulacion_PC.Models.Solicitud> DataContactos { get; set; }

         public DbSet<Simulacion_PC.Models.Categoria> DataCategorias { get; set; }

        
    }
}