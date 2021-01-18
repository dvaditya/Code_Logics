using System;
using System.Collections.Generic;
using System.Text;

namespace Logics
{
    public static class Start
    {
        public static void Main()
        {
            MoveZeroesToCenter();
            CountIslands();
            Int2Word();

            Console.ReadKey();
        }

        public static void MoveZeroesToCenter()
        {
            var input = new int[] { 0, 0, 0, 1, 2, 3 };
            var result = new MoveZeroesToMiddle().moveZeroesToMiddle(input);

            Console.WriteLine("Zeroes Moved to center: [{0}]", string.Join(",", result));
        }

        public static void CountIslands()
        {
            char[][] table = new char[][] {
                new char[] { '1', '1', '1'},
                new char[] { '1', '1', '1' },
                new char[] { '1', '1', '1' }
            };

            Console.WriteLine("Number of islands: " + new CountIslands().NumIslands(table));
        }

        public static void Int2Word()
        {
            Console.WriteLine("Enter a number to convert: ");
            string number = Console.ReadLine();
            number = Convert.ToDouble(number).ToString();

            if (number == "0")
            {
                Console.WriteLine("The number is Zero");
            }
            else
            {
                Console.WriteLine($"The Number is: {new Int2Word().ConvertToWord(number)}");
            }
        }
    }
}
