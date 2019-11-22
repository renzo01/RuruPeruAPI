using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using RuruPeruAPI.Models;

namespace RuruPeruAPI.Controllers
{
    public class APIController : ApiController
    {
        SqlConnection cn = new SqlConnection("server=.;Database=RuruPeruDB;Integrated Security=true");

        [HttpGet]
        [Route("api/listadoUsuario")]
        public IHttpActionResult Usuario() {
            List<Usuario> list = new List<Usuario>();
            SqlCommand cmd = new SqlCommand("usp_listar_Usuarios", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                Usuario u = new Usuario()
                {
                    idUsuario = dr.GetString(0),
                    nomUsuario = dr.GetString(1),
                    nomDistrito = dr.GetString(2),
                    fotoUsuario = dr.GetString(3),
                    descripcionEstado = dr.GetString(4)
                };
                list.Add(u);
            }
            dr.Close(); cn.Close();
            if (list.Count() == 0) {
                return NotFound();
            }
            return Ok(list);
        }
    }
}

