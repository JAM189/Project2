using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TryCSharp.FirstApi.Models;
using TryCSharp.FirstApi.Repositories;

namespace TryCSharp.FirstApi.Models.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly TryCSharp.FirstApi.Repositories.UniversityDBcontext _context;

        public DetailsModel(TryCSharp.FirstApi.Repositories.UniversityDBcontext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
