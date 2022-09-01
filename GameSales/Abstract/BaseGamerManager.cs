using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSales.Abstract
{
    public class BaseGamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("Added to gamer : " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Delete to gamer : " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Update to gamer : " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
