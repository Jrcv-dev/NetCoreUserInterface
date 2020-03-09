using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreUserInterface.Models;
using Newtonsoft.Json;

namespace NetCoreUserInterface.Controllers
{
    public class HomeController : Controller
    {
        ApiCalls Api;
        Session ses;
        public HomeController(bool test = false)
        {
            if (test == false)
            {
                Api = new ApiCalls();
                ses = new Session();
            }
            else
            {
                Api = new ApiCallsMock();
                ses = new SessionMock();
            }
        }
        string URL = "http://academysecuritydos.azurewebsites.net/";
        string pathController = "api/Sessions/Login";
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            List<Producto> lsp = new List<Producto>();
            UsuarioConectado userLoged = new UsuarioConectado();
            Usuario usuario = new Usuario();
            //Las propiedades tienen que hacer match con el DTO para poder comunicarse.
            usuario.UserName = username;
            usuario.Password = password;

            var resultadoFinal = Api.SecurityApiLogin(URL, pathController, usuario);

            if (resultadoFinal.IsLogged != false)
            {
                ses.SaveSession("SessionUser", resultadoFinal.Username);
                ses.SaveSession("UserRol", resultadoFinal.Role);
                var Username = ses.GetSession("SessionUser");
                var role = ses.GetSession("UserRol");
                if(Username != null && Username!="" && role!=null && role!="")
                {
                    //proceso ViewData or TempData
                    ViewData["username"] = Username;
                    ViewData["rol"] = role;
                }
                //if (HttpContext.Session.GetString("SessionUser") != null)
                //{
                //    TempData["username"] = JsonConvert.DeserializeObject(HttpContext.Session.GetString("SessionUser"));
                //    TempData["rol"] = JsonConvert.DeserializeObject(HttpContext.Session.GetString("UserRol"));

                //}
                //Crearmos el objeto que recibira nuestro metodo para la llamada a la api
                //LogEntity logUI = new LogEntity();
                //logUI.aplicacion = "User Interface";
                //logUI.mensaje = "El usuario\t" + resultadoFinal.Username + "\tha iniciado sesion";
                //logUI.fecha = DateTime.Now;
                ////Instanciamos el Log para poder consumir el metodo de conexion a la Api del archivo Dll
                //Log log = new Log();
                //log.ConnectToWebAPI(logUI);
                //return PartialView("~/Views/Producto/Todos.cshtml",lsp);
                return RedirectToAction("Todos", "Producto", new { id = 1 });
            }
            else
            {
                ViewBag.error = "Invalid Account";
                return View("Index");
            }
        }

        public ActionResult RegisterUser()
        {
            return RedirectToAction("RegisterUser", "RegistrarUsuario");
        }
    }
}
