using System;
using System.Collections.Generic;

namespace Iterate
{
    class Program
    {
        private static object yeild;

        static void Main(string[] args)
        {
            List<int> things = new List<int>();
            int a = 0;
            int b = 0;

            Console.WriteLine("Enter number one: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number two: ");
            b = int.Parse(Console.ReadLine());

            for(int k = a; k < b+1; k++)
            {
                things.Add(k);
            }
            foreach (int number in RemoveOdd(a, b))
            {
                things.Remove(number);
            }
            Console.WriteLine("");
            foreach (int l in things)
            {
                Console.WriteLine(l);
            }
        }

        static IEnumerable<int> RemoveOdd(int a, int b)
        {
            for (int i = a; i < b + 1; i = i + 2)
            {
                yield return i;
            }
        }
    }
}
