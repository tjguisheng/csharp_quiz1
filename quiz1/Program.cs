using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1
            Console.WriteLine("Please input first integer number: ");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Please input second integer number: ");
            int num2 = Int32.Parse(Console.ReadLine());

            Task1(num1, num2);

            //Task2
            Console.WriteLine("Please input an integer: ");
            int num3 = Int32.Parse(Console.ReadLine());
            Task2(num3);

            //Task3
            Task3();

            //Task4
            Console.Write("Input the number of terms: ");
            int num4 = Int32.Parse(Console.ReadLine());
            Task4(num4);
        }
        
        //method for Task1
        public static void Task1(int num1, int num2) 
        {
            if (num1 == 30 || num2 == 30 || num1 + num2 == 30)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }

        //method for Task2
        public static void Task2(int num)
        {
            Console.WriteLine($"Number is: {num} and power of the {num} is: {num * num}");
        }

        //method for Task3
        public static void Task3()
        {
            for (int row = 1; row <= 4; row++) 
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col);
                }
                Console.Write("\n");
            }
        }

        //method for Task4
        public static void Task4(int num)
        {
            double sum=0d;

            for (int i = 1; i <= num; i++)
            {
                Console.Write($" 1/{i} + ");
                sum += 1.0d / i;
            }
            Console.WriteLine($"\n Sum of Series up to {num} terms: {sum}");
        }
    }
}
