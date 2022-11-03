using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Library.Common;
using Library.Models;
using Newtonsoft.Json;

namespace Library.Controls
{
    public class Authorization
    {
        /// <summary>
        /// Метод возвращает токен авторизации либо "error"
        /// </summary>
        /// <param name="_email"></param>
        /// <param name="_pass"></param>
        /// <returns></returns>
        public string SignIn(string _email, string _pass)
        {
            WebClient client = new WebClient();
            NameValueCollection param = new NameValueCollection();
            param.Add("email", _email);
            param.Add("password", _pass);
            try
            {

                var response = client.UploadValues(ServerAddress.SrvrAddres + "api/login", "POST", param);
                string result = Encoding.Default.GetString(response);
                result = result.Trim();
                BearerClass userData = JsonConvert.DeserializeObject<BearerClass>(result);
                return userData.Bearer;
                //return result;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
