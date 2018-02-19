namespace Trello
{
    public class BoardService : IBoardService
    {
        IBoardDAO boardDao = new BoardDAO();
        IColumnService ColumnService = new ColumnService();
        public IColumnService GetColumnService()
        {
            return ColumnService;
        }
        public void Add(string name)
        {
            boardDao.Add(name);
        }

        public void Delete(int id)
        {
            boardDao.Delete(id);
        }
    }
}