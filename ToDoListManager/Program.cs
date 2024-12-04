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
                        Console.Write("Enter Task description: ");
                        string description = Console.ReadLine();
                        taskManager.AddTask(description);
                        break;
                    case "2": 
                        TaskManager.ViewTasks(); 
                        break;
                    case "3": 
                        Console.Write("Enter task ID to mark as completed: ");
                        if (int.TryParse(Console.ReadLine(), out int markId))
                            taskManager.MarkTaskAsCompleted(markId);
                        else
                            Console.WriteLine("Invalid ID!");
                        break;
                    case "4": 
                        Console.Write("Enter task ID to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int deleteId))
                            taskManager.DeleteTask(deleteId);
                        else
                            Console.WriteLine("Invalid ID!");
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

