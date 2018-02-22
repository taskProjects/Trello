namespace Trello
{
    public interface ITrelloDAO
    {
        void Add(string name);
        void Delete(int id);
    }
}