using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.Models
{
    public class Estudiante:Usuario
    {
        public int CodEstudiante { get; set; }
        public DateTime FechaRegistro { get; set; }
        public virtual Empleado EmpleadoQuienRegistra { get; set; }
        public virtual ICollection<Prestamo> Prestamos { get; set; }
    }
}
