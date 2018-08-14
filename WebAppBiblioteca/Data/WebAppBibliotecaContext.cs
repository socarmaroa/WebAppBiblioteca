using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppBiblioteca.Models;

namespace WebAppBiblioteca.Models
{
    public class WebAppBibliotecaContext : DbContext
    {
        public WebAppBibliotecaContext (DbContextOptions<WebAppBibliotecaContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppBiblioteca.Models.TipoGeneral> TipoGeneral { get; set; }

        public DbSet<WebAppBiblioteca.Models.General> General { get; set; }

        public DbSet<WebAppBiblioteca.Models.Libro> Libro { get; set; }

        public DbSet<WebAppBiblioteca.Models.Prestamo> Prestamo { get; set; }
    }
}
