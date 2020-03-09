using System;
using System.Collections.Generic;
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
    public class ChangePasswordController : Controller
    {
        ApiCalls Api;
        public ChangePasswordController(bool test = false)
        {
            if (test == false)
            {
                Api = new ApiCalls();
            }
            else
            {
                Api = new ApiCallsMock();
            }
        }
        string URL = "http://academysecuritydos.azurewebsites.net/";
        string pathController = "api/NewPassword/ChangePassword";

        public ActionResult ChangePassword()
        {
            TempData["username"] = JsonConvert.DeserializeObject(HttpContext.Session.GetString("SessionUser"));
            //Vista de cambiar Password
            var usuario = new ChangePassword { UserName = TempData["username"].ToString() };
            TempData["rol"] = JsonConvert.DeserializeObject(HttpContext.Session.GetString("UserRol"));
            return View(usuario);
        }
        [HttpPost]
        public ActionResult ChangePassword(ChangePassword model)
        {
            //proceso de la api
            var resultadoFinal = Api.SecurityApiCallRegisterOrChangeNewPassword(URL, pathController, model, null);
            if (resultadoFinal == true)
            {
                return RedirectToAction("Todos", "Producto", new { id = 1 });
            }
            else
            {
                //en dado caso que falle el cambiar contraseña que hacemos?
                return View("ChangePassword");
            }
        }
    }
}