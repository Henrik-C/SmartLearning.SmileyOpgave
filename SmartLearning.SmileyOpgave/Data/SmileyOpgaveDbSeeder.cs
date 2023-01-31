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
                    CurrentSmileyRating = Models.Company.SmileyRating.Happy,
                    Cvr = 12345678,
                    DateForLatestSmiley = new DateOnly(2023, 1, 31)
                },
                new Models.Company
                {
                    Id = 2,
                    Name = "Dominos",
                    CurrentSmileyRating = Models.Company.SmileyRating.Balanced,
                    Cvr = 11223344,
                    DateForLatestSmiley = new DateOnly(2022, 11, 15)
                },
                new Models.Company
                {
                    Id = 3,
                    Name = "Pizza & Kebab",
                    CurrentSmileyRating = Models.Company.SmileyRating.Sad,
                    Cvr = 44556677,
                    DateForLatestSmiley = new DateOnly(2021, 5, 17)
                }
            );
            context.SaveChanges();
        }
    }
}
