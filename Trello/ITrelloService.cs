namespace Trello
{
    public interface ITrelloService:ITaskService
    {
        void Add(string name);
        void Delete(int id);
        void LoadInitialInterface(Form1 form);
    }
}