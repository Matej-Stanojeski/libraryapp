using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApp.Models
{
    public class Client
    {
        public Client()
        {
            Books = new List<Book>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Top List Position must be a number")]
        public string LibraryID { get; set; }
        public string Photo { get; set; }

        [Range(1, 150, ErrorMessage = "Age must be a positive number < 150")]
        public int Age { get; set; }
        public virtual ICollection<Book> Books { get; set; } 
    }
}