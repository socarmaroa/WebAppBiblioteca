using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppBiblioteca.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Nombre Usuario")]
        public string NombreUsuario { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Password")]        
        public string Password { get; set; }
        public virtual General EstadoUsuario { get; set; }
        public virtual Persona Persona { get; set; }        
    }
}
