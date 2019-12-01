using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RuruPeruClient.Models
{
    public class Usuario
    {

        public string idUsuario { get; set; }
        public string nomUsuario { get; set; }
        public string contraUsuario { get; set; }
        public int idDistrito { get; set; }
        public string fotoUsuario { get; set; }
        public int idEstado { get; set; }

    }
}