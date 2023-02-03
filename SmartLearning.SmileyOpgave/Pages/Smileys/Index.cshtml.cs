using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SmartLearning.SmileyOpgave.Data;
using SmartLearning.SmileyOpgave.Entities;
using SmartLearning.SmileyOpgave.Extensions;
using SmartLearning.SmileyOpgave.Models;
using SmartLearning.SmileyOpgave.Models.Dto;

namespace SmartLearning.SmileyOpgave.Pages.Smileys
{
    public class IndexModel : PageModel
    {
        private readonly SmartLearning.SmileyOpgave.Data.SmileyOpgaveDbContext _context;

        public IndexModel(SmartLearning.SmileyOpgave.Data.SmileyOpgaveDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Company> Company { get;set; } = default!;
        public IEnumerable<SmileyReport> SmileyReport { get; set; }
        public IList<SmileyReportDto> SmileyReportDtos { get;set; }

        public async Task OnGetAsync()
        {
            if (_context.Companies != null)
            {
                Company = await _context.Companies.ToListAsync();
                SmileyReport = await _context.SmileyReports.ToListAsync();

                SmileyReportDtos = SmileyReport.ConvertToDto(Company).ToList();
            }


        }

        //public async Task OnGetAsync()
        //{
        //    if (_context.Companies != null)
        //    {
        //        Company = await _context.Companies.ToListAsync();
        //    }
        //}
    }
}
