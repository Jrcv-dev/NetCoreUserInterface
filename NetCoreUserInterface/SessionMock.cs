using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreUserInterface
{
    public class SessionMock:Session
    {
        public override bool SaveSession(string key, string content)
        {
            if(key!=null || key != "")
            {
                if(content!=null || content == "")
                {
                    return true;
                }
            }
            return false;
        }

        public override string GetSession(string key)
        {
            if(key != null && key != "")
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add(key, "EXT");
                var value = dic[key];
                return value;
            }
            return "Llave no valida";
        }
    }
}
