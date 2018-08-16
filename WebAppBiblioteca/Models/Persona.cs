using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public int TipoIdentificacionId { get; set; }
        public string Identificacion { get; set; }
        public string Pnombre { get; set; }
        public string Snombre { get; set; }
        public string Papellido { get; set; }
        public string Sapellido { get; set; }
        public int GeneroId { get; set; }
        public virtual General Genero { get; set; }
        public virtual General TipoIdentificacion { get; set; }
    }
}
