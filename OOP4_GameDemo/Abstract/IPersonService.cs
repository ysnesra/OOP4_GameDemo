using OOP4_GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_GameDemo.Abstract
{
    public interface IPersonService
    {
        void Add(Person person);    
        void Update(Person person);
        void Delete(Person person);
    }
}
