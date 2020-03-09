using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreUserInterface
{
    public class Session
    {
        HttpContext context;
        public virtual bool SaveSession(string key, string content)
        {
            context.Session.SetString(key, JsonConvert.SerializeObject(content));
            return true;
            //if (context.Session.GetString(key) != null)
            //{
            //    string data = (string)JsonConvert.DeserializeObject(context.Session.GetString(key));
            //    return data;
            //}
            //else
            //{
            //    return "No hay datos";
            //}
        }
        public virtual string GetSession(string key)
        {
            if (context.Session.GetString(key) != null)
            {
                string data = (string)JsonConvert.DeserializeObject(context.Session.GetString(key));
                return data;
            }
            else
            {
                return "No hay datos";
            }
        }
    }
}
