using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsoleCalc
{
    class Calculator
    {
        //Used in Subtraction method as a different approach
        int enternumber1;
        int enternumber2;
        int answer;

        //Used in the rest of the project
        string enternumber3;
        string enternumber4;
        int answer1;
        bool IsValid = true;


        public void RunCalculation()
        {
            Console.WriteLine("Please enter the number for the type of calculation would you like to do" + "\n");
            Console.Write("1. Addition \n" + "2. Subtraction \n" + "3. Multiplication \n" + "4. Division \n" + "\n \n" + "Enter number here:" + "\n \n");

            try
            {
                //The input into the console is as text (string), as such need to Parse here to int value.
                int number = int.Parse(Console.ReadLine());
                if (number >= 1 && number <= 4)
                {

                    if (number == 1)
                    {
                        RunAddition();
                        Console.ReadLine();
                    }
                    else if (number == 2)
                    {
                        RunSubtraction();
                        Console.ReadLine();
                    }
                    else if (number == 3)
                    {
                        RunMultiply();
                        Console.ReadLine();
                    }
                    else if (number == 4)
                    {
                        RunDivide();
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Error, Please enter a number between 1 - 4");
                    Console.ReadLine();
                    Console.Clear();
                    RunCalculation();
                }
            }
            catch

            {
                Console.WriteLine("Error, Please enter a number value");
                Console.ReadLine();
                Console.Clear();
                RunCalculation();
            }

        }




        public void RunAddition()
        {
            Console.Write("Please enter a number ... ");

            enternumber3 = Console.ReadLine();

            while (IsValid == true)
            {
                if (int.TryParse(enternumber3, out int number))
                {

                    Console.Write("Please enter a second number ... ");

                    enternumber4 = Console.ReadLine();
                    while (IsValid == true)
                    {
                        if (int.TryParse(enternumber4, out int number2))
                        {
                            answer1 = (number + number2);
                            Console.WriteLine("The answer is " + answer1);
                            Console.ReadLine();
                            Console.Clear();
                            RunCalculation();
                        }
                        else
                        {
                            Console.WriteLine("Not a valid entry \n Please enter a number ...");
                            enternumber4 = Console.ReadLine();

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid entry \n Please enter a number ...");
                    enternumber3 = Console.ReadLine();

                }
            }
        }



        public void RunSubtraction()
        {
            
            try
            {
                Console.Write("Please enter a number ... ");
                enternumber1 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("This entry is not valid! Please Start again ...  \n");
                RunSubtraction();
            }

            try
            {
                Console.Write("Please enter a second number ... ");
                enternumber2 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("This entry is not valid! Please Start again ...  \n");
                RunSubtraction();
            }

            answer = enternumber1 - enternumber2;

            Console.WriteLine("The answer is " + answer);
            Console.ReadLine();
            Console.Clear();
            RunCalculation();

        }



        public void RunMultiply()
        {
            Console.Write("Please enter a number ... ");

            enternumber3 = Console.ReadLine();

            while (IsValid == true)
            {
                if (int.TryParse(enternumber3, out int number))
                {

                    Console.Write("Please enter a second number ... ");

                    enternumber4 = Console.ReadLine();
                    while (IsValid == true)
                    {
                        if (int.TryParse(enternumber4, out int number2))
                        {
                            answer1 = (number * number2);
                            Console.WriteLine("The answer is " + answer1);
                            Console.ReadLine();
                            Console.Clear();
                            RunCalculation();
                        }
                        else
                        {
                            Console.WriteLine("Not a valid entry \n Please enter a number ...");
                            enternumber4 = Console.ReadLine();

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid entry \n Please enter a number ...");
                    enternumber3 = Console.ReadLine();

                }
            }
        }



        public void RunDivide()
        {
            Console.Write("Please enter a number ... ");

            enternumber3 = Console.ReadLine();

            while (IsValid == true)
            {
                if (int.TryParse(enternumber3, out int number))
                {

                    Console.Write("Please enter a second number ... ");

                    enternumber4 = Console.ReadLine();
                    while (IsValid == true)
                    {
                        if (int.TryParse(enternumber4, out int number2))
                        {
                            answer1 = (number / number2);
                            Console.WriteLine("The answer is " + answer1);
                            Console.ReadLine();
                            Console.Clear();
                            RunCalculation();
                        }
                        else
                        {
                            Console.WriteLine("Not a valid entry \n Please enter a number ...");
                            enternumber4 = Console.ReadLine();

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid entry \n Please enter a number ...");
                    enternumber3 = Console.ReadLine();

                }
            }
        }


    }


}





 



