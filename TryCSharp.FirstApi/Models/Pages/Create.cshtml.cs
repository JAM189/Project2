using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TryCSharp.FirstApi.Models;
using TryCSharp.FirstApi.Repositories;

namespace TryCSharp.FirstApi.Models.Pages
{
    public class CreateModel : PageModel
    {
        private readonly TryCSharp.FirstApi.Repositories.UniversityDBcontext _context;

        public CreateModel(TryCSharp.FirstApi.Repositories.UniversityDBcontext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Students.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
