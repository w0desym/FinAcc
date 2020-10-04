using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinAcc
{
    public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Amount { get; set; }
    }
}
