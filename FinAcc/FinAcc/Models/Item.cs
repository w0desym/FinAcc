using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinAcc.Models
{
    class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
    }
}
