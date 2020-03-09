using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreUserInterface.Models;
using Newtonsoft.Json;

namespace NetCoreUserInterface.Controllers
{
    public class RegistrarUsuarioController : Controller
    {
        ApiCalls Api;
        public RegistrarUsuarioController(bool test = false)
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
        string pathController = "api/NewUser/CreateUser";
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(RegisterUser model)
        {
            var resultadoFinal = Api.SecurityApiCallRegisterOrChangeNewPassword(URL, pathController, null, model);
            if (resultadoFinal == true)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("RegisterUser");
            }
        }
    }
}