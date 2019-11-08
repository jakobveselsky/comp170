using System;
using System.Collections;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            bool pal = true;
            string input = "";
            ArrayList specialChar = new ArrayList(){ " ", ",", ";", "&", ".", "!", "'", ":", "?" };
            ArrayList noSpecialChar = new ArrayList();
            ArrayList firstHalf = new ArrayList();
            ArrayList secondHalf = new ArrayList();
            ArrayList secondHalfRev = new ArrayList();

            Console.WriteLine("Hello, lets find out if the phrase you enter is a Palindrome!");
            Console.WriteLine("What is your phrase");
            input = Console.ReadLine();

            for(int a = 0; a < input.Length; a++)
            {
                if (!input[a].Equals(specialChar[0]) || !input[a].Equals(specialChar[1]) || !input[a].Equals(specialChar[2]) ||
                    !input[a].Equals(specialChar[3]) || !input[a].Equals(specialChar[4]) || !input[a].Equals(specialChar[5]) ||
                    !input[a].Equals(specialChar[6]) || !input[a].Equals(specialChar[7]))
                {
                    noSpecialChar.Add(input[a]);
                }
            }

            for (int i = 0; i < noSpecialChar.Count; i++)
            {
                if (i < noSpecialChar.Count / 2)
                {
                    firstHalf.Add(noSpecialChar[i]);
                }
                else if (i > noSpecialChar.Count / 2)
                { 
                    secondHalf.Add(noSpecialChar[i]);
                }
            }

            for (int j = secondHalf.Count - 1; j >= 0; j--)
            {
                secondHalfRev.Add(secondHalf[j]);
            }

            pal = isPalindrome(firstHalf, secondHalfRev);

            static bool isPalindrome(ArrayList first, ArrayList second)
            {
                if (second.Count == first.Count)
                {

                    for (int y = 0; y < second.Count; y++)
                    {
                        if (!first[y].Equals(second[y]))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

            if(pal == true)
            {
                Console.WriteLine("it is");
            }
            else Console.WriteLine("it is not");

        }
    }
}
