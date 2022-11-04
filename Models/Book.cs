using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ShelfId { get; set; }
        public bool IsDigit { get; set; }



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
