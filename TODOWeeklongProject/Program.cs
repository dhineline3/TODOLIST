using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOWeeklongProject
{
    class MainList
    {

        public static void Start()
        {
            List<string> tasks = new List<string>();
            var quit = false;
            do
            {
                
                string input = "";
                Console.WriteLine("Welcome to your To Do List!\n");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. View Entire List");
                Console.WriteLine("3. Quit\n");
                Console.WriteLine("Please choose an option by pressing just the number: \n");
                input = Console.ReadLine();
                if (input == "1")
                {
                    Console.Clear();
                    Console.WriteLine("You have chosen to add a task.");
                    Console.Write("Please enter your task now: ");
                    string newTask = Console.ReadLine();
                    tasks.Add(newTask);


                }


                else if (input == "2")
                {
                    string[] item = new string[25];


                    Console.Clear();
                    Console.WriteLine("You have chosen to view the entire list.");
                    for (int i = 0; i < item.Length; i++)
                    {
                        Console.Clear();
                        Console.WriteLine($"{i + 1}. {tasks}");
                        Console.WriteLine(tasks);

                    }
                    Console.ReadKey();
                }
                else if (input == "3")
                {
                    Console.WriteLine("The application will now close. Thank you.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Input...\n");
                    Console.WriteLine("Goodbye.");
                    Console.ReadKey();
                    quit = true;
                } 
            } while (!quit);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            MainList.Start();
        }

    }
}
