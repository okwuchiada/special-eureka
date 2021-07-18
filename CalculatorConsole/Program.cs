using System;
using System.Collections.Generic;
using CalculatorClassLib;

 
namespace CalculatorConsole
{
    class Program
    {
      public static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            List<int> calc = new List<int>();
            
            // Getting Values From Users
           Console.WriteLine("Enter a number");
           int num1 = Convert.ToInt32(Console.ReadLine());
           Console.WriteLine("Enter another number");
           int num2 = Convert.ToInt32(Console.ReadLine());
          
          // Setting Calculator Variables
          int sum = calculator.Add(num1, num2);
          int subtract = calculator.Subtract(num1, num2);
          int multiply = calculator.Multiply(num1, num2);
          int divide = calculator.Division(num1, num2);
          int square = calculator.Square(num1);

          // Adding Results to List
          calc.Insert(0, sum);
          calc.Insert(0, subtract);
          calc.Insert(0, multiply);
          calc.Insert(0, divide);
          calc.Insert(0, square);
        }


    }
}
