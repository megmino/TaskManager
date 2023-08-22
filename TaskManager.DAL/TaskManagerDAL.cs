using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.BLL.Models;
using Task = TaskManager.BLL.Models.Task;

namespace TaskManager.DAL
{
    public class TaskManagerDAL : ITaskManagerDAL
    {
        public void AddTask(Task task)
        {

        }
        public List<Task> ListTasks()
        {
            return new List<Task>();
        }
        public Task GetTask(int taskID)
        {
            return new Task();
        }
        public void RemoveTask(Task task)
        {

        }
    }
}