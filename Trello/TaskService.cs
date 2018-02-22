namespace Trello
{
    public class TaskService:ITaskService
    {
        public ITaskDAO TaskDao { get; set; }

        public TaskService()
        {
            TaskDao=new TaskDAO();
        }
        public void Add(string description)
        {
           TaskDao.Add(description);
        }

        public void Delete(int id)
        {
            TaskDao.Delete(id);
        }
    }
}