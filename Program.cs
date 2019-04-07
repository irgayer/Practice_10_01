using System;

namespace Practice_10_01
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PRODUCT_COST = 1400;

            Money money = new Money(0, 0);
            if (money.CanBuy(PRODUCT_COST))
            {
                Console.WriteLine("Это можно купить");
                Console.WriteLine($"Так же в кол-ве {money.HowManyCanBuy(PRODUCT_COST)} штук ");
            }
            else
            {
                Console.WriteLine("Не хватает денег!");
                Console.WriteLine($"У вас {money.Total}, а нужно {PRODUCT_COST}");
            }

            Console.ReadLine();
        }
    }
}
