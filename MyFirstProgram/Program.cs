// See https://aka.ms/new-console-template for more information
using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool restart = true;

            while (restart)
            {
                Console.Write("Would you like to open the calculator? ");
                string answer = Console.ReadLine();


                if (answer.ToLower() == "yes")
                {
                    Console.WriteLine($"Welcome to the Calculator!\nPlease type the first number: ");

                    double num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(num1);
                    Console.WriteLine("Please, type the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("What operation do you want to perform?\n+: Addition.\n-: Substraction\n*: Multiplication.\n/: Division");
                    string operateur = Console.ReadLine();
                    double result;
                    if (operateur == "+")
                    {
                        result = num1 + num2;
                        Console.WriteLine($"The result is {result}");
                    }
                    else if (operateur == "-")
                    {
                        result = num1 - num2;
                        Console.WriteLine($"The result is {result}");
                    }
                    else if (operateur == "/")
                    {
                        result = num1 / num2;
                        Console.WriteLine($"The result is {result}");
                    }
                    else if (operateur == "*")
                    {
                        result = num1 * num2;
                        Console.WriteLine($"The result is {result}");
                    }
                    
                    else
                    {
                        Console.WriteLine("This isn't an operator!");
                    }

                    
                }

                else if (answer.ToLower() == "no")
                {
                    Console.WriteLine("Have a good day!");
                }
                

            }

            
            Console.ReadKey();
        }
            
        }

    
}
 


