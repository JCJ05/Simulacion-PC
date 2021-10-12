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


    }
}