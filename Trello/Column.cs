using System.Collections.Generic;

namespace Trello
{
    public class Column
    {
        public string Name { get; set; }
        public int ID { get; set; }
        private static int NextID;
        public List<Task> Tasks { get; set; }
        public Column()
        {
            Tasks=new List<Task>();
            ID = NextID++;
        }
    }
}