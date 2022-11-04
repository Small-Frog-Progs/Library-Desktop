using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }
        public int category { get; set; }
        public string shelf { get; set; }
        public string image_path { get; set; }
        public int number_of_pages { get; set; }
        public int is_digit { get; set; }
        public object book_path { get; set; }
        public string author { get; set; }
        public string genre { get; set; }



        //public string ReaderID { get; set; }
        //public string Categories { get; set; }
        //public string Tags { get; set; }



        //private string imagePathString { get; set; }

        //public string ImagePath
        //{
        //    get
        //    {
        //        return imagePathString;
        //    }
        //    set
        //    {
        //        if (!String.IsNullOrEmpty(value))
        //        {
        //            if (File.Exists(value))
        //            {
        //                BookPicture = Image.FromFile(value);
        //                imagePathString = value;
        //            }
        //        }
        //    }
        //}
        //public Image BookPicture { get; set; }
    }
}
