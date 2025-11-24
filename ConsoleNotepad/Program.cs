using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNotepad
{
    internal class Program
    {

        class Job
        {
            public String Task { get; set; }
            public bool Did { get; set; }
        }
        static void Main(string[] args)
        {

            List<Job> TaskList = new List<Job>();


            while (true)
            {
                Console.WriteLine("TO DO LIST");
                Console.WriteLine("1) New Task");
                Console.WriteLine("2) All Tasks");
                Console.WriteLine("3) Quit");
                Console.WriteLine("Choose Action");
                string choose = Console.ReadLine();

                switch (choose)
                {
                    case "1":
                        Console.WriteLine("Add a new task");

                        var newTask = Console.ReadLine();

                        TaskList.Add(new Job { Task = newTask, Did = false });
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
