using Microsoft.EntityFrameworkCore;
using SmartLearning.SmileyOpgave.Entities;
using SmartLearning.SmileyOpgave.Models;
using SmartLearning.SmileyOpgave.Models.Dto;

namespace SmartLearning.SmileyOpgave.Data
{
    public class SmileyOpgaveDbContext : DbContext
    {
        public SmileyOpgaveDbContext(DbContextOptions<SmileyOpgaveDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
        public DbSet<SmileyReport> SmileyReports { get; set; }
    }
}
