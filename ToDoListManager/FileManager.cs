using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace ToDoListManager
{
    internal class FileManager
    {
        private readonly string filePath;

        public FileManager(string filePath)
        {
            this.filePath = filePath;
        }

        public void SaveTasksToFile(List<Task> tasks)
        {
            try
            {
                string json = JsonSerializer.Serialize(tasks);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving tasks: {ex.Message}");
            }
        }

        public List<Task> LoadTasksFromFile()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    string json = File.ReadAllText(filePath);
                    return JsonSerializer.Deserialize<List<Task>>(json) ?? new List<Task>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading tasks: {ex.Message}");
            }

            return new List<Task>();
        }
    }
}
