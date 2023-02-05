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
    public class DetailsModel : PageModel
    {
        private readonly SmileyOpgaveDbContext _context;
        public IEnumerable<Company> Company { get; set; }
        public IEnumerable<SmileyReport> SmileyReport { get; set; }
        public IEnumerable<SmileyReportDto> SmileyReportDtos { get; set; }

        public DetailsModel(SmileyOpgaveDbContext context)
        {
            _context = context;
            
            Company = _context.Companies.ToList();
            SmileyReport = _context.SmileyReports.ToList();

            // Her snyder jeg og laver den egentlige context jeg har brug for. 
            SmileyReportDtos = SmileyReport.ConvertToDto(Company).ToList();
        }

        public SmileyReportDto SmileyReportDto { get; set; } = default!; 
        public IEnumerable<SmileyReportDto> PreviousSmileys { get; set; }
        

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context == null)
            {
                return NotFound();
            }
            
            var SmileyReportDto = SmileyReportDtos.OrderByDescending(x => x.DateForSmiley).FirstOrDefault(m => m.CompanyId == id);

            // Denne bruges til at hente de enste 3 smileys, foruden den nyeste.
            PreviousSmileys = SmileyReportDtos.OrderByDescending(x => x.DateForSmiley).Where(m => m.CompanyId == id).Skip(1).Take(3);

            if (SmileyReportDto == null)
            {
                return NotFound();
            }
            else 
            {
                this.SmileyReportDto = SmileyReportDto;
                
            }
            return Page();
        }
    }
}
