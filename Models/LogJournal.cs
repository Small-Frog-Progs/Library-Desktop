using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class LogJournal
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int book { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public int status { get; set; }
    }
}
