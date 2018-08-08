﻿using System;

namespace SimpleCalc2
{
    class Program
    {
        static void Main(string[] args)

        {
            //introduces program to user and asks for first number.
            Console.WriteLine("Let's perform a simple calculation between two numbers. ");
            Console.Write("Please enter the first number: ");

            //turn first number into double 
            string firstNumber = Console.ReadLine();
            double first = double.Parse(firstNumber);

            //ask for second number and turn it into double
            Console.Write("Please enter the second number: ");
            string secondNumber = Console.ReadLine();
            double second = double.Parse(secondNumber);
            string zero = (second == 0) ? "):" : ", divide):";

            //asks user for calculation method

            Console.Write($"Please enter an operation (add, subtract, multiply{zero} ");
            string operation = Console.ReadLine();
            double answer = 0;
                
              
                //operation possibilites
                if (operation == "add")
                {
                    answer = Add(first, second);
                }

                else if (operation == "subtract")
                {
                    answer = Subtract(first, second);
                }

                else if (operation == "multiply")
                {
                    answer = Multiply(first, second);
                }

                else if (operation == "divide")
                {
                    if (second != 0)
                    {
                        answer = Divide(first, second);
                    }

                }
       
                else
                {
                    Console.WriteLine($"Sorry, there was a problem.");
                }


                //allows user to see the answer
                Console.WriteLine($"The answer is: {answer}");
                Console.ReadLine();

            }

      
            /// <summary>
            /// This method adds two doubles.
            /// </summary>
            /// <param name="first">The first user input double.</param>
            /// <param name="second">The second user input double.</param>
            /// <returns>A double that is the solution of the addition equation.</returns>
            private static double Add(double first, double second)
            {
                double solution = first + second;
                Console.WriteLine($"{first} + {second} = {solution}");
                return solution;
            }

             /// <summary>
             /// This method subtracts the second double from the first. 
             /// </summary>
             /// <param name="first">The first user input double.</param>
             /// <param name="second">The second user input double.</param>
             /// <returns>The soltuion of the subtraction of second double from first.</returns>
            private static double Subtract(double first, double second)
            {
                double solution = first - second;
                Console.WriteLine($"{first} - {second} = {solution}");
                return solution;
            }

            /// <summary>
            /// This method multiplies two doubles. 
            /// </summary>
            /// <param name="first">The first user input double.</param>
            /// <param name="second">The second user input double.</param>
            /// <returns>A double that is the soltuion of the multiplication equation.</returns>
            private static double Multiply(double first, double second)
            {
                double solution = first * second;
                Console.WriteLine($"{first} x {second} = {solution}");
                return solution;
            }

            /// <summary>
            /// This method divides the first double by the second. 
            /// </summary>
            /// <param name="first">The first user input double.</param>
            /// <param name="second">The second user input double.</param>
            /// <returns>A double that is the solution of the division equation.</returns>
            private static double Divide(double first, double second)
            {
                double solution = first / second;
                Console.WriteLine($"{first} / {second} = {solution}");
                return solution;
            }

        }
    }

    

