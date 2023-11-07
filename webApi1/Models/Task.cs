using System.Reflection.Metadata;

namespace webApi1.Models
{
    public class Task
    {
        public int Id { get; } = 0;
        public string Title { get; set; }
        public string Description { get; set; }
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
<<<<<<< Updated upstream
        //jjkjkjkj
=======
        //hi to all!!!!
        //jkjkhug
>>>>>>> Stashed changes
        //iiuiuiji

    }
}
