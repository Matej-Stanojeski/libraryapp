using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibraryApp.Models
{
    public class LibraryDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public DbSet<Client> Clients { get; set; }
        public LibraryDbContext() : base("LibraryApp")
        {

        }
        public static LibraryDbContext Create()
        {
            return new LibraryDbContext();
        }
    }
}