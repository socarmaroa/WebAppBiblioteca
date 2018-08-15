using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.Models
{
    public class Libro
    {
        public Libro()
        {
            //Prestamo = new HashSet<Prestamo>();
        }

        public int Id { get; set; }
        [Required]
        [Display(Name = "Título del libro")]
        public string Titulo { get; set; }
        [Required]
        [Display(Name = "Editorial a la que pertenece")]
        public string Editorial { get; set; }
        [Required]
        [Display(Name = "Año de publicación")]
        public string Year { get; set; }
        [Required]
        [Display(Name = "Ubicación del libro")]
        public int UbicacionId { get; set; }
        [Required]
        [Display(Name = "Tipo de Libro")]
        public int TipoLibroId { get; set; }
        [Required]
        [Display(Name = "Area a la que pertenece el libro")]
        public int AreaId { get; set; }
        [Required]
        [Display(Name = "Dias en los que se puede prestar el libro")]
        public int DiasPrestamo { get; set; }
        public virtual ICollection<Prestamo> Prestamo { get; set; }
        //public int EmpleadoQuienRegistraId { get; set; }

        //public General Area { get; set; }
        //public Empleado EmpleadoQuienRegistra { get; set; }
        //public General TipoLibro { get; set; }
        //public General Ubicacion { get; set; }
        //public ICollection<Prestamo> Prestamo { get; set; }
    }
}
