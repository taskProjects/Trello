namespace Trello
{
    public class BoardService : IBoardService
    {
        public IBoardDAO BoardDao { get; set; }
        public IColumnService ColumnService { get; set; }
        public BoardService()
        {
            BoardDao=new BoardDAO();
            ColumnService=new ColumnService();
        }
        public void Add(string name)
        {
            BoardDao.Add(name);
        }

        public void Delete(int id)
        {
            BoardDao.Delete(id);
        }
    }
}