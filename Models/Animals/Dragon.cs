using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Models.Animals
{
    class Dragon : Animal
    {
        public Dragon()
        {
            dragonName = "Dragon";
        }
        public string dragonName { get; private set; }

        public override void Move()
        {
            Console.WriteLine($"{dragonName} move");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{dragonName} sleep");
        }
    }
}
