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


        public void EditJurnalLog(string _logID, string _status)
        {
            WebClient client = new WebClient();
            NameValueCollection param = new NameValueCollection();
            param.Add("token", Token.TokenString);
            param.Add("status", _status);

            try
            {

                var response = client.UploadValues(ServerAddress.SrvrAddres + "journal/" + _logID, "PATCH", param);
                string result = Encoding.Default.GetString(response);
            }
            catch (Exception)
            {
                return;
            }
        }
        //public void EditJurnalLog (string _logID, string _bookID, string _readerID, string _dateStart, string _dateEnd, string _status)
        //{
        //    WebClient client = new WebClient();
        //    NameValueCollection param = new NameValueCollection();
        //    param.Add("token", Token.TokenString);
        //    param.Add("user_id", Token.TokenString);
        //    param.Add("book", Token.TokenString);
        //    param.Add("start_date", Token.TokenString);
        //    param.Add("end_date", Token.TokenString);
        //    param.Add("status", Token.TokenString);

        //    try
        //    {

        //        var response = client.UploadValues(ServerAddress.SrvrAddres + "journal/"+_logID, "PATCH", param);
        //        string result = Encoding.Default.GetString(response);
        //        result = result.Trim();
        //        List<LogJournal> userData = JsonConvert.DeserializeObject<List<LogJournal>>(result);
        //    }
        //    catch (Exception)
        //    {
        //        return;
        //    }
        //}
    }
}
