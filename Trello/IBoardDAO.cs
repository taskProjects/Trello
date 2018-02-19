using System.Collections.Generic;

namespace Trello
{
    public interface IBoardDAO
    {
        void Add(string name);
        void Delete(int id);
    }
}