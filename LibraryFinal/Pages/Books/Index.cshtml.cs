using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using LibraryFinal.Data;
using LibraryFinal.Model;

namespace LibraryFinal.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly LibraryFinal.Data.LibraryFinalContext _context;

        public IndexModel(LibraryFinal.Data.LibraryFinalContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
