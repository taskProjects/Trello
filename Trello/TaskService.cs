namespace Trello
{
    public class TaskService:ITaskService
    {
        ITaskDAO taskDao=new TaskDAO();
        public void Add(string description)
        {
            taskDao.Add(description);
        }

        public void Delete(int id)
        {
            taskDao.Delete(id);
        }
    }
}