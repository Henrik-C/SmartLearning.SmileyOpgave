using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace SmartLearning.SmileyOpgave.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cvr { get; set; }
        public string Address { get; set; }

        //[DisplayName("Smiley")]
        //public SmileyRating CurrentSmileyRating { get; set; }
        
        //[DisplayName("Dato for sidste smiley")]
        //public DateOnly DateForLatestSmiley { get; set; }

        //public enum SmileyRating
        //{
        //    Happy = 1,
        //    Balanced = 2,
        //    Sad = 3
        //}
    }
}
