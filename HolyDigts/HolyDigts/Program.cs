using System;

namespace HolyDigts
{
    class Program
    {
        static void Main(string[] args)
        {
            int solutionsCount;
            solutionsCount = 0;
            for (int i = 1001; i <= 9999; i += 2)
            {
                if (IsMatch(i))
                {
                    Console.WriteLine("Found a matching address : " + i);
                    solutionsCount++;
                }
            }
            Console.WriteLine("And there are exactly " + solutionsCount + " addresses that match!");
        }

        public static bool IsMatch(int number)
        {
            int temp;
            int thousands;
            int hundreds;
            int tens;
            int ones;

            thousands = number / 1000;
            temp = number % 1000;
            hundreds = temp / 100;
            temp = temp % 100;
            tens = temp / 10;
            ones = temp % 10;

            return (thousands == tens * 3) &&
                (number % 2 != 0) &&
                (thousands + hundreds + tens + ones == 27) &&
                (thousands != hundreds && thousands != tens && thousands != ones) &&
                (hundreds != tens && hundreds != ones) &&
                (tens != ones);
        }
    }
}
