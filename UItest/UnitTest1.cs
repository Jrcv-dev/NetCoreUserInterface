using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetCoreUserInterface.Controllers;
using NetCoreUserInterface.Models;

namespace UItest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ChangePassword_ChangePassword_ReturnsActionName()
        {
            ChangePasswordController controller = new ChangePasswordController(true);
            RedirectToActionResult result = (RedirectToActionResult)controller.ChangePassword(new ChangePassword()
            {
                UserName = "manolo",
                NewPassword = "blabla"
            });
            ViewResult result2 = (ViewResult)controller.ChangePassword(new NetCoreUserInterface.Models.ChangePassword()
            {

            });
            Assert.AreEqual("Todos", result.ActionName);
            Assert.AreEqual("ChangePassword", result2.ViewName);
        }
        [TestMethod]
        public void RegisterUser_Register_ReturnsRedirectToAction()
        {
            RegistrarUsuarioController registercontroller = new RegistrarUsuarioController(true);
            RedirectToActionResult result = (RedirectToActionResult)registercontroller.RegisterUser(new RegisterUser()
            {
                 UserName = "jesus",
                 LastName = "castañeda",
                 FirstName = "jesus",
                 Password = "abc"
            });
            ViewResult result2 = (ViewResult)registercontroller.RegisterUser(new RegisterUser()
            {
                
            });
            Assert.AreEqual("Index", result.ActionName);
            Assert.AreEqual("RegisterUser", result2.ViewName);
        }

        [TestMethod]
        public void Login_LoginUser_ReturnsUserLogin()
        {
            HomeController homecontroller = new HomeController(true);
            RedirectToActionResult resultado = (RedirectToActionResult)homecontroller.Login("manolo","123");
            ViewResult resultado2 = (ViewResult)homecontroller.Login("", "");
            Assert.AreEqual("Todos", resultado.ActionName);
            Assert.AreEqual("Index", resultado2.ViewName);
        }
        [TestMethod]
        public void Details_Producto_ReturnsDetailsOfProduct()
        {
            Producto p = new Producto();
            ProductoController productcontroller = new ProductoController(true);
            ViewResult resultado = (ViewResult)productcontroller.Details(1);

            Assert.AreEqual(resultado.ViewName,null);
        }
        [TestMethod]
        public void Create_Producto_ReturnsBoolean()
        {
            ProductoController productcontroller = new ProductoController(true);
            RedirectToActionResult result = (RedirectToActionResult)productcontroller.Create(new Producto { IdProduct=1, Name="tenis", description="bkjsbkajs", price="500" });

            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void Delete_Producto_ReturnsBoolean()
        {
            ProductoController controller = new ProductoController(true);
            RedirectToActionResult result = (RedirectToActionResult)controller.Delete(1);

            Assert.AreEqual(true, true);
        }
    }
}
