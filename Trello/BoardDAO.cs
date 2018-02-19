using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Trello
{
    public class BoardDAO:IBoardDAO
    {
        public List<Board> Boards { get; set; }
        public Board _Board { get; set; }
        public BoardDAO()
        {
            Boards=new List<Board>();
        }
        public void Add(string name)
        {
            _Board=new Board() {Name = name};
            Boards.Add(_Board);
        }

        public void Delete(int id)
        {
            Boards.Remove(Boards.Find(x => x.ID == id));
        }
    }
}