using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Create a method takes an integer and outputs it in the following format withing using String.Format 
            //  10000000 = 10,000,000
            //  Shows type conversion between collections.
            StringBuilder result = new StringBuilder();

            int num = 10000000;
            var reversed = Reverse(num.ToString());

            int cnt = 0;

            foreach(char val in reversed)
            {
                if (cnt < 3)
                {
                    cnt++;
                }
                else
                {
                    result.Append(',');
                    cnt = 1;
                }
                result.Append(val);
            }

            string straight = Reverse(result.ToString());
            Console.WriteLine(straight);
            Console.ReadLine();
        }

        public static string Reverse(string input)
        {
            StringBuilder result = new StringBuilder();

            char[] straight = input.ToCharArray();
            ArrayList reverser = new ArrayList(straight);
            reverser.Reverse();

            foreach(var item in reverser)
            {
                result.Append(item);
            }

            return result.ToString();
        }
    }
}
