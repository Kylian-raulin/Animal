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
            dragonName = "Dragon";
        }
        public string dragonName { get; private set; }

        public void Moove()
        {
            Console.WriteLine($"{dragonName} move");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{dragonName} sleep");
        }
    }
}
