using OOP4_GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_GameDemo.Entities
{
    public class Person : IEntity
    {
        public int Id { get; set; }
        public string NationalityId { get; set; }  //Tc
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
