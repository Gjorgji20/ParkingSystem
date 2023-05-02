using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Vehichles
{
    public class Person
    {
        public string Embg { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Age { get; set; }
        public string Address { get; set; }

        public Person()
        {
                
        }

        public Person(string embg, string name, string surname, string age, string address)
        {
            Embg = embg;
            Name = name;
            Surname = surname;
            Age = age;
            Address = address;
        }
    }
}
