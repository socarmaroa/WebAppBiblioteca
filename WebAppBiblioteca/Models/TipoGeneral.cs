using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.Models
{
    public class TipoGeneral
    {
        public TipoGeneral()
        {
            datosGenerales = new HashSet<General>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ICollection<General> datosGenerales { get; set; }
    }
}
