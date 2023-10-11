using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        for (int x = 1; x <= 300; x++)
        {
            List<string> results = new List<string>();

            if (IsDivisibleBy(x, 3))
            {
                results.Add("Fizz");
            }

            if (IsDivisibleBy(x, 5))
            {
                results.Add("Buzz");
            }

            if (IsDivisibleBy(x, 7))
            {
                results.Add("Bang");
            }

            if (IsDivisibleBy(x, 11))
            {
                results.Clear();
                results.Add("Bong");
            }

            if (IsDivisibleBy(x, 13))
            {
                bool inserted = false;
                for (int i = 0; i < results.Count; i++)
                {
                    if (results[i].StartsWith("B"))
                    {
                        results.Insert(i, "Fuzz");
                        inserted = true;
                        break;
                    }
                }
                if (!inserted)
                {
                    results.Add("Fuzz");
                }
            }

            if (IsDivisibleBy(x, 17))
            {
                results.Reverse();
            }

            if (results.Count == 0)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(string.Join("", results));
            }

            if (IsDivisibleBy(x, 17))
            {
                results.Reverse();
            }
        }
    }

    static bool IsDivisibleBy(int numerator, int denominator)
    {
        return numerator % denominator == 0;
    }
}
