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
    public class IndexModel : PageModel
    {
        private readonly TryCSharp.FirstApi.Repositories.UniversityDBcontext _context;

        public IndexModel(TryCSharp.FirstApi.Repositories.UniversityDBcontext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
