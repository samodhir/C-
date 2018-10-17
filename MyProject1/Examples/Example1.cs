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
            /*
            Console.Write("Enter your First Number ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter your Second Number ");
            int num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;

            Console.Write("You Entered {0} and {1} Sum of num1 and num2 = {2} ", num1,num2,sum);
            Console.Write("", sum);
            Console.ReadKey();
            */

            /*
            bool x = false;
            Console.Write(x);
            Console.ReadKey();
            */
            int num1, num2;
            int add, sub, mul;
            float div;

            Console.Write("Insert Number one\t");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert Number two\t");
            num2 = Convert.ToInt32(Console.ReadLine());

            add = num1 + num2;
            sub = num1 - num2;
            mul = num1 * num2;
            div = (float)num1 / num2;
            int mod = num1 % num2;
            if (num1 > num2)
            {
                Console.Write("num 1 is the maximum number \n");
            }
            if(num1<num2){
                Console.Write("num 1 is the minimum number \n");
            }
            else
            {
                Console.Write("num 1 and num 2 are equal");
            }

            Console.Write("\n{0}",add);
            Console.Write("\n{0}",sub);
            Console.Write("\n{0}",mul);
            Console.Write("\n{0}",div);
            Console.Write("\n{0}",mod);

            Console.ReadKey();
            \\this is acomment from github

        }
    }
}
