using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nested_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.addition");
            Console.WriteLine("2.subtraction");
            Console.WriteLine("3.multiplication");

            int input = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter first number");
            int num1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter second number");
            int num2 = Convert.ToInt16(Console.ReadLine());

            switch (input)
            {
                   
                case 1:
            int sum=num1 + num2;
            Console.WriteLine(sum);
            Console.WriteLine("do you want to perform another funtion?" +"yes"+ "/" + "No");

            string ans = Console.ReadLine();
            if (ans=="yes")
            {
                Console.WriteLine("1.addition");
                Console.WriteLine("1.subtraction");
                Console.WriteLine("1.multiplication");
               
                Console.WriteLine("select function");
                 int input2 = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("enter 3rd number which will operate with previous sum");
                 int num3 = Convert.ToInt16(Console.ReadLine());

                 switch (num3)
                 {
                     case 2:
                         int sum2 = sum + num3;
                         Console.WriteLine("sum of previous sum and third number is " + sum2);
                         break;
                 }
            }
            break;
              


          
                    
            }
        }
    }
}
