using System;

namespace Assignment_1
{
    class Assignment_1
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int sum;
            bool isNumber_A = false;
            bool isNumber_B = false;
            bool isNumber_C = false;

            while (isNumber_A == false)
            {
                try
                {
                    Console.WriteLine(" Please enter Number A : ");
                    a = Convert.ToInt32(Console.ReadLine());
                    isNumber_A = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("The entered value is not a number. Please enter a Number!");
                    isNumber_A = false;
                }

            }
            while (isNumber_B == false)
            {
                try
                {
                    Console.WriteLine(" Please enter Number B : ");
                    b = Convert.ToInt32(Console.ReadLine());
                    isNumber_B = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("The entered value is not a number. Please enter a Number!");
                    isNumber_B = false;
                }

            }
            while (isNumber_C == false)
            {
                try
                {
                    Console.WriteLine(" Please enter Number C : ");
                    c = Convert.ToInt32(Console.ReadLine());
                    isNumber_C = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("The entered value is not a number. Please enter a Number!");
                    isNumber_C = false;
                }
            }

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine(" A ( " + a + " ) is the largest Number");
                }
                else
                {
                    Console.WriteLine(" C ( " + c + " ) is the largest Number");
                }

            }
            else if (b > c) 
            {
                Console.WriteLine(" B ( " + b + " ) is the largest Number");
            }
            else
            {
                Console.WriteLine(" C ( " + c + " ) is the largest Number");
            }
            sum = a + b + c;
            Console.WriteLine("The SUM of the three number is : " + sum);
        }
    }
}
