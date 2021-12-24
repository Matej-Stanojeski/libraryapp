using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApp.Models
{
    public class BooksByClient
    {
        public Client Client { get; set; }
        public List<Book> Books { get; set; }

        public BooksByClient()
        {
            Books = new List<Book>();
        }
    }
}