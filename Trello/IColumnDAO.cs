namespace Trello
{
    public interface IColumnDAO
    {
        void Add(string name);
        void Remove(int id);
    }
}