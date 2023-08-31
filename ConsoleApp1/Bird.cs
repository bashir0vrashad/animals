namespace ConsoleApp1
{
    public class Bird : Animal
    {
        public Bird() : base() { }
        public Bird(string nick_name, int age, string gender, float energy, float price, float meal_quantity) : base(nick_name, age, gender, energy, price, meal_quantity) { }


        public override void Sleep() { 
            Console.WriteLine("Bird Sleep......");
            this.Energy += 3;
        }
        public override void Play() { 
            Console.WriteLine("Bird Play......");
            this.Energy -= 3;
            if (this.Energy >= 0 && this.Energy <= 3) { Sleep(); }
        }
        public override void Eat() { 
            Console.WriteLine("Bird  Eat......");
            this.Energy += 3;
            this.Price += 30;
        }

        public override void Sound() { Console.WriteLine("Bird Sound....."); }

    }
}
