using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListManager
{
    internal class Task
    {
        public int Id { get; set; } // Unique task ID
        public string Description { get; set; } // Task description
        public bool IsCompleted { get; set; } // Task completion status

        public Task(int id, string description)
        {
            Id = id;
            Description = description;
            IsCompleted = false; // Default to incomplete
        }

        public override string ToString()
        {
            return $"[{(IsCompleted ? "X" : " ")}] {Id}: {Description}";
        }
    }
}
