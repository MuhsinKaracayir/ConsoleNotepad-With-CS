using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNotepad
{
    internal class Program
    {

        static void Main(string[] args)
        {
           
            TaskManager manager = new TaskManager();

            while (true)
            {

                Console.WriteLine("=== OOP TODO APP ===");
                Console.WriteLine("1) New Task");
                Console.WriteLine("2) All Tasks");
                Console.WriteLine("3) Quit");
                Console.Write("Choose: ");

                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        Console.Write("Task description: ");
                        string input = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(input))
                        {
                            manager.AddTask(input);
                            Console.WriteLine("Task Added!");
                        }
                        break;

                    case "2":
                        Console.WriteLine("\n--- Tasks ---");

                        var myTasks = manager.GetAllTasks();

                        if (myTasks.Count == 0)
                        {
                            Console.WriteLine("No tasks.");
                        }
                        else
                        {
                            int counter = 1;
                            foreach (var item in myTasks)
                            {
                                Console.WriteLine($"{counter}. {item.Title}");
                                counter++;
                            }
                        }
                        break;

                    case "3":
                        return;



                    default:
                        Console.WriteLine("Wrong input. Please try again !!!");
                        break;
                }
            }
        }
    }
}
