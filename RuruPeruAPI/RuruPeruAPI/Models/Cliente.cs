using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RuruPeruAPI.Models
{
    public class Cliente
    {
        [Display(Name = "Código")]
        public string idCliente { get; set; }
        [Display(Name = "Código de usuario")]
        public string idUsuario { get; set; }
        [Display(Name = "Nombre")]
        public string nomUsuario { get; set; }
        [Display(Name = "Apellido")]
        public string apeCliente { get; set; }
        [Display(Name = "Fecha de nacimiento")]
        public DateTime fechaNacCliente { get; set; }
        [Display(Name = "Descripción")]
        public string descripcionEstado { get; set; }
        [Display(Name ="Foto")]
        public string fotoUsuario { get; set; }
    }
}