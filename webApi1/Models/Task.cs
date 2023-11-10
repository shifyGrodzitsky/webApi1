namespace webApi1.Models
{
    public class Task
    {
        public string Title { get; set; }
        public int Description { get; set; }
        public DateTime EndDate { get; set; }
        public Preference Preference { get; set; }
        


        public Task(string title, string description, DateTime time, Preference preference)
        {
            Id++;
            Title = title;
            Description = description;
            EndDate = time;
            Preference = preference;

        }


    }
}
