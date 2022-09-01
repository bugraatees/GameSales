using GameSales.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSales.Entities
{
    public class Game : IEntity
    {
        public int  Id { get; set; }
        public string GameName { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnıtInStock { get; set; }

    }
}
