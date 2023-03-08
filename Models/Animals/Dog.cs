using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal.Models.Animals
{
    class Dog : Animal
    {
        public string dogName { get; private set; }

        public Dog(string name)
        {
            this.dogName = name;
        }
    }
}
