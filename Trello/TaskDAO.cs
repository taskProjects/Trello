using System.Collections.Generic;

namespace Trello
{
    public class TaskDAO:ITaskDAO
    {
        public List<Task> Tasks { get; set; }
        public Task _Task { get; set; }
        public TaskDAO()
        {
            Tasks=new List<Task>();
        }
        public void Add(string description)
        {
           _Task=new Task();
            _Task.Description = description;
            Tasks.Add(_Task);
        }

        public void Delete(int id)
        {
            Tasks.Remove(Tasks.Find(x => x.ID == id));
        }
    }
}