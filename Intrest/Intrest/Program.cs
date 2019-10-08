using System;

namespace Intrest
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance;
            double intrest;

            balance = 0;
            intrest = 0;
            for (int k = 0; k < 1000; k++)
            {
                Console.WriteLine("Please enter your account balance:");
                balance = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your intrest rate:");
                intrest = Double.Parse(Console.ReadLine()) / 100;

                Console.WriteLine("Intrest compaounded daily for ten years is:" + Daily(balance, intrest));
                Console.WriteLine("Intrest compaounded monthly for ten years is:" + Monthly(balance, intrest));
                Console.WriteLine("Intrest compaounded annualy for ten years is:" + Yearly(balance, intrest));
            }
        }

        static double Daily(double b, double i)
        {
            double profit;
            double endBalance;

            endBalance = b;

            for (int y = 0; y < 10; y++)
            {
                for (int j = 0; j < 365; j++)
                {
                    profit = endBalance * i/365;
                    endBalance = endBalance + profit;
                }
            }

            return endBalance;
        }

        static double Monthly(double c, double o)
        {
            double p;
            double end;

            end = c;

            for (int h = 0; h < 120; h++)
            {
                p = end * o/12;
                end += p;
            }

            return end;
        }

        static double Yearly(double u, double z)
        {
            double prof;
            double endB;

            endB = u;

            for (int j = 0; j < 10; j++)
            {
                prof = endB * z;
                endB += prof;
            }

            return endB;
        }
    }
}
