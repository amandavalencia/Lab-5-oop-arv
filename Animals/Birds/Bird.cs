namespace Lab_5_oop_arv.Animals.Birds
{
    internal class Bird : Animal
    {
        public bool CanFly { get; set; } = false;

        public Bird(string name, int age) : base(name, age) { }

        public void Sing()
        {
            Console.WriteLine($"{Name} sings a beautiful melody.");
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} chirps!");
        }
    }
}
