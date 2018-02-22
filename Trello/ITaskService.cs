namespace Trello
{
    public interface ITaskService
    {
        void Add(string description);
        void Delete(int id);
    }
}