namespace ConsoleApp1
{
    public abstract class Animal
    {
        private Guid id;
        private string nick_name;
        private int age;
        private string gender;
        private float energy;
        private float price;
        private float meal_quantity;


        public Guid Id { get; set; }

        public string Nick_name
        {
            get => nick_name;
            set
            {
                if (value.Length >= 3) nick_name = value;
                else throw new Exception("NICKNAME Error...");
            }
        }
        public int Age
        {
            get => age;
            set
            {
                if (value >= 0) age = value;
                else throw new Exception("AGE Error...");
            }
        }

        public string Gender { get; set; }

        public float Energy
        {
            get => energy;
            set
            {
                if (value >= 0) energy = value;
                else throw new Exception("ENERGY Error...");
            }
        }

        public float Price
        {
            get => price;
            set
            {
                if (value >= 0) price = value;
                else throw new Exception("PRICE Error...");
            }
        }


        public float Meal_quantity
        {
            get => meal_quantity;
            set
            {
                if (value >= 0) meal_quantity = value;
                else throw new Exception("MEAL QUANTITY Error...");
            }
        }

        public virtual void Sleep() { Console.WriteLine("Sleep......"); }
        public virtual void Play() { Console.WriteLine("Play......");}

        public virtual void Eat() { Console.WriteLine(" Eat......"); }

        public virtual void Sound() { Console.WriteLine("Animal Sound...."); }



        public Animal()
        {
            Id = Guid.NewGuid();
            Nick_name = "NULL";
            Age = 1;
            Gender = "Null";
            Energy = 100;
            Price = 0;
            Meal_quantity = 0;
        }

        public Animal(string nick_name, int age, string gender, float energy, float price, float meal_quantity) : this()
        {
            Nick_name = nick_name;
            Age = age;
            Gender = gender;
            Energy = energy;
            Price = price;
            Meal_quantity = meal_quantity;
        }


    }


}
