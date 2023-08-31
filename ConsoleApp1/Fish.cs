namespace ConsoleApp1
{
    public class Fish: Animal
    {
        public Fish() : base() { }
        public Fish(string nick_name, int age, string gender, float energy, float price, float meal_quantity) : base(nick_name, age, gender, energy, price, meal_quantity) { }


        public override void Sleep() { 
            Console.WriteLine("Fish Sleep......");
            this.Energy += 1;
        }
        public override void Play() {
            Console.WriteLine("Fish Play......");
            this.Energy -= 1;
            if (this.Energy >= 0 && this.Energy <= 1) { Sleep(); }
        }
        public override void Eat() { 
            Console.WriteLine("Fish  Eat......");
            this.Energy += 1;
            this.Price += 10;
        }

        public override void Sound() { Console.WriteLine("Fish Sound....."); }

    }
}
