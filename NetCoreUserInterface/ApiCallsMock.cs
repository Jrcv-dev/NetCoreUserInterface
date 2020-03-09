using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreUserInterface.Models;

namespace NetCoreUserInterface
{
    public class ApiCallsMock : ApiCalls
    {
        ChangePassword cambiarPass = new ChangePassword();
        public override bool SecurityApiCallRegisterOrChangeNewPassword(string url, string pathController, ChangePassword content = null, RegisterUser user=null)
        {
            if (url.Equals("http://academysecuritydos.azurewebsites.net/"))
            {
                if (pathController.Equals("api/NewPassword/ChangePassword"))
                {
                    if(content.UserName!=null && content.UserName != "" && content.NewPassword!=null && content.NewPassword != "")
                    return true;
                }
                else if (pathController.Equals("api/NewUser/CreateUser"))
                {
                    if (user.UserName == null || user.UserName == "" && user.FirstName == null || user.FirstName =="" && user.LastName == null || user.LastName =="" && user.Password == null || user.Password == "")
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override UsuarioConectado SecurityApiLogin(string url, string pathController, Usuario user)
        {
            UsuarioConectado userloged = new UsuarioConectado();
            if (url.Equals("http://academysecuritydos.azurewebsites.net/"))
            {
                if (pathController.Equals("api/Sessions/Login"))
                {
                    if(user.UserName != null && user.UserName != "" && user.Password != null && user.Password != "")
                    {
                        userloged.Username = user.UserName;
                        userloged.IsLogged = true;
                        userloged.Role = "EXT";
                        return userloged;
                    }
                }
            }
            return userloged;
        }
        public override Producto ProductsApiDetails(int id, string url, string pathController)
        {
            Producto product = new Producto();
            product.IdProduct = 1;
            product.Name = "chanclas";
            product.price = "200";
            product.description = "blabla";
            if (url != "" && url != null && pathController != "" && pathController != null)
            {
                if (id != null && id != 0)
                {
                    
                    return product;
                }
            }
            return null;
        }
        public override bool createProduct(string url, string pathController, Producto model)
        {
            if (url != null && url != "" && pathController != "" && pathController != null)
            {
                if (model != null)
                {
                    return true;
                }
            }
            return false;
        }
        public override bool DeleteProduct(string url, string pathController, int id)
        {
            if (url != "" && url != null && pathController != "" && pathController != null)
            {
                if (id != 0 && id != null && id==1)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
