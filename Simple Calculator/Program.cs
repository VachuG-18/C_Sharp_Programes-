using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator Using C#");
            Console.WriteLine("Emter the 1st Number:");
            double num1=double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the character like (+,-,*,/)");
            char opp = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter the 2nd Number:");
            double num2 = double.Parse(Console.ReadLine());

            double result = 0;

            switch (opp)
            {
                case '+':
                    result = num1 + num2;
                    break;

                case '-':
                    result = num1 - num2;
                    break;

                case '*':
                    result = num1 * num2;
                    break;

                case '/':
                    if (num2 != 0) 
                    
                        result = num1 / num2; 
                    else
                    
                        Console.WriteLine("zero Division Error!");
                    break;

                default:
                    Console.WriteLine("The invalid Output");
                    return;

            }
            Console.WriteLine($"{num1}{opp}{num2}= {result}");


        }
    }
}
