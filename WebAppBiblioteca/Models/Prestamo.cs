using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        public Libro Libro { get; set; }
        //public int EstudianteId { get; set; }
        //public int EmpleadoQuienPrestaId { get; set; }
        //public int? EmpleadoQuienRecibeId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaEntrega { get; set; }

        //public Empleado EmpleadoQuienPresta { get; set; }
        //public Empleado EmpleadoQuienRecibe { get; set; }
        //public Estudiante Estudiante { get; set; }
    }
}
