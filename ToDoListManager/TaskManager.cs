using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListManager
{
    internal class TaskManager
    {
        private List<Task> tasks;
        private int nextId;
        private FileManager fileManager;

        public TaskManager(string filePath)
        {
            fileManager = new FileManager(filePath);
            tasks = fileManager.LoadTasksFromFile();
            nextId = tasks.Count > 0 ? tasks[^1].Id + 1 : 1; // Update ID for new tasks
        }

        public void AddTask(string description)
        {
            Task newTask = new Task(nextId++, description);
            tasks.Add(newTask);
            fileManager.SaveTasksToFile(tasks);
            Console.WriteLine("Task added succefully!");
        }

        public void viewTasks()
        {
            Console.WriteLine("\nYour Tasks:");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks available!");
                return;
            }

            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
        }

        public void MarkTaskCompleted(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
                fileManager.SaveTasksToFile(tasks);
                Console.WriteLine("Task marked as completed!");
            }
            else
            {
                Console.WriteLine("Task not found!");
            }
        }

        public void DeleteTask(int id)
        {
            var task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
                fileManager.SaveTasksToFile(tasks);
                Console.WriteLine("Task deleted succesfully!");
            }
            else
            {
                Console.WriteLine("Task not found!");
            }
        }
    }
}

