namespace Trello
{
    public class ColumnService:IColumnService
    {
        IColumnDAO columnDao=new ColumnDAO();
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