// See https://aka.ms/new-console-template for more information
using System.Xml;
using Animal.Models.Animals;
using Animal.Models.Vehicle;
using A = Animal.Models;

class Program
{

    static void Main(string[] args)
    {
        Griffin myAnimal1 = new Griffin();

        myAnimal1.Sleep();
        myAnimal1.Moove();
        Console.WriteLine(myAnimal1.griffinName);

        Dragon myAnimal2 = new Dragon();
        myAnimal2.Moove();
        myAnimal2.Sleep();

        Console.WriteLine(myAnimal2.dragonName);
        


        Dog dog1 = new Dog("blue");
        Dog dog2 = new Dog("red");
        Dog dog3 = new Dog("snow");
        Dog dog4 = new Dog("yellow");
        Dog dog5 = new Dog("purple");
        Dog[] dogs = { dog1, dog2, dog3, dog4, dog5 };

        IEnumerable<Dog> differentThanSnow =
            from dog in dogs
            where dog.dogName != "snow"
            select dog;

        Console.WriteLine("les chien sont : ");
        foreach (Dog dog in differentThanSnow)
        {
            Console.WriteLine(dog.dogName);
        }

        Console.ReadLine();
    }

}