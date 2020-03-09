using NetCoreUserInterface.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreUserInterface
{
    public class ApiCalls
    {
        HttpClient client = new HttpClient();

        public virtual bool SecurityApiCallRegisterOrChangeNewPassword(string url,string pathController,ChangePassword content, RegisterUser user)
        {
            client.BaseAddress = new Uri(url);
            //Mandamos la peticion por el body hacia la api de security
            if (content.Equals(null) || content.Equals(""))
            {
                string json = JsonConvert.SerializeObject(user);
                var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PostAsync(pathController, httpcontent);
                response.Wait();
                var result = response.Result;
                var readresult = result.Content.ReadAsStringAsync().Result;
                var resultadoFinal = JsonConvert.DeserializeObject<Boolean>(readresult);
                return resultadoFinal;
            }
            else
            {
                string json = JsonConvert.SerializeObject(content);
                var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");
                var response = client.PostAsync(pathController, httpcontent);
                response.Wait();
                var result = response.Result;
                var readresult = result.Content.ReadAsStringAsync().Result;
                var resultadoFinal = JsonConvert.DeserializeObject<Boolean>(readresult);
                return resultadoFinal;
            }
        }

        public virtual UsuarioConectado SecurityApiLogin(string url, string pathController, Usuario user)
        {
            client.BaseAddress = new Uri(url);
            //Mandamos la peticion por el body hacia la api de security
            string json = JsonConvert.SerializeObject(user);
            var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(pathController, httpcontent);
            response.Wait();
            var result = response.Result;
            var readresult = result.Content.ReadAsStringAsync().Result;
            var resultadoFinal = JsonConvert.DeserializeObject<UsuarioConectado>(readresult);
            return resultadoFinal;
        }
        public virtual Producto ProductsApiDetails(int id, string url, string pathController)
        {
            client.BaseAddress = new Uri(url);
            var response = client.GetAsync(pathController + id.ToString());
            response.Wait();
            var result = response.Result;
            var readresult = result.Content.ReadAsStringAsync().Result;
            var resultadoFinal = JsonConvert.DeserializeObject<Producto>(readresult);
            return resultadoFinal;
        }
        public virtual bool createProduct(string url, string pathController, Producto model)
        {
            client.BaseAddress = new Uri(url);
            //Mandamos la peticion por el body hacia la api de security
            string json = JsonConvert.SerializeObject(model);
            var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.PostAsync(pathController, httpcontent);
            response.Wait();
            var result = response.Result;
            var readresult = result.Content.ReadAsStringAsync().Result;
            return true;
        }
        public virtual bool DeleteProduct(string url, string pathController, int id)
        {
            client.BaseAddress = new Uri(url);
            //Mandamos la peticion por el body hacia la api de security
            string json = JsonConvert.SerializeObject(id);
            var httpcontent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = client.DeleteAsync(pathController + id);
            response.Wait();
            var result = response.Result;
            var readresult = result.Content.ReadAsStringAsync().Result;
            return true;
        }
    }
}
