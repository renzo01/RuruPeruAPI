using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RuruPeruAPI.Models
{
    public class Proveedor
    {
        [Display(Name = "Código")]
        public string idProveedor { get; set; }
        [Display(Name = "Código de usuario")]
        public string idUsuario { get; set; }
        [Display(Name = "Descripción")]
        public string descripcionProveedor { get; set; }
        [Display(Name ="RUC")]
        public string rucProveedor { get; set; }
        [Display(Name ="DNI")]
        public string dniProveedor { get; set; }
    }
}