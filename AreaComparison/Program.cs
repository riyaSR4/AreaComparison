using System;

namespace AreaComparison
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Area Comparison problem statement");
            Operation operation = new Operation(10, 5);
            operation.CalculateArea();
            //Operation operation2 = new Operation(100, 50);
            //double line2 = operation2.CalculateArea();

        }
    }
}