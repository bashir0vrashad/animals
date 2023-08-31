namespace ConsoleApp1
{
    public class Cat : Animal
    {
        public Cat() : base() { }
        public Cat(string nick_name, int age, string gender, float energy, float price, float meal_quantity) : base(nick_name, age, gender, energy, price, meal_quantity) { }


        public override void Sleep() {
            Console.WriteLine("Cat Sleep......");
            this.Energy += 10;
        }
        public override void Play() {
            Console.WriteLine("Cat Play......");
            this.Energy -= 10;
            if (this.Energy >= 0 && this.Energy <= 10) { Sleep(); }
        }
        public override void Eat() {
            Console.WriteLine("Cat  Eat......");
            this.Energy += 10;
            this.Price += 100;
        }

        
        public override void Sound() { Console.WriteLine("Cat Sound....."); }
    }



}
