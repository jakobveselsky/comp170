using System;
using System.Collections.Generic;

namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            double input = 0;
            List<double> valuesList = new List<double>();

            Console.WriteLine("Please enter how many values you have in your list:");
            n = Double.Parse(Console.ReadLine());

            for(int i = 1; i<n+1; i++)
            {
                Console.WriteLine("Please enter the " + i + " item in your list:");
                input = Double.Parse(Console.ReadLine());
                valuesList.Add(input);
            }

            Console.WriteLine("Max value is: " + maxValue(valuesList, n));
        }

        static double maxValue(List<double> list, double length)
        {
            double ans = list[0];
            for(int j = 1; j < length; j++)
            {
                if(ans< list[j])
                {
                    ans = list[j];
                }
            }
            return ans;
        }
    }
}
