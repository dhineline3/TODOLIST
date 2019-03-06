using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODOWeeklongProject
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            List<String> userList = new List<String>(); //Inititiating a list
            Console.WriteLine("Welcome to your To Do List!");
            Console.WriteLine("Please select an option: ");
            Console.WriteLine("1. Press 1 to add an item to your To Do List.");
            Console.WriteLine("2. Press 2 to view the entire To Do List.");
            Console.WriteLine("3. Press 3 to exit now.");
            //^These are the drop down menu options

            userList.Add(input);
            String inputNewUser = Console.ReadLine();
            userList.Add(inputNewUser);
            foreach (var user in userList)
            {
                Console.WriteLine(userList);
            }
        }
    }
}
