namespace Trello
{
    public interface IColumnDAO
    {
        void Add(string name);
        void Delete(int id);
    }
}