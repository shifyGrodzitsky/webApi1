using webApi1.Models;

namespace webApi1
{
    public class TaskServices
    {
        public void CreatTask(Task t)
        {
            t = taskList.Find(e => e.Id == id);
            if (t == null) return false;
            taskList.Remove(t);
            return true;
        }

        public Tasks UpdateTask(int id, string title, string description, DateTime time, Preference preference)
        {
            int i = taskList.FindIndex(e => e.Id == id);
            if (i != -1)
            {
                taskList[i].Title = title;
                taskList[i].Description = description;
                taskList[i].Time = time;
                taskList[i].MyPreference = preference;
                return taskList[i];
            }
            else
                return null;



        }
    }
}
}
