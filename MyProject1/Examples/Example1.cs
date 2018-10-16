using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject1.Examples
{
    class Example1
    {
        static void Main()
        {
            Console.Write("Enter your First Number ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter your Second Number ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.Write("You Entered {0} and {1} Sum of num1 and num2 = {2} ", num1,num2,sum);
            Console.Write("", sum);
            Console.ReadKey();
        }
    }
}
