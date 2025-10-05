namespace Lab_5_oop_arv.Animals.Birds
{
    internal class Ostrich : Bird
    {
        public double RunningSpeed { get; set; }
        public Ostrich(string name, int age) : base(name, age)
        {
            Species = "Ostrich";
        }


        public void RunFast()
        {
            Console.WriteLine($"{Name} is a {Species} and runs at {RunningSpeed} km/h!!");
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {Species} is trying to say something..");
        }
    }
}
