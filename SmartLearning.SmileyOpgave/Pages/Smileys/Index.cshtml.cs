using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SmartLearning.SmileyOpgave.Data;
using SmartLearning.SmileyOpgave.Models;

namespace SmartLearning.SmileyOpgave.Pages.Smileys
{
    public class IndexModel : PageModel
    {
        private readonly SmartLearning.SmileyOpgave.Data.SmileyOpgaveDbContext _context;

        public IndexModel(SmartLearning.SmileyOpgave.Data.SmileyOpgaveDbContext context)
        {
            _context = context;
        }

        public IList<Company> Company { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Companies != null)
            {
                Company = await _context.Companies.ToListAsync();
            }
        }
    }
}
