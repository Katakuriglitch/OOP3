using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b) => a / b;
        public double SquareRoot(double a) => Math.Sqrt(a);
        public double Power(double a, double b) => Math.Pow(a, b);
        public double Sine(double a) => Math.Sin(a);
        public double Cosine(double a) => Math.Cos(a);
        public double Tangent(double a) => Math.Tan(a);
    }

    public class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("     Welcome to the Math Maze!     ");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\nYou find yourself at the entrance of a mysterious maze. To escape, you must solve the mathematical riddles that guard each path.");

            while (true)
            {
                Console.WriteLine("\nWhat path will you take? (add, subtract, multiply, divide, sqrt, power, sine, cosine, tangent) or enter 'exit' to give up:");
                string operation = Console.ReadLine().ToLower();

                if (operation == "exit")
                {
                    Console.WriteLine("You turn back, defeated by the maze's riddles. Perhaps another time.");
                    break;
                }

                double result = 0;

                if (operation == "sqrt")
                {
                    Console.WriteLine("A shadowy figure whispers: 'What is the root of this number?'");
                    Console.WriteLine("Enter the number:");
                    double number = Convert.ToDouble(Console.ReadLine());
                    result = calculator.SquareRoot(number);
                }
                else if (operation == "sine" || operation == "cosine" || operation == "tangent")
                {
                    Console.WriteLine("A voice echoes: 'Find the trigonometric value of this angle.'");
                    Console.WriteLine("Enter the angle in radians:");
                    double angle = Convert.ToDouble(Console.ReadLine());
                    result = operation == "sine" ? calculator.Sine(angle) : operation == "cosine" ? calculator.Cosine(angle) : calculator.Tangent(angle);
                }
                else
                {
                    Console.WriteLine("Two paths converge before you. Choose your numbers wisely.");
                    Console.WriteLine("Enter the first number:");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number:");
                    double b = Convert.ToDouble(Console.ReadLine());

                    switch (operation)
                    {
                        case "add":
                            result = calculator.Add(a, b);
                            break;
                        case "subtract":
                            result = calculator.Subtract(a, b);
                            break;
                        case "multiply":
                            result = calculator.Multiply(a, b);
                            break;
                        case "divide":
                            result = calculator.Divide(a, b);
                            break;
                        case "power":
                            result = calculator.Power(a, b);
                            break;
                        default:
                            Console.WriteLine("The paths blur and disappear. You've lost your way.");
                            continue;
                    }
                }

                Console.WriteLine($"\nYou solve the riddle! The answer is: {result}");
                Console.WriteLine("The path ahead seems clearer... for now.");
            }
        }
    }
}