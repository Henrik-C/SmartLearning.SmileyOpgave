using Microsoft.EntityFrameworkCore;
using SmartLearning.SmileyOpgave.Entities;
using SmartLearning.SmileyOpgave.Models;

namespace SmartLearning.SmileyOpgave.Data
{
    public class SmileyOpgaveDbContext : DbContext
    {
        public SmileyOpgaveDbContext(DbContextOptions<SmileyOpgaveDbContext> options) : base(options) { }

        public DbSet<Company> Companies { get; set; }
    }
}
