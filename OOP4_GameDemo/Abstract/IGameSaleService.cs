using OOP4_GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_GameDemo.Abstract
{
    public interface IGameSaleService
    {
        void Add(GameSale gamesale);
        void Update(GameSale gamesale);
        void Delete(GameSale gamesale);
    }
}
