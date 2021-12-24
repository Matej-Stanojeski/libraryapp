using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibraryApp.Models
{
    public class BookClients
    {
        public Client Client { get; set; }
        public List<Book> Books { get; set; }
        public int SelectedBookId { get; set; }
        public int ClientId { get; set; }
    }
}