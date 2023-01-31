namespace SmartLearning.SmileyOpgave.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cvr { get; set; }
        public SmileyRating CurrentSmileyRating { get; set; }
        public DateOnly DateForLatestSmiley { get; set; }


        public enum SmileyRating
        {
            Happy,
            Balanced,
            Sad
        }
    }
}
