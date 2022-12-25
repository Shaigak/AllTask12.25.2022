using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public string Position { get; set; }

        public Customer(int id, string name, string surname, string address, string position, int age)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Address = address;
            Position = position;
            Age = age;
        }
    }
}
