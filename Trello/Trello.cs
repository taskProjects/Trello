namespace Trello
{
    public class Trello
    {
        private static Trello instance;
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