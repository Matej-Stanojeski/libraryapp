using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibraryApp.Models
{
    public class Book
    {
        public Book()
        {
            Clients = new List<Client>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        [Range(1000, 2020, ErrorMessage = "Year must be a number > 1000 and <= 2020")]
        public float Year { get; set; }
        public string Photo { get; set; }
        public virtual ICollection<Client> Clients { get; set; }

    }
}