using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RuruPeruAPI.Models
{
    public class Usuario
    {
        [Display(Name ="Codigo")]
        public string idUsuario { get; set; }

        [Display(Name ="Nombre")]
        public string nomUsuario { get; set; }

        [Display(Name = "Contraseña")]
        public string contraUsuario { get; set; }

        [Display(Name = "Distrito")]
        public int idDistrito { get; set; }

        [Display(Name ="Foto")]
        public string fotoUsuario { get; set; }

        [Display(Name ="Estado")]
        public int idEstado { get; set; }
    }
}