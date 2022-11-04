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
    public class JournalController
    {
        public List<LogJournal> GetLogs()
        {
            WebClient client = new WebClient();
            NameValueCollection param = new NameValueCollection();
            param.Add("token", Token.TokenString);

            try
            {

                var response = client.UploadValues(ServerAddress.SrvrAddres + "journal/index", "POST", param);
                string result = Encoding.Default.GetString(response);
                result = result.Trim();
                List<LogJournal> userData = JsonConvert.DeserializeObject<List<LogJournal>>(result);
                return userData;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
