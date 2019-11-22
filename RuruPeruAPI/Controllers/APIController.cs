using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using RuruPeruAPI.Consultas;

namespace RuruPeruAPI.Controllers
{
    public class APIController : ApiController
    {
        SqlConnection cn = new SqlConnection("server=.;Database=RuruPeruDB;Integrated Security=true");
        //services
        ConsultaClient serviceCOnsulta = new ConsultaClient();
        [HttpGet]
        [Route("api/listadoUsuario")]
        public IHttpActionResult Usuario() {
            
            if (serviceCOnsulta.ListarUsuarios() == null) {
                return NotFound();
            }
            return Ok(serviceCOnsulta.ListarUsuarios());
        }
    }
}

