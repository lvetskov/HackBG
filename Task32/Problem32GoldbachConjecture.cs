using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task32
{
    //Implement a function, called goldbach(n) which returns a list of tupples, that is the goldbach conjecture for the given number n
    //The Goldbach Conjecture states:
    //Every even integer greater than 2 can be expressed as the sum of two primes.
    //Keep in mind that there can be more than one combination of two primes, that sums up to the given number.
    //The result should be sorted by the first item in the tuple.
    class Problem32GoldbachConjecture
    {
        public static string goldbach(int number)
        {
            StringBuilder result = new StringBuilder();
            result.Append(number.ToString() + " ");
            List<int> primes = new List<int>();
            primes.Add(2);
            bool deviderOccurrence = false;
            for (int i = 3; i <= number; i++)
            {
                deviderOccurrence = false;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i % j == 0)
                    {
                        deviderOccurrence = true;
                    }                    
                }
                if (deviderOccurrence == false)
                {
                    primes.Add(i);
                }
            }
            for (int i = 0; i < primes.Count - 1; i++)
            {
                for (int j = i; j < primes.Count; j++)
                {
                    if (primes[i] + primes[j] == number)
                    {
                       result.Append("= " + primes[i].ToString());
                       result.Append(" + " + primes[j].ToString() + " ");
                    }
                }
            }
            return result.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine(goldbach(4));
            Console.WriteLine(goldbach(6));
            Console.WriteLine(goldbach(8));
            Console.WriteLine(goldbach(10));
            Console.WriteLine(goldbach(100));
        }
    }
}
