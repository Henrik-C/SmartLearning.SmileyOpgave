using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace SmartLearning.SmileyOpgave.Data
{
    public class SmileyOpgaveDbSeeder
    {
        public static void Seed(IServiceProvider serviceProvider)
        {
            using var context = new SmileyOpgaveDbContext(serviceProvider.GetRequiredService<DbContextOptions<SmileyOpgaveDbContext>>());

            if (context.Companies.Any())
            {
                // If we get here then the data has already been seeded
                return;
            }

            // Data to seed the database
            context.Companies.AddRange(
                new Models.Company
                {
                    Id = 1,
                    Name = "Pizza Hut",
                    Cvr = 12345678,
                    Address = "Strandvejen 234"
                },
                new Models.Company
                {
                    Id = 2,
                    Name = "Dominos",
                    Cvr = 11223344,
                    Address = "Åløkkegade 57"
                },
                new Models.Company
                {
                    Id = 3,
                    Name = "Pizza & Kebab",
                    Cvr = 44556677,
                    Address = "Park Allé 25"
                }
            );

            if (context.SmileyReports.Any())
            {
                // If we get there then the data has already been seeded
                return;
            }

            // Data to see the database
            context.SmileyReports.AddRange(
                new Entities.SmileyReport
                {
                    Id = 1,
                    CompanyId = 1,
                    Smiley = Entities.SmileyReport.SmileyRating.Happy,
                    DateForSmiley = new DateOnly(2023, 01, 15)
                },
                new Entities.SmileyReport
                {
                    Id = 2,
                    CompanyId = 2,
                    Smiley = Entities.SmileyReport.SmileyRating.Balanced,
                    DateForSmiley = new DateOnly(2022, 11, 20)
                },
                new Entities.SmileyReport
                {
                    Id = 3,
                    CompanyId = 3,
                    Smiley = Entities.SmileyReport.SmileyRating.Sad,
                    DateForSmiley = new DateOnly(2023, 02, 01)
                });

            context.SaveChanges();
        }
    }
}
