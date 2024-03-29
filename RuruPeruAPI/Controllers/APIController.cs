﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using RuruPeruAPI.Consultas;
using System.Configuration;

namespace RuruPeruAPI.Controllers
{
    public class APIController : ApiController
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RuruPeruDB"].ConnectionString);
        //services
        ConsultaClient serviceConsulta = new ConsultaClient();

        [HttpGet]
        [Route("api/listadoUsuario")]
        public IHttpActionResult Usuario()
        {

            if (serviceConsulta.ListarUsuarios().Count() == 0)
            {
                return NotFound();
            }
            return Ok(serviceConsulta.ListarUsuarios());
        }
        [HttpGet]
        [Route("api/listadoClientes")]
        public IHttpActionResult Cliente()
        {
            if (serviceConsulta.ListarClientes().Count() == 0)
            {
                return NotFound();
            }
            return Ok(serviceConsulta.ListarClientes());
        }
        [HttpGet]
        [Route("api/listadoProveedor")]
        public IHttpActionResult Proveedor()
        {
            if (serviceConsulta.ListarProveedor().Count() == 0)
            {
                return NotFound();
            }
            return Ok(serviceConsulta.ListarProveedor());
        }
        [HttpGet]
        [Route("api/listadoProductos")]
        public IHttpActionResult Producto() {
            if (serviceConsulta.ListarProductos().Count() == 0)
            {
                return NotFound();
            }
            return Ok(serviceConsulta.ListarProductos());
        }
        [HttpGet]
        [Route("api/listadoCategoriaProd")]
        public IHttpActionResult CategoriaProd()
        {
            if (serviceConsulta.ListaCategoriaProd().Count() == 0)
            {
                return NotFound();
            }
            return Ok(serviceConsulta.ListaCategoriaProd());
        }
        [HttpGet]
        [Route("api/listadoEstadoUsuario")]
        public IHttpActionResult EstadoUsuario()
        {
            if (serviceConsulta.ListarEstadoUsuario().Count() == 0)
            {
                return NotFound();
            }
            return Ok(serviceConsulta.ListarEstadoUsuario());
        }
        [HttpPut]
        public IHttpActionResult EliminarProducto(string id)
        {
            //validacion de la existencia del producto
            if(id == "") return BadRequest("Codigo invalido");
            string mensaje = "";
            try
            {
                SqlCommand cmd = new SqlCommand("usp_eliminar_producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
                mensaje = "Registro exitoso"; 
            }catch(Exception e)
            {
                mensaje = "Error al eliminar producto: " + e.Message;
            }
            finally
            {
                cn.Close();
            }
            return Ok(mensaje);
        }
        [HttpPut]
        public IHttpActionResult DesactivarCliente(String id)
        {
            if (id == "") return BadRequest("Codigo invalido");
            string mensaje;
            try
            {
                SqlCommand cmd = new SqlCommand("usp_desactivar_cliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cn.Open();
                cmd.ExecuteNonQuery();
                mensaje = "Se desactivo exitosamente";
            }catch(Exception e)
            {
                mensaje = "No se pudo desactivar :" + e.Message;

            }
            finally
            {
                cn.Close();
            }
            return Ok(mensaje);
        }
    }
}

