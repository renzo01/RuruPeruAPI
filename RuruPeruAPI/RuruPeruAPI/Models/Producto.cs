using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RuruPeruAPI.Models
{
    public class Producto
    {
        [Display(Name = "Código")]
        public string idProducto { get; set; }
        [Display(Name ="Titulo")]
        public string tituloProducto { get; set; }
        [Display(Name ="Descripción")]
        public string descripcionProducto { get; set; }
        [Display(Name ="Precio unitario")]
        public decimal precioProducto { get; set; }
        [Display(Name ="Stock")]
        public Int32 stockProducto { get; set; }
        [Display(Name ="Imagen")]
        public string imgProducto { get; set; }
        [Display(Name ="Descripción")]
        public string descripcionCategoria { get; set; }
        [Display(Name ="Código del proveedor")]
        public string idProveedor { get; set; }
    }
}