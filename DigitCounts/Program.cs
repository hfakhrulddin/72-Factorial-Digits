using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCounts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the No's which you want to know thier Factorial and Number of digits use , between Numbers");
            string Str = Console.ReadLine();
            String[] args2 = Str.Split(',');

            if (args2.Length == 0)
            {
                Console.WriteLine("You entered Nothing ... ");
                return;
            }

            for (int i = 0; i < args2.Length; i++)
            {
                int num = Int32.Parse(args2[i]);

                Console.WriteLine("The Digit Count for String [{0}] is [{1}]",args2[i], DigitCount.NumberOfDigits(args2[i]));
                Console.WriteLine("The Factorial for [{0}] is [{1}]",num, Factorial.Calc(num));
            }
            Console.ReadLine();
        }

        public class DigitCount
        {
            public static int NumberOfDigits(string theString)
            {
                int count = 0;
                for (int i = 0; i < theString.Length; i++)
                {
                    if (Char.IsDigit(theString[i]))
                    {
                        count++;
                    }
                }
                return count;
            }
        }

        public class Factorial
        {
            public static int Calc(int i)
            {
                return ((i <= 1) ? 1 : (i * Calc(i - 1)));
            }
        }
    }
}
