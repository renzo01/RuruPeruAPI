using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RuruPeruAPI.Models
{
    public class Usuario
    {
        [Display(Name ="Código")]
        public string idUsuario { get; set; }
        [Display(Name ="Nombre")]
        public string nomUsuario { get; set; }
        [Display(Name = "Distrito")]
        public string nomDistrito { get; set; }
        [Display(Name ="Foto")]
        public string fotoUsuario { get; set; }
        [Display(Name ="Descripción")]
        public string descripcionEstado { get; set; }
    }
}