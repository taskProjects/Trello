namespace Trello
{
    public interface IColumnService
    {
        void Add(string name);
        void Delete(int id);
    }
}