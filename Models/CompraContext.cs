using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace practicasimulacro.Models
{
    public class CompraContext : DbContext
    {
        public DbSet<RegistrarProducto> RegistrosProductos {get; set;}

        public CompraContext(DbContextOptions dco) : base(dco){

        }
    }
}