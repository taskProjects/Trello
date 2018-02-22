using System.Collections.Generic;

namespace Trello
{
    public class ColumnDAO:IColumnDAO
    {
        public List<Column> Columns { get; set; }
        public Column _Column { get; set; }
        public ColumnDAO()
        {
            Columns=new List<Column>();
        }
        public void Delete(int id)
        {
            Columns.Remove(Columns.Find(x => x.ID == id));
        }
        public void Add(string name)
        {
            _Column = new Column() { Name = name };
            Columns.Add(_Column);
        }
    }
}