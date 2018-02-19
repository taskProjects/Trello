namespace Trello
{
    public interface ITaskDAO
    {
        void Add(string description);
        void Delete(int id);
    }
}