using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSales.Abstract
{
    public  interface ISaleService
    {
        void Sell(Game game, Gamer gamer);
    }
}
