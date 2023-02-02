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
    public class DetailsModel : PageModel
    {
        private readonly SmartLearning.SmileyOpgave.Data.SmileyOpgaveDbContext _context;

        public DetailsModel(SmartLearning.SmileyOpgave.Data.SmileyOpgaveDbContext context)
        {
            _context = context;
        }

        public Company Company { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Companies == null)
            {
                return NotFound();
            }

            var company = await _context.Companies.FirstOrDefaultAsync(m => m.Id == id);
            if (company == null)
            {
                return NotFound();
            }
            else 
            {
                Company = company;
            }
            return Page();
        }
    }
}
