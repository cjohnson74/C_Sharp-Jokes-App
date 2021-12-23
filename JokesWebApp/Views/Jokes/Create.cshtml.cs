using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JokesWebApp.Data;
using JokesWebApp.Models;

namespace JokesWebApp.Views
{
    public class CreateModel : PageModel
    {
        private readonly JokesWebApp.Data.ApplicationDbContext _context;

        public CreateModel(JokesWebApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Joke Joke { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Joke.Add(Joke);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
