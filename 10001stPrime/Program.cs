using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            int _MAXPRIME = 10001;

            List<int> primeList = new List<int>();

            for (int i = 2; i < int.MaxValue; i++)
            {
                if (IsPrime(i))
                    primeList.Add(i);

                if (primeList.Count == _MAXPRIME)
                    break;
            }

            Console.WriteLine("10,001st Prime is: {0}", primeList[_MAXPRIME-1]);
            Console.ReadLine();
        }

        private static bool IsPrime(int i)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                    return false;
            }

            return true;
        }
    }
}
