using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Data.SqlClient;
using System.Data;
using System.Configuration;

using RuruPeruAPI.Models;

namespace RuruPeruAPI.Controllers
{
    public class APIController : ApiController
    {

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RuruPeruDB"].ConnectionString);

        [HttpPost]
        public IHttpActionResult CreateUsuario([FromBody]Usuario reg)
        {

            string mensaje = "";

            try
            {

                SqlCommand cmd = new SqlCommand(
                    "insert into tb_Usuario values(@idusu,@nom,@con,@iddis,@foto,@idest)", cn);

                cn.Open();

                cmd.Parameters.AddWithValue("@idusu", reg.idUsuario);
                cmd.Parameters.AddWithValue("@nom", reg.nomUsuario);
                cmd.Parameters.AddWithValue("@con", reg.contraUsuario);
                cmd.Parameters.AddWithValue("@iddis", reg.idDistrito);
                cmd.Parameters.AddWithValue("@foto", reg.fotoUsuario);
                cmd.Parameters.AddWithValue("@idest", reg.idEstado);

                int c = cmd.ExecuteNonQuery();

                mensaje = "Registro Agregado: (" + c + ") fila(s) agregadas";

            }
            catch (Exception e)
            {
                mensaje = e.Message;
            }
            finally
            {
                cn.Close();
            }

            return Ok(mensaje);
        }

        [HttpGet]
        [Route("api/listadoUsuario")]
        public IHttpActionResult Usuario()
        {

            return Ok();
        }
        [HttpGet]
        [Route("api/listadoClientes")]
        public IHttpActionResult Cliente()
        {

            return Ok();
        }
        [HttpGet]
        [Route("api/listadoProveedor")]
        public IHttpActionResult Proveedor()
        {

            return Ok();
        }
        [HttpGet]
        [Route("api/listadoProductos")]
        public IHttpActionResult Producto()
        {

            return Ok();
        }
        [HttpGet]
        [Route("api/listadoCategoriaProd")]
        public IHttpActionResult CategoriaProd()
        {

            return Ok();
        }
        [HttpGet]
        [Route("api/listadoEstadoUsuario")]
        public IHttpActionResult EstadoUsuario()
        {
            List<EstadoUsuario> temporal = new List<EstadoUsuario>();

            SqlCommand cmd = new SqlCommand("select * from tb_clientes", cn);
            cn.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                EstadoUsuario reg = new EstadoUsuario()
                {
                    idEstadoUsuario = dr.GetInt16(0),
                    descripcionEstado = dr.GetString(1)
                };

                temporal.Add(reg);

            }
            dr.Close(); cn.Close();

            if (temporal.Count() == 0)
            {
                return NotFound();
            }

            return Ok(temporal);
        }
    }

}
