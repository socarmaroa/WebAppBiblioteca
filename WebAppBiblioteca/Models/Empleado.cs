using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.Models
{
    public class Empleado:Usuario
    {
        public int CodEmpleado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public virtual ICollection<Prestamo> Prestamos { get; set; }
    }
}
