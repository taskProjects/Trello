namespace Trello
{
    public class TrelloDAO:ITrelloDAO
    {
        private static ITrelloDAO instance;
        public static ITrelloDAO Instance{
            get
            {
                if (instance.Equals(null))
                {
                    instance=new TrelloDAO();
                }
                return instance;
            }
        }
        public void Add(string name)
        {
           Trello.Instance.BoardService.Add(name);
        }
        public void Delete(int id)
        {
            Trello.Instance.BoardService.Delete(id);
        }

    }
}