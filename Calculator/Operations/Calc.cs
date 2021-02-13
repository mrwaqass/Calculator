using System;

namespace Calculator.Operations  //separate namespace(custom)
{
    class Calc   //custom class
    {
        public static void GetInputs() //custom method
        {
            int num1, num2, choice;
            string input;  //this variable is used for taking all the inputs from user
            do
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine("Basic Calculator by Waqas Ayub");
                Console.WriteLine("-------------------------------\n\n");
            operationsSection:
                Console.WriteLine("What Operation do you want to perform?\n");
                Console.WriteLine("[1] => Addition");
                Console.WriteLine("[2] => Subtraction");
                Console.WriteLine("[3] => Multiplication");
                Console.WriteLine("[4] => Division");
                Console.WriteLine("[0] => Exit Program...");
                Console.WriteLine("\nPlease Select number from 0-4 and enter bellow.");
            choiceSection:
                Console.Write("\nChoice: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out choice) == false) //We are checking if string is parsed to integer is false
                {
                    Console.Beep();
                    Console.WriteLine("\nError: Please enter valid choice only from 0-4.");
                    goto choiceSection;
                }
                else
                {
                    if (choice == 0)
                    {
                    confirmSection:
                        Console.Beep();
                        Console.Write("\nAre you sure to want exit? Press (Y) for Yes, (N) for No: ");
                        string confirm = Console.ReadLine().ToUpper();
                        if (confirm == "Y")
                        {
                            System.Environment.Exit(0); //This statement in c# ends the program
                        }
                        else if (confirm == "N")
                        {
                            Console.Beep();
                            Console.Clear();
                            goto operationsSection;
                        }
                        else
                        {
                            Console.Beep();
                            Console.WriteLine("Error: Please enter Y or N for Yes and No respectively.");
                            goto confirmSection;
                        }

                    }
                }
            firstTerm:
                Console.Write("\nEnter first term: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out num1) == false)
                {
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine("\nError: Please enter a natural number.");
                    goto firstTerm;
                }
            secondTerm:
                Console.Write("\nEnter second term: ");
                input = Console.ReadLine();
                if (int.TryParse(input, out num2) == false)
                {
                    Console.Clear();
                    Console.Beep();
                    Console.WriteLine("\nError: Please enter a natural number.");
                    goto secondTerm;
                }
                Calc.Opeartors(choice, num1, num2);
            restartSection:
                Console.Beep();
                Console.WriteLine("Do you want to restart the application? Press (Y) for Yes and (N) for Quit");
                input = Console.ReadLine().ToUpper();
                if (input == "Y")
                {
                    Console.Beep();
                    Console.Clear();
                    goto operationsSection;
                }
                else if (input == "N")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\nError: Please choose from Y and N (Yes and Quit respectively)\n");
                    goto restartSection;
                }

            }
            while (choice != 0);
        }

        public static void Opeartors(int choice, int x, int y)
        {
            ConsoleColor green = ConsoleColor.DarkGreen; //Assigning Green color to custom variable green, if you dont understand it, just ignore..
            Console.WriteLine("\n\n----------\nResults\n----------\n");
            if (choice == 1)
            {
                Console.WriteLine("Addition of {0} and {1} = {2} \n\n", x, y, (x + y), Console.BackgroundColor = green);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Subtraction from {0} to {1} = {2} \n\n", x, y, (x - y), Console.BackgroundColor = green);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Multiplication of {0} and {1} = {2} \n\n", x, y, (x * y), Console.BackgroundColor = green);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Division of {0} by {1} = {2} \n\n", x, y, (x / y), Console.BackgroundColor = green);
            }
            else
            {
                Console.WriteLine("Error: Please enter your choice from 1-4 \n\n");
            }
            Console.ResetColor(); //Reseting the above green color to default, it is highly suggested to do.

        }
    }
}