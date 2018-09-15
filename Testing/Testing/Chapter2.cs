using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapters
{
    static class Chapter3
    {
        /* 1. Write an expression that checks whether an integer is odd or even */
        public static void pratice1()
        {
            Int32 inputNumber = 0;
            Console.Write("Please input a number for practice 1: ");
            inputNumber = Int32.Parse(Console.ReadLine());
            
            if ((inputNumber % 2) == 0)
            {
                Console.WriteLine("Number " + inputNumber + " is even number");
            }
            else
            {
                Console.WriteLine("Number " + inputNumber + " is odd number");
            }
        }

        /* 2. Write a Boolean expression that checks whether a given integer is
           divisible by both 5 and 7, without a remainder. */
        public static void pratice2()
        {
        }

        /* 3. Write an expression that looks for a given integer if its third digit (right to left) is 7.*/
        public static void pratice3()
        {
            string inputNumber;
            Console.Write("Please input a number for practice 3: ");
            inputNumber = Console.ReadLine();
            if ('7' == inputNumber[inputNumber.Length - 3])
            {
                Console.WriteLine("Number " + inputNumber + " has 7 number at third digit (right to left)");
            }
            else
            {
                Console.WriteLine("Number " + inputNumber + " do not have 7 number at third digit (right to left)");
            }
        }

        /*4. Write an expression that checks whether the third bit in a given integer is 1 or 0.*/
        public static void pratice4()
        {
            Int32 inputNumber;
            Console.Write("Please input a number for practice 4: ");
            inputNumber = Int32.Parse(Console.ReadLine());
            if (((inputNumber >> 2) & 0x01) != 0)
            {
                Console.WriteLine("The third bit of input number {0} is 1 ", inputNumber);
            }
            else
            {
                Console.WriteLine("The third bit of input number {0} is 0 ", inputNumber);
            }

        }
    }
}
