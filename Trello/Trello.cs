namespace Trello
{
    public class Trello
    {
        private static Trello instance;

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
        public IBoardService BoardService { get; set; }
    }
}