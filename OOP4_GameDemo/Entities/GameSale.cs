using OOP4_GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_GameDemo.Entities
{
    public class GameSale: IEntity
    {
        public int Id { get; set; }
        public Person Person { get; set; }
        public Game Game { get; set; }
        public Campaign Campaign { get; set; }
        public double SalePrice { get; set; }
    }
}
