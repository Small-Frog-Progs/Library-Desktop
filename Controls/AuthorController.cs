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
    public class AuthorController
    {
        //public List<Author> GetAuthors()
        //{

        //    List<Author> _authorList = new List<Author>();

        //    WebClient client = new WebClient();
        //    NameValueCollection param = new NameValueCollection();
        //    param.Add("email", _email);
        //    param.Add("password", _pass);
        //    try
        //    {

        //        var response = client.UploadValues(ServerAddress.SrvrAddres + "api/login", "POST", param);
        //        string result = Encoding.Default.GetString(response);
        //        result = result.Trim();
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        //public object AddAuthor(string _nameAuthor)
        //{
        //    WebClient client = new WebClient();
        //    NameValueCollection param = new NameValueCollection();
        //    param.Add("nameAuthor", _nameAuthor);
        //    try
        //    {

        //        var response = client.UploadValues(ServerAddress.SrvrAddres + "api/login", "POST", param);
        //        string result = Encoding.Default.GetString(response);
        //        result = result.Trim();
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}

        //public string DeleteAuthor(string _id)
        //{
        //    WebClient client = new WebClient();
        //    NameValueCollection param = new NameValueCollection();
        //    param.Add("id", _id);
        //    try
        //    {

        //        var response = client.UploadValues(ServerAddress.SrvrAddres + "api/login", "POST", param);
        //        string result = Encoding.Default.GetString(response);
        //        result = result.Trim();
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        return null;
        //    }
        //}
    }
}
