using System;
using System.Collections;
using System.Collections.Generic;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            List<string> theList = new List<string>();

            while (true)
            {

                Console.WriteLine("Enter the Name to add it to the list: ");
                string input = Console.ReadLine();

                char nav = input[0];
                string value = input.Substring(1);
                switch (nav)
                {
                    case '0':
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("*************Thank you for using our service. Welcome back later!. *************");
                            Console.ResetColor();
                            Environment.Exit(1);
                            break;
                        }
                    case '+':
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            theList.Add(value);
                            Console.WriteLine($"The Name: {value} has been added to the List.");
                            Console.ResetColor();
                            break;
                        }
                    case '-':
                        {
                            theList.Remove(value);
                            CheckifValue();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong input. Please, re-consider your input again! ");
                            break;
                        }

                }
                foreach (var item in theList)
                {
                    Console.WriteLine($"The list contains: {item}");
                }

                void CheckifValue()
                {
                    var match = theList.FirstOrDefault(stringToCheck => stringToCheck.Contains(value));
                    if (value == match)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"The Name: {value} has been removed from the List. ");
                        Console.ResetColor();
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{value} has been Removed");
                        Console.ResetColor();

                }



            }

    }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue<string> queue = new Queue<string>();

            bool done = false;
            while (!done)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("The shop opens & the queue to the desk is empty");
                Console.WriteLine("Press exit to quit.\n Press queue to put a person on the queue. \n Press dequeue for dequeue. \n ");
                Console.WriteLine("Press return to return to main menu ");
                Console.ResetColor();
                

                string input = Console.ReadLine();
                switch (input)
                {
                    case "exit":
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("*************Thank you for using our service. Welcome back later!. *************");
                        Console.ResetColor(
                            );
                        Environment.Exit(1);
                        break;
                    case "queue":
                        TestQueue();
                        WaitForUser();
                        break;
                    case "dequeue":
                        TestDequeue();
                        WaitForUser();
                        break;
                    case "return":
                        return;
                    default:
                        break;


                }
                foreach (var name in queue)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"This name: {name} is standing in the queue");
                    Console.ResetColor();
                }

                void TestQueue()
                {
                    string value;
                    value = Console.ReadLine();
                    queue.Enqueue(value);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{value} stands currently in line. ");
                    Console.ResetColor();
                    Sleep();
                }
                void TestDequeue()
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"{queue.Dequeue()} has left the line");
                        Console.ResetColor();
                        Sleep();
                    }
                    catch
                    {
                        Console.WriteLine("Nothing to dequeue, please try again. ");
                    }


                }

                void Sleep()
                {
                    Thread.Sleep(1000);
                }

                void WaitForUser()
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Click any button to continnue. ");
                    Console.ReadLine();
                    Console.Clear();
                }

            }

        }




        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            Stack stack = new Stack();

        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

