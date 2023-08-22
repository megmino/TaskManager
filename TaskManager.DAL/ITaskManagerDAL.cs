using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.BLL.Models;
using Task = TaskManager.BLL.Models.Task;

namespace TaskManager.DAL
{
    public interface ITaskManagerDAL
    {
        void AddTask(Task task);
        List<Task> ListTasks();
        Task GetTask(int taskID);
        void RemoveTask(Task task);
    }
}
