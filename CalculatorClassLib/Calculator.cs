using System;
namespace CalculatorClassLib
{
    public class Calculator
    {
        ///<summary>
        /// This is a Calculator Method class
        ///</summary>
        
        public int Add( int num1, int num2)
        {
            return num1 + num2;
        }
        public int Division( int num1, int num2)
        {  
           try
           {
               return num1 / num2;
                
           }
           catch (DivideByZeroException ex)
           {
               System.Console.WriteLine( ex.Message);
               return 0;
           }
        }
        public int Multiply(int num1, int num2) 
        { 
            return num1 * num2;
        }
        public int Subtract( int num1, int num2) 
        { 
            return num1 - num2;
        }
        public int Square(int num) 
        { 
            return num * num;
        }
    }
}