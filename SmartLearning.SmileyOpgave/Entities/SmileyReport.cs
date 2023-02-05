using SmartLearning.SmileyOpgave.Models;
using System.ComponentModel;

namespace SmartLearning.SmileyOpgave.Entities
{
    public class SmileyReport
    {
        public int Id { get; set; }
        public SmileyRating Smiley { get; set; }
        public int CompanyId { get; set; }
        public DateOnly DateForSmiley { get; set; }


        public enum SmileyRating
        {
            Happy = 1,
            Balanced = 2,
            Sad = 3
        }
    }
}
