using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNotepad
{
    internal class TaskManager
    {
        private List<_jobs> job = new List<_jobs>();

        public void AddTask(string taskTitle)
        {
            _jobs new_jobs = new _jobs { Title = taskTitle, IsCompleted = false };
            job.Add(new_jobs);
        }

       
        public List<_jobs> GetAllTasks()
        {
            return job;
        }

        public void ClearAllTasks()
        {
            job.Clear();
            Console.WriteLine("All tasks cleared.");
        }
    }
}

