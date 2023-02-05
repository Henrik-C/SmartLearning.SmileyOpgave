using System.ComponentModel;

namespace SmartLearning.SmileyOpgave.Models.Dto
{
    public class SmileyReportDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public int Cvr { get; set; }
        public string Address { get; set; }

        [DisplayName("Nuværende smiley")]
        public SmileyRating Smiley { get; set; }

        [DisplayName("Dato for sidste smiley")]
        public DateOnly DateForSmiley { get; set; }


        public enum SmileyRating
        {
            Happy = 1,
            Balanced = 2,
            Sad = 3
        }
    }
}
