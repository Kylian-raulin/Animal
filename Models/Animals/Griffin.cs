using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Models.Animals
{

    class Griffin : Animal
    {

        public Griffin()
        {
            griffinName = "Griffin";
        }
        public string griffinName { get; private set; }

        public override void Moove()
        {
            Console.WriteLine($"{griffinName} moove");
        }

        public new void Sleep()
        {
            Console.WriteLine($"{griffinName} sleep");
        }
    }
}

