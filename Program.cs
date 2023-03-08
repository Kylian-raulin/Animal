// See https://aka.ms/new-console-template for more information
using A = Animal.Models;

class Program
{
    static void Main(string[] args)
    {
        A.Animal cat = new A.Animal();
        A.Animal dog = new A.Animal("toto");

        cat.Move();
        dog.Sleep();

        Console.WriteLine();
        Console.ReadLine();
    }
}