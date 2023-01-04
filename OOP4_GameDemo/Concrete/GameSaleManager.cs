using OOP4_GameDemo.Abstract;
using OOP4_GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_GameDemo.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        public void Add(GameSale gamesale)
        {
            if(gamesale.Campaign!=null)
            {
                //indirimlifiyatı oyununfiyatına atadım
                gamesale.Game.GamePrice = ApplyDiscount(gamesale.Game, gamesale.Campaign); 
                
                Console.WriteLine(gamesale.Game.GameName + " game is sold to " + gamesale.Person.FirstName + " with discount "); //indirmli satış
            }
            else
            { 
                Console.WriteLine(gamesale.Game.GameName + " game is sold to " + gamesale.Person.FirstName + " without discount"); //indirimsiz satış
            }

            
        }

        public void Delete(GameSale gamesale)
        {
            Console.WriteLine(gamesale.Game.GameName + "game is deleted" );
        }

        public void Update(GameSale gamesale)
        {
            Console.WriteLine(gamesale.Game.GameName + "game is updated" );
        }


        //İndirim uygula metotu____oyuna uygulanan kampanya hesaplanır

        public double ApplyDiscount(Game game, Campaign campaign)
        {
            double discountedPrice = 0;  //indirimli fiyat
            discountedPrice = game.GamePrice - ((game.GamePrice * campaign.DiscountRate) / 100);
            return discountedPrice;
        }
    }
}
