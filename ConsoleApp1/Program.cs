using ConsoleApp1;


string[] arry = { "CAT", "DOG", "BIRD", "FISH"};

Cat c1= new Cat("Bobtail",3,"female",100,250,2);
Cat c2= new Cat("Keuda",2,"female",90,200,1.5f);
Cat c3= new Cat("Wirehair",1,"female",80,300,2);
Cat c4= new Cat("Balinese",4,"female",70,150,1);
Cat c5= new Cat("Birman",2,"female",60,400,2.5f);

Cat[] cats = new Cat[] { c1, c2, c3, c4, c5 };




Dog d1 = new Dog("Azavak", 3, "male", 100, 300, 3);
Dog d2 = new Dog("Buldoq", 2, "male", 90, 140, 1.5f);
Dog d3 = new Dog("Dalmatin", 1, "male", 80, 200, 1);
Dog d4 = new Dog("Kanqal", 4, "male", 70, 400, 1);
Dog d5 = new Dog("Senbernar", 2, "male", 60, 1000, 2.5f);

Dog[] dogs = new Dog[] { d1, d2, d3, d4, d5 };



Bird b1 = new Bird("Berqut", 3, "female", 100, 90, 1);
Bird b2 = new Bird("Qutan", 2, "male", 90, 100, 1.5f);
Bird b3 = new Bird("Leylek", 1, "female", 80, 500, 4);
Bird b4 = new Bird("Qaranaz", 4, "male", 70, 120, 1);
Bird b5 = new Bird("Moryanka", 2, "female", 60, 350, 2.5f);

Bird[] birds = new Bird[] { b1, b2, b3, b4, b5 };


Fish f1 = new Fish("Capaq", 1, "male", 100, 20, 3.2f);
Fish f2 = new Fish("Xesem", 1, "female", 90, 30, 1.5f);
Fish f3 = new Fish("Karp", 1, "male", 80, 40, 1.7f);
Fish f4 = new Fish("Uzunburun", 1, "female", 70, 50, 1);
Fish f5 = new Fish("Naqqa", 1, "male", 60, 60, 4.9f);

Fish[] fishes = new Fish[] { f1, f2, f3, f4, f5 };




static void show(string[] menyu, int a)
{
    for (int i = 0; i < menyu.Length; i++)
    {
        if (a == i) Console.ForegroundColor = ConsoleColor.Red;
        else Console.ResetColor();
        Console.WriteLine(menyu[i]);
    }
}



static int menyu(string[] arry)
{
    int a = 0;
    while (true)
    {
        Console.Clear();
        show(arry, a);
        var secim = Console.ReadKey();
        if (secim.Key == ConsoleKey.DownArrow)
        {
            if (a == arry.Length - 1) a = 0;
            else a++;
        }
        else if (secim.Key == ConsoleKey.UpArrow)
        {
            if (a == 0) a = arry.Length - 1;
            else a--;
        }
        if (secim.Key == ConsoleKey.Enter) {
            Console.ResetColor();
            return a; 
        }

    }

}



float allprice(Animal[][] animals, int a)
{
    float cem = 0;
    for (int i = 0; i < animals.Length; i++)
    {
        if(i == a)
        {
            for (int j = 0; j < animals[a].Length; j++)
            {
                cem += animals[a][j].Price;
            }
            return cem;
        }
    }
    return 0;
}



float allmeal(Animal[][] animals, int a)
{
    float cem = 0;
    for (int i = 0; i < animals.Length; i++)
    {
        if (i == a)
        {
            for (int j = 0; j < animals[a].Length; j++)
            {
                cem += animals[a][j].Meal_quantity;
            }
            return cem;
        }
    }
    return 0;
}



string[] menyu1 = new string[] { "Sleep", "Eat", "Play", "Sound", "All Price", "All Meal Quantity","Exit" };

Animal[][] animals = new Animal[4][];
animals[0] = cats;
animals[1] = dogs;
animals[2] = birds;
animals[3] = fishes;

Console.Clear();

int secme1 = menyu(arry);

int secme3=0;


    int secme2 = menyu(menyu1);
if (secme2 >= 0 && secme2 <= 3) {

    if (secme1 == 0)
    {
        string[] y1 = new string[cats.Length];
        for (int i = 0; i < cats.Length; i++)
        {
            y1[i] = cats[i].Id.ToString();
        }
        secme3 = menyu(y1);
    }

    else if (secme1 == 1)
    {
        string[] y2 = new string[dogs.Length];
        for (int i = 0; i < dogs.Length; i++)
        {
            y2[i] = dogs[i].Id.ToString();
        }
        secme3 = menyu(y2);
    }

    else if (secme1 == 2)
    {
        string[] y3 = new string[dogs.Length];
        for (int i = 0; i < birds.Length; i++)
        {
            y3[i] = birds[i].Id.ToString();
        }
        secme3 = menyu(y3);
    }


    else if (secme1 == 3)
    {
        string[] y4 = new string[dogs.Length];
        for (int i = 0; i < fishes.Length; i++)
        {
            y4[i] = fishes[i].Id.ToString();
        }
        secme3 = menyu(y4);
    }


    for (int j = 0; j < secme2; j++)
    {
        if (secme2 == 0)
        {
            for (int i = 0; i < animals[secme1].Length; i++)
            {
                if (secme3 == i)
                {
                    Console.Clear();
                    Console.Write(animals[secme1][i].Nick_name + " ");
                    animals[secme1][i].Sleep();
                    break;
                }
            }
            break;
        }

        else if ( secme2 == 1)
        {
            for (int i = 0; i < animals[secme1].Length; i++)
            {
                if (secme3 == i)
                {
                    Console.Clear();
                    Console.Write(animals[secme1][i].Nick_name + " ");
                    animals[secme1][i].Eat();
                    break;
                }
            }
            break;
        }

        else if ( secme2 == 2)
        {
            for (int i = 0; i < animals[secme1].Length; i++)
            {
                if (secme3 == i)
                {
                    Console.Clear();
                    Console.Write(animals[secme1][i].Nick_name + " ");
                    animals[secme1][i].Play();
                    break;
                }
            }
            break;
        }

        else if ( secme2 == 3)
        {
            for (int i = 0; i < animals[secme1].Length; i++)
            {
                if (secme3 == i)
                {
                    Console.Clear();
                    Console.Write(animals[secme1][i].Nick_name + " ");
                    animals[secme1][i].Sound();
                    break;
                }
            }
            break;
        }

       
   
    }

}
   
else if(secme2 == 4)
{           Console.Clear();
            Console.WriteLine($"All Price: {allprice(animals,secme1)} ");

}

else if (secme2 == 5)
{
    Console.Clear();
    Console.WriteLine($"All Price: {allmeal(animals, secme1)} ");

}

else 
{
    Console.Clear();
    Console.WriteLine("EXIT...");

}










