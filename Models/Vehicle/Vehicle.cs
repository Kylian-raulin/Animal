using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Animal.Services;

namespace Animal.Models.Vehicle
{
    public class Vehicle : ISteering
    {
        public void Moove()
        {
            Console.WriteLine("is moving");
        }
    }
}
