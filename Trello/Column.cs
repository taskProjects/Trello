using System.Collections.Generic;

namespace Trello
{
    public class Column
    {
        public string Name { get; set; }
        public int ID { get; set; }
        private static int NextID;
        public Column()
        {
            ID = NextID++;
        }
    }
}