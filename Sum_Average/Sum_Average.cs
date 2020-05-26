using System;

namespace Sum_Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Please enter your number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number");

            num2 = Convert.ToInt32(Console.ReadLine());

            //sum
            int num_sum = num1 + num2;
            Console.WriteLine("The sum of your numbers is {0}", num_sum);

            int num_ave = (num1 + num2) / 2;
            Console.WriteLine("The average of your numbers is {0}", num_ave);

            Console.ReadLine();




        }
    }
}
