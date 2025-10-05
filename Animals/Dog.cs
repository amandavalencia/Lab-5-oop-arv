namespace Lab_5_oop_arv.Animals
{
    internal class Dog : Animal
    {
        public bool IsPottyTrained { get; set; } = false;

        public Dog(string name, int age) : base(name, age)
        {
            Species = "Dog";
        }

        public void GoingForAWalk()
        {
            Console.WriteLine($"{Name} is out for a walk.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Voff!");
        }
    }
}
