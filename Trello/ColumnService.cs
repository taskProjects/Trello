namespace Trello
{
    public class ColumnService
    {
        ColumnDAO columnDao=new ColumnDAO();
        public TaskDAO TaskDao { get; set; }
        public ColumnService()
        {
            TaskDao = new TaskDAO();
        }
        public void Add(string name)
        {
            columnDao.Add(name);
        }

        public void Delete(int id)
        {
            columnDao.Delete(id);
        }
    }
}