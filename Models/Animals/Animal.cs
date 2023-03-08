namespace Animal.Models.Animals
{
    abstract public class Animal
    {
        public string Name { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"{Name} il a bougé");
        }

        public virtual void Sleep()
        {
            Console.WriteLine($"{Name} il dort");
        }

        public Animal()
        {
            Name = "baguera";
        }

        public Animal(string name)
        {
            this.Name = name;
        }

    }
}
