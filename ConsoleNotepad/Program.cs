using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNotepad
{
    internal class Program
    {

        class Jobs
        {
            public String Task { get; set; }
            public bool Did { get; set; }
        }
        static void Main(string[] args)
        {

            List<Jobs> TaskList = new List<Jobs>();


            while (true)
            {
                Console.WriteLine("What are we doing?");
                Console.WriteLine("1) New Task");
                Console.WriteLine("2) All Tasks");
                Console.WriteLine("3) Quit");

                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        Console.WriteLine("Add the new task");

                        var newTask = Console.ReadLine();

                        TaskList.Add(new Jobs { Task = newTask, Did = false });
                        Console.WriteLine("Task Added");
                        break;

                    case "2":
                        Console.WriteLine("All Tasks");
                        if (TaskList.Count == 0)
                        {
                            Console.WriteLine("We are free");
                        }

                        else
                        {
                            int counter = 1;
                            foreach (var task in TaskList)
                            {
                                Console.WriteLine($"{counter}.{task.Task}");
                                counter++;
                            }
                        }
                        break;

                    case "3":


                        Console.WriteLine("Bye Bye");

                        return;


                    default:
                        Console.WriteLine("Wrong input. Please try again !!!");
                        break;

                }
            }
        }
    }
}
