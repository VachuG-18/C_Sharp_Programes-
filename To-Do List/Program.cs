using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class Program
    {
        static List<string> tasks = new List<string>();


        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==============To_Do_List ================");
                Console.WriteLine("1.Add Task");
                Console.WriteLine("2.View Task");
                Console.WriteLine("3.Remove Task");
                Console.WriteLine("4.Clear all Task");
                Console.WriteLine("5.Exit");
                Console.WriteLine("Select the choices");

                String choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;

                    case "2":
                        ViewTask();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "4":
                        ClearTask();
                        break;
                    case "5":
                        Console.WriteLine("The task exit");
                        break;

                    defalt:
                        Console.WriteLine("Invalid Task");
                }
            }
        }

        static void AddTask()
        {
            Console.WriteLine("Enter your task");
            string task= Console.ReadLine();
            tasks.Add(task);
            Console.WriteLine("Your task Added successfully");
            ViewTask();
        }

        static void ViewTask()
        {
            
            if (tasks.Count == 0)

                Console.WriteLine("No Tasks are available");
            
            else
            {
                
            }
        }
        static void RemoveTask()
        {
            ViewTask();
            if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
            {
                
                    tasks.RemoveAt(index-1);
                    Console.WriteLine("Removed Successfully");
            }
            else
            {
                Console.WriteLine("Someting Went wrong");
            }
        }
        static void ClearTask()
        {
            tasks.Clear();
            Console.WriteLine("Tasks are cleared Successfully");
        }
    }   
}