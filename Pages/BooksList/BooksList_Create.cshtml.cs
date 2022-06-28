using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LMSRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LMSRazor.Pages.BooksList
{
    public class BooksList_CreateModel : PageModel
    {
        private readonly ApplicationDBContext _db;
        public BooksList_CreateModel(ApplicationDBContext db)
        {
            _db = db;
        }

        public Books Books { get; set; }
        public void OnGet()
        {
          
        }
    }
}
