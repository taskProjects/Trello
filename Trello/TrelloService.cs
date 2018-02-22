using System.Windows.Forms.VisualStyles;

namespace Trello
{
    public class TrelloService
    {

        public void Add(string name)
        {
            var board = Trello.Instance.BoardService as BoardService;
            board.BoardDao.Add(name);
        }

        public void Delete(int id)
        {
            var board = Trello.Instance.BoardService as BoardService;
            board.BoardDao.Delete(id);
        }
        public void LoadInitialInterface(Form1 form)
        {
            Trello.Instance.BoardService.Add("TABLE");
            var boardService = Trello.Instance.BoardService as BoardService;
            boardService.ColumnService.Add("BUGS");
            boardService.ColumnService.Add("IN PROCESS");
            boardService.ColumnService.Add("SOLVED");
        }
    }
}