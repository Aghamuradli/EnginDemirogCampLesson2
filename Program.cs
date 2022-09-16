using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Clothes Clothes1 = new Clothes();
            Clothes1.name = "T-shirt";
            Clothes1.price = 109.99;
            Clothes1.count = 12;
            Clothes1.color = "Blue";

            Clothes Clothes2 = new Clothes();
           Clothes2.name = "Pants";
           Clothes2.price = 99.99;
           Clothes2.count = 20;
           Clothes2.color = "Red";

            Clothes Clothes3 = new Clothes();
           Clothes3.name = "Jeans";
           Clothes3.price = 89.99;
           Clothes3.count = 15;
           Clothes3.color = "Black";

            Clothes[] clothes = new Clothes[] { Clothes1, Clothes2, Clothes3 };

            Console.WriteLine("-------------For-------------");
            for (int i = 0; i < clothes.Length; i++)
            {
                Console.WriteLine("Name:" + "  " + clothes[i].name);
                Console.WriteLine("Price:" + "  " + clothes[i].price);
                Console.WriteLine("Count:" + "  " + clothes[i].count);
                Console.WriteLine("Color:" + "  " + clothes[i].color);
                Console.WriteLine("---------");
            }
            Console.WriteLine("-------------while-------------");
            int a = 0;
            while (a < 3)
            {
                Console.WriteLine("Name:" + "  " + clothes[a].name);
                Console.WriteLine("Price:" + "  " + clothes[a].price);
                Console.WriteLine("Count:" + "  " + clothes[a].count);
                Console.WriteLine("Color:" + "  " + clothes[a].color);
                Console.WriteLine("---------");
                a++;
            }
            Console.WriteLine("-------------foreach-------------");
            foreach (var cl in clothes)
            {
                Console.WriteLine("Name:" + "  " + cl.name);
                Console.WriteLine("Price:" + "  " + cl.price);
                Console.WriteLine("Count:" + "  " + cl.count);
                Console.WriteLine("Color:" + "  " + cl.color);
                Console.WriteLine("----------");
            }
        }

        class Clothes
        {
            public string name { get; set; }
            public double price { get; set; }
            public double count { get; set; }
            public string color { get; set; }
        }
    }
}
