using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMSRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LMSRazor.Pages.BooksList
{
    public class BooksList_IndexModel : PageModel
    {
        private readonly ApplicationDBContext _db;

        public BooksList_IndexModel(ApplicationDBContext db)
        {
            _db = db;
        }

        public IEnumerable<Books> Books { get; set; }
        public async Task OnGet()
        {
            Books = await _db.Books.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int Id)
        {
            var books = await _db.Books.FindAsync(Id);
            if(books == null)
            {
                return NotFound();
            }
            _db.Books.Remove(books);
            await _db.SaveChangesAsync();

            return RedirectToPage("BooksList_Index");
        }

    }
}
