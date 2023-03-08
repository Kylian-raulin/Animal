namespace Animal.Models
{ 
    public class Animal
    {
        public string Name;

        public void Move()
        {
            Console.WriteLine($"{Name} il a bougé");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} il dort");
        }

        public Animal()
        {
            this.Name = "baguera";
        }

        public Animal(string name)
        {
            this.Name = name;
        }

    }
}
