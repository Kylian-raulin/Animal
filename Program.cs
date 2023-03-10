﻿// See https://aka.ms/new-console-template for more information
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

        Dragon myAnimal2 = new Dragon();
        myAnimal2.Moove();
        myAnimal2.Sleep();


        Dog dog = new Dog("blue", "Epic", 10, 17);
        Dragon enderDragon = new Dragon("Ender Dragon", "Legendary", 99, 15);
        Griffin griffin = new Griffin("Griffe", "Rare", 5, 12);
        Dragon ptera = new Dragon("Ptera", "Commun", 1, 8);
        Dog wolf = new Dog("Wolf", "Commun", 2, 2);
        Dog ben = new Dog("Ben", "Commun", 20, 32);

        Animal.Models.Animals.Animal[] liste = { dog, enderDragon, griffin, ptera, wolf, ben };

        IEnumerable<Animal.Models.Animals.Animal> listeAnimaux =
            from animaux in liste
            where animaux.Type == "Commun"
            select animaux;

        var sortedliste = listeAnimaux.OrderByDescending(c => c.Id).ToList();

        IEnumerable<Animal.Models.Animals.Animal> listeAnimauxAge =
            from animauxAge in sortedliste
            where animauxAge.age >= 12 && animauxAge.age <= 15
            select animauxAge;
        foreach (Animal.Models.Animals.Animal animaux in sortedliste)
        {
            Console.WriteLine(animaux.name + " " + animaux.age);
        }
        //Dog dog1 = new Dog("blue");
        //Dog dog2 = new Dog("red");
        //Dog dog3 = new Dog("snow");
        //Dog dog4 = new Dog("yellow");
        //Dog dog5 = new Dog("purple");
        //Dog[] dogs = { dog1, dog2, dog3, dog4, dog5 };

        ///IEnumerable<Dog> differentThanSnow =
        // from dog in dogs
        //where dog.dogName != "snow"
        //select dog;

        //Console.WriteLine("les chien sont : ");
        //foreach (Dog dog in differentThanSnow)
        //{
        //    Console.WriteLine(dog.dogName);
        //}

        Console.ReadLine();
    }

}