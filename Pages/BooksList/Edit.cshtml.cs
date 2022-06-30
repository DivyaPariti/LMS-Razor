using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMSRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMSRazor.Pages.BooksList
{
    public class EditModel : PageModel
    {
        private ApplicationDBContext _db;

        public EditModel(ApplicationDBContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Books Books { get; set; }
        public async Task OnGet(int id)
        {
            Books = await _db.Books.FindAsync(id);
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var BookFromDB = await _db.Books.FindAsync(Books.Id);
                BookFromDB.Name = Books.Name;
                BookFromDB.Author = Books.Author;
                BookFromDB.ISBN = Books.ISBN;
                BookFromDB.Image = Books.Image;
                BookFromDB.Genre = Books.Genre;
                BookFromDB.NoofCopies = Books.NoofCopies;

                await _db.SaveChangesAsync();
                return RedirectToPage("BooksList_Index");
            }
            else
            {
                return RedirectToPage();
            }
        }
    }
}
