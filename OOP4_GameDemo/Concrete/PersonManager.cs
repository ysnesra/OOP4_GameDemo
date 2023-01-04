using OOP4_GameDemo.Abstract;
using OOP4_GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_GameDemo.Concrete
{
    public class PersonManager : IPersonService
    {
        private IPersonCheckService _personCheckService;
        public PersonManager(IPersonCheckService personCheckService) //Dependency Injection
        {
            _personCheckService = personCheckService;
        }   

        public void Add(Person person)
        {
            if(_personCheckService.CheckIfRealPerson(person))
            {
                Console.WriteLine("Gamer : " + person.FirstName + " " + person.LastName + " is added");
            }
            else
            {
                throw new Exception("not a valid person");
            }
            
        }

        public void Delete(Person person)
        {
            Console.WriteLine("Gamer : " + person.FirstName + " " + person.LastName + " is deleted");
        }

        public void Update(Person person)
        {
            Console.WriteLine("Gamer : " + person.FirstName + " " + person.LastName + " is updated");
        }
    }
}
