using Lab_5_oop_arv.Animals;
using Lab_5_oop_arv.Animals.Birds;


namespace Lab_5_oop_arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalsList = new List<Animal>();

            animalsList.Add(new Dog("Smokey", 2));
            animalsList.Add(new Cat("Luna", 15));
            animalsList.Add(new Bird("Rio", 3));
            animalsList.Add(new Woodpecker("Molly", 3));
            animalsList.Add(new Ostrich("Kiwi", 2));

            foreach (Animal a in animalsList)
            {
                a.MakeSound();
            }

            var ostrich = new Ostrich("Ozzy", 2) { RunningSpeed = 70, CanFly = false, Weight = 74 };
            ostrich.RunFast();

            var woodpecker = new Woodpecker("Birdy", 1) { CanFly = true };
            woodpecker.Peck();
        }
    }
}
