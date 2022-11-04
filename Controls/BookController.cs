using Library.Common;
using Library.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Library.Controls
{
    public class BookController
    {
        public List<Book> GetBooks()
        {
            WebClient client = new WebClient();
            NameValueCollection param = new NameValueCollection();
            param.Add("token", Token.TokenString);

            try
            {

                var response = client.UploadValues(ServerAddress.SrvrAddres + "reader/index", "POST", param);
                string result = Encoding.Default.GetString(response);
                result = result.Trim();
                List<Book> userData = JsonConvert.DeserializeObject<List<Book>>(result);
                return userData;
            }
            catch (Exception)
            {
                return null;
            }
        }

        //public void CreateUser(string _userName, string _userEmail, string _birthDate, string _password)
        //{
        //    WebClient client = new WebClient();
        //    NameValueCollection param = new NameValueCollection();
        //    param.Add("name", _userName);
        //    param.Add("password", _password);
        //    param.Add("birth_date", _birthDate);
        //    param.Add("email", _userEmail);
        //    param.Add("token", Token.TokenString);
        //    try
        //    {
        //        var response = client.UploadValues(ServerAddress.SrvrAddres + "register", "POST", param);
        //        string result = Encoding.Default.GetString(response);
        //    }
        //    catch (Exception)
        //    {
        //        return;
        //    }
        //}

        //public void DeleteUser(string _userID)
        //{
        //    WebClient client = new WebClient();
        //    NameValueCollection param = new NameValueCollection();
        //    param.Add("token", Token.TokenString);
        //    try
        //    {
        //        var response = client.UploadValues(ServerAddress.SrvrAddres + "reader/" + _userID, "DELETE", param);
        //        string result = Encoding.Default.GetString(response);
        //    }
        //    catch (Exception)
        //    {
        //        return;
        //    }
        //}
    }
}
