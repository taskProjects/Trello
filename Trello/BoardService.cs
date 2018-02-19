namespace Trello
{
    public class BoardService : IBoardService
    {
        IBoardDAO boardDao = new BoardDAO();
        ColumnService ColumnService = new ColumnService();
        public ColumnService GetColumnService()
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