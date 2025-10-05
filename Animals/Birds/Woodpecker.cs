namespace Lab_5_oop_arv.Animals.Birds
{
    internal class Woodpecker : Bird
    {
        public string FavoriteTree { get; set; } = "Pine";

        public Woodpecker(string name, int age) : base(name, age)
        {
            Species = "Woodpecker";
        }

        public void Peck()
        {
            Console.WriteLine($"{Name} pecks on a {FavoriteTree} tree.");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says: tap-tap-tap!");
        }
    }
}
