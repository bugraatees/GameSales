using GameSales.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSales.Abstract
{
    public interface IGamerService
    {
        void Add(Gamer gmaer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
