using System.Collections.Generic;

namespace Trello
{
    public class Trello
    {
        private static Trello instance;
        public IBoardService BoardService { get; set; }
       // public Dictionary<Board,List<Column>> _Board { get; set; }
        private Trello()
        {
            BoardService=new BoardService();
        }
        public static Trello Instance
        {
            get
            {
                if (instance == null)
                {
                    instance=new Trello();
                }

                return instance;
            }
        }
    }
}