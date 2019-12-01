using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Net.Http;

using RuruPeruClient.Models;

namespace RuruPeruClient.Controllers
{
    public class RuruController : Controller
    {
        // GET: Ruru
        public ActionResult CreateUsuario()
        {

            Usuario reg = new Usuario();

            return View(reg);
        }

        [HttpPost]
        public ActionResult CreateUsuario(Usuario reg)
        {


            ViewBag.mensaje = "";

            using (var usuario = new HttpClient())
            {
                usuario.BaseAddress = new Uri("http://localhost:54469/api/API/");

                var tarea = usuario.PostAsJsonAsync<Usuario>("reg", reg);
               
                tarea.Wait();

                var resultado = tarea.Result;

                if (resultado.IsSuccessStatusCode)
                {
                    var mensaje = resultado.Content.ReadAsAsync<string>();
                    mensaje.Wait();

                    ViewBag.mensaje = mensaje.Result;
                }
            }

            return View(reg);
        }

    }
}