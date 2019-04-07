using System;

namespace Practice_10_01
{
    public class Money
    {
        const int DEFAULT_PAR = 1000;
        const int DEFAULT_COUNT = 10;

        public int Par { get; }
        public int Count { get; set; }
        public int Total {
            get
            {
                return Par * Count;
            }
        }

        public Money(int par, int count)
        {
            if(par <= 0)
            {
                Par = DEFAULT_PAR;
            }
            else Par = par;

            if(Count <= 0)
            {
                Count = DEFAULT_COUNT;
            }
            else Count = count;
        }

        public void Print()
        {
            Console.WriteLine($"Номинал : {Par}");
            Console.WriteLine($"Кол-во  : {Count}");
        }

        public bool CanBuy(int cost)
        {
            if(Par * Count >= cost)
            {
                return true;
            }
            return false;
        }

        public int HowManyCanBuy(int cost)
        {
            return (Par * Count) / cost;
        }
    }
}
