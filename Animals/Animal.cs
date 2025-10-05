namespace Lab_5_oop_arv.Animals
{
    internal class Animal
    {
        public string Name { get; set; } = "Unknown";
        public int Age { get; set; } = 0;
        public string Diet { get; set; } = "Unknown";
        public string Species { get; set; } = "Unknown";
        public int Weight { get; set; } = 0;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");
        }
        public void Move()
        {
            Console.WriteLine($"{Name} is moving.");

        }
        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name} is making sounds.");

        }

    }
}
