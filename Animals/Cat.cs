namespace Lab_5_oop_arv.Animals
{
    internal class Cat : Animal
    {
        public bool IsIndoor { get; set; } = false;
        public bool LikesToClimb { get; set; } = false;

        public Cat(string name, int age) : base(name, age)
        {
            Species = "Cat";
        }

        public void Climb()
        {
            if (LikesToClimb)
                Console.WriteLine($"{Name} climbs up the tree!");
            else
                Console.WriteLine($"{Name} prefers to lay on the sofa.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }
}
