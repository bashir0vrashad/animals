namespace ConsoleApp1
{
    public class Dog : Animal
    {

        public Dog() : base() { }
        public Dog(string nick_name, int age, string gender, float energy, float price, float meal_quantity) : base(nick_name, age, gender, energy, price, meal_quantity) { }


        public override void Sleep() { 
            Console.WriteLine("Dog Sleep......");
            this.Energy += 5;
        }
        public override void Play() { 
            Console.WriteLine("Dog Play......");
            this.Energy -= 5;
            if (this.Energy >= 0 && this.Energy <= 5) { Sleep(); }
        }
        public override void Eat() { 
            Console.WriteLine("Dog  Eat......");
            this.Energy += 5;
            this.Price += 50;
        }

        public override void Sound() { Console.WriteLine("Dog Sound....."); }
    }
}
