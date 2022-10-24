using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            //PrintOneThousand();

            //Three();

            //Console.WriteLine(Equals(5, 5));

            //EvenAndOdds();

            //PostiveOrNegative();

            //OldEnoughToVote();

            //int x;
            //Console.Write("Enter number here ");
            //x = int.Parse(Console.ReadLine());
            //bool IsInRange = IsIntegerInRange(x);
            //Console.WriteLine($"{x} is in range = {IsInRange}");

            PrintTable();
        }

        // Write a method that will print to the console all numbers 1000 through -1000

        public static void PrintOneThousand()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        // Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void Three()
        {
            for (int a = 3; a <= 999; a += 3)
                Console.WriteLine(a);
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static bool Equals(int m, int n)
        {
            if (m == n) return true;

            else return false;
        }

        //Write a method to check whether a given number is even or odd

        public static void EvenAndOdds()
        {
            int x;
            Console.Write("Enter number here ");
            x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Number is even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void PostiveOrNegative()
        {
            int y;
            Console.Write("Enter number here ");
            y = int.Parse(Console.ReadLine());
            if (y <= 0)
            {
                Console.WriteLine("Number is negative");
            }
            else if (y >= 0)
            {
                Console.WriteLine("Number is positive");
            }
            else
            {
                Console.WriteLine("0");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void OldEnoughToVote()
        {
            int x;
            Console.Write("Enter your age ");
            x = int.Parse(Console.ReadLine());
            if (x >=18)
            {
                Console.WriteLine("Go vote!");
            }
            else
            {
                Console.WriteLine("Too young come back next year");
            }
        }

        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool IsIntegerInRange(int x)
        {

            if (x > 10)
                return false;
            if (x < -10)
                return false;

            return true;
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void PrintTable()
        {
            int x;
            Console.Write("Enter a number ");
            x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{i} * {x} = {i*x}");
            }



        }



    }
}
