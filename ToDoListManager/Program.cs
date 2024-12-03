using System;
using System.Collections.Generic;

namespace ToDoListManager
{
    class Program
    {
        static List<Task> tasks = new List<Task>();
        static int nextId = 1;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nTo-Do List Manager");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. View Tasks");
                Console.WriteLine("3. Mark Task as Completed");
                Console.WriteLine("4. Delete Task");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1": 
                        AddTask(); 
                        break;
                    case "2": 
                        ViewTasks(); 
                        break;
                    case "3": 
                        MarkTaskAsCompleted(); 
                        break;
                    case "4": 
                        DeleteTask(); 
                        break;
                    case "5": 
                        return;
                    default: 
                        Console.WriteLine("Invalid choice!"); 
                        break;
                }
            }
        }
    }
}

