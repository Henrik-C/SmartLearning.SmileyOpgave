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
    }
}
