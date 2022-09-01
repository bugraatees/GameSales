using GameSales.Abstract;
using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSales.Concrete
{
    public class GameManager : ISaleService
    {
        public void Sell(Game game, Gamer gamer)
        {
            Console.WriteLine("{0} games , {1} purchased by" , game.GameName , gamer.FirstName + " " + gamer.LastName); 
        }
    }
}
