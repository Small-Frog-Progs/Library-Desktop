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

                var response = client.UploadValues(ServerAddress.SrvrAddres + "book/index", "POST", param);
                string result = Encoding.Default.GetString(response);
                result = result.Trim();
                List<Book> userData = JsonConvert.DeserializeObject<List<Book>>(result);
                foreach (var item in userData)
                {
                    item.image_path = "http://192.168.43.246" + item.image_path;
                }
                return userData;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public Book GetBookByID(string _bookID)
        {
            WebClient client = new WebClient();
            NameValueCollection param = new NameValueCollection();
            param.Add("token", Token.TokenString);

            try
            {

                var response = client.UploadValues(ServerAddress.SrvrAddres + "book/"+_bookID, "POST", param);
                string result = Encoding.Default.GetString(response);
                result = result.Trim();
                Book book = JsonConvert.DeserializeObject<Book>(result);
                return book;
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
