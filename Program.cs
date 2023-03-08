// See https://aka.ms/new-console-template for more information
using Animal.Models.Animals;
using A = Animal.Models;

class Program
{
    static void Main(string[] args)
    {
        Griffin myAnimal1 = new Griffin();
        
        myAnimal1.Sleep();
        myAnimal1.Move();
        Console.WriteLine(myAnimal1.griffinName);
      
        Dragon myAnimal2 = new Dragon();
        myAnimal2.Move();
        myAnimal2.Sleep();

        Console.WriteLine(myAnimal2.dragonName);
        Console.ReadLine();
    }
}