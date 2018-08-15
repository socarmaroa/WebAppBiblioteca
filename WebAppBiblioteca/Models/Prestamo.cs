using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        [Display(Name = "Libro prestado")]
        public int LibroId { get; set; }
        //public Libro Libro { get; set; }
        //public int EstudianteId { get; set; }
        //public int EmpleadoQuienPrestaId { get; set; }
        //public int? EmpleadoQuienRecibeId { get; set; }
        [Required]
        [Display(Name = "Fecha de prestamo del libro")]
        public DateTime FechaPrestamo { get; set; }
        [Display(Name = "Fecha de entrega del libro")]
        public DateTime? FechaEntrega { get; set; }

        //public Empleado EmpleadoQuienPresta { get; set; }
        //public Empleado EmpleadoQuienRecibe { get; set; }
        //public Estudiante Estudiante { get; set; }
    }
}
