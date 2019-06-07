using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HomeWork.Data;
using HomeWork.Models;

namespace HomeWork.Views.Students
{
    public class IndexModel : PageModel
    {
        private readonly HomeWork.Data.ApplicationDbContext _context;

        public IndexModel(HomeWork.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students
                .Include(s => s.Batch).ToListAsync();
        }
    }
}
