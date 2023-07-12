using System;

namespace AreaComparison
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Area Comparison problem statement");
            Operation operation1 = new Operation(10, 5);
            double area1 = operation1.CalculateArea();
            Operation operation2 = new Operation(100, 50);
            double area2 = operation2.CalculateArea();
            if (area1.Equals(area2))
                Console.WriteLine("Area1 and Area2 are equal");
            else
                Console.WriteLine("Area1 and Area2 are not equal");
        }
    }
}