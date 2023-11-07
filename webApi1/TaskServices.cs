
using webApi1.Models;
using Task = webApi1.Models.Task;

namespace webApi1
{
    public class TaskServices
    {
        static List<Task> taskList = new List<Task>();
        Task t;
        public Task createTask(string title, string description, DateTime time, Preference preference)
        {
            t = new Task(title, description, time, preference);
            taskList.Add(t);
            return t;
        }

        public bool deleteTask(int id)
        {
            t = taskList.Find(e => e.Id == id);
            if (t == null) return false;
            taskList.Remove(t);
            return true;
        }

        public Task updateTask(int id, string title, string description, DateTime time, Preference preference)
        {
            int i = taskList.FindIndex(e => e.Id == id);
            if (i != -1)
            {
                taskList[i].Title = title;
                taskList[i].Description = description;
                taskList[i].EndDate = time;
                taskList[i].Preference = preference;
                return taskList[i];
            }
            else
                return null;



        }
    }
}
