namespace Animal.Models.Animals
{
    abstract public class Animal
    {
        public string name { get; set; }
        public string Type { get; set; }
        public int Id { get; set; }
        public int age { get; set; }
      
        public virtual void Moove()
        {
            Console.WriteLine($"{name} il a bougé");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{name} il dort");
        }

        public Animal()
        {
            this.name = "baguera";
            this.Type = "commun";
            this.Id = 1;
            this.age = 12;
        }

        public Animal(string name, string type, int id, int age)
        {
            this.name = name;
            this.Type = type;
            this.Id = id;
            this.age = age;
        }

    }
}
