using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsoleCalc
{
    class Program
    {

        static void Main(string[] args)
        {
            Introduction();
            Calculator calculator = new Calculator();
            calculator.RunCalculation();
           
        }



        public static void Introduction()
        {
            Console.Title = "Calculator";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to my version of a console calculator");
            Console.ReadLine();
        }


    }
}
