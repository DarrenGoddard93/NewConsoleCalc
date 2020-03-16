using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewConsoleCalc
{
    class Calculator
    {
        int number1;
        int number2;
        int answer;

        int optionNumber;


        public void RunCalculator()
        {
            AskCalculation();
            ValidateType();
            FirstNumberInput();
            SecondNumberInput();
            AnswerOutput();
            RestartApplication();

        }

        public void AskCalculation()
        {
            Console.WriteLine("Please enter the number for the calculation you want to do ...");
            Console.Write("1. Addition \n" + "2. Subtraction \n" + "3. Multiplication \n" + "4. Division \n" + "\n \n" + "Enter number here:" + "\n \n");

        }


        public int GetInput()
        {
            while (int.TryParse(Console.ReadLine(), out int num))
            {
                return num;
            }
            {
                Console.WriteLine("Not a valid entry \n Please enter a number ...");

            }
            return GetInput();
        }


        public int ValidateType()
        {
            bool IsValid = Int32.TryParse(Console.ReadLine(), out optionNumber);
            {
                while (!IsValid)
                {
                    Console.WriteLine("Invalid Entry, please enter a number ...");
                    IsValid = Int32.TryParse(Console.ReadLine(), out optionNumber);
                }

                if (optionNumber >= 1 && optionNumber <= 4)
                {
                    return optionNumber;
                }
                else
                {
                    Console.WriteLine("Please enter a number between 1 and 4 ...");
                    ValidateType();
                }
            }
            return optionNumber;
        }


        public int Calculate()
        {
            int result;

            if (optionNumber == 1)
            {
                result = AddResult();
                return result;

            }
            else if (optionNumber == 2)
            {
                result = SubtractResult();
                return result;
            }
            else if (optionNumber == 3)
            {
                result = MultiplyResult();
                return result;
            }
            else if (optionNumber == 4) ;
            {
                result = DivideResult();
                return result;
            }


        }



        public int AddResult()
        {
            answer = number1 + number2;
            return answer;

        }


        public int SubtractResult()
        {
            answer = number1 - number2;
            return answer;

        }


        public int MultiplyResult()
        {
            answer = number1 * number2;
            return answer;

        }


        public int DivideResult()
        {
            answer = number1 / number2;
            return answer;

        }



        public void FirstNumberInput()
        {
            Console.WriteLine("Enter first number ...");
            number1 = GetInput();

        }


        public void SecondNumberInput()
        {
            Console.WriteLine("Enter second number ...");
            number2 = GetInput();

        }


        public void AnswerOutput()
        {
            answer = Calculate();

            Console.WriteLine("The answer is " + answer);
            Console.Beep();
            Console.ReadLine();

        }

        public void RestartApplication()
        {
            string Restart;
            
            {
                Console.WriteLine("To restart calculator press 'y' OR press 'n' to exit");

                Restart = Console.ReadLine().ToLower();

                if (!Restart.Equals("y") && !Restart.Equals("n"))
                {
                    Console.WriteLine("Invalid!");
                    RestartApplication();

                }
                else if (Restart.Equals("y"))
                {
                    Console.Clear();
                    RunCalculator();
                }
                else Restart.Equals("n");
                {
                    Environment.Exit(0);
                }

            }

        }    
    }
}

    






 



