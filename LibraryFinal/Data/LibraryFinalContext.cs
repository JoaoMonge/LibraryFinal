using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryFinal.Model;

namespace LibraryFinal.Data
{
    public class LibraryFinalContext : DbContext
    {
        public LibraryFinalContext (DbContextOptions<LibraryFinalContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryFinal.Model.Author> Author { get; set; } = default!;

        public DbSet<LibraryFinal.Model.Book> Book { get; set; } = default!;
    }
}
