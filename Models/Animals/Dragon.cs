using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animal.Services;

namespace Animal.Models.Animals
{
    class Dragon : Animal, ISteering
    {
        public Dragon()
        {
            name = "Dragon";
        }

        public Dragon(string name, string type, int ID, int age)
        {
            this.name = name;
            this.Type = type;
            this.Id = ID;
            this.age = age;
        }
        public void Moove()
        {
            Console.WriteLine($"{name} move");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{name} sleep");
        }
    }
}
