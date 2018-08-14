using System;
using System.Collections.Generic;
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
        public string Titulo { get; set; }
        public string Editorial { get; set; }
        public string Year { get; set; }
        public General Ubicacion { get; set; }
        public General TipoLibro { get; set; }
        public General Area { get; set; }
        public int DiasPrestamo { get; set; }
        //public int EmpleadoQuienRegistraId { get; set; }

        //public DataGeneral Area { get; set; }
        //public Empleado EmpleadoQuienRegistra { get; set; }
        //public DataGeneral TipoLibro { get; set; }
        //public DataGeneral Ubicacion { get; set; }
        //public ICollection<Prestamo> Prestamo { get; set; }
    }
}
