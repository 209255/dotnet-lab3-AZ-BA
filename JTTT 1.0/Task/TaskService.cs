using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using JTTT_1._0.Database;

namespace JTTT_1._0
{
    class TaskService
    {
        private readonly string _serialize;

        public TaskService()
        {
            Tasks = new BindingList<Task>();
            _serialize = "serialize.txt";
        }

        public BindingList<Task> Tasks { get; }

        public void AddTaskToDb(Task t)
        {
            using (var ctx = new TaskServiceDbContext())
            {
                ctx.Tasks.Add(t);
                AddTask(t);
                ctx.SaveChanges();
            }
        }

        public void ClearTaskFromDb(Task t)
        {
            using (var ctx = new TaskServiceDbContext())
            {
                if (!ctx.Tasks.Any()) return;
                var taskToRm = ctx.Tasks.First(x => x.Id == t.Id);
                ctx.Tasks.Remove(taskToRm);
                ctx.SaveChanges();
            }
        }

        public void ClearAllTaskFromDb()
        {
            using (var ctx = new TaskServiceDbContext())
            {
                if (!ctx.Tasks.Any()) return;
                ctx.Tasks.RemoveRange(ctx.Tasks);
                ctx.SaveChanges();
                ClearAll();
            }
        }

        public void LoadTasks()
        {
            using (var ctx = new TaskServiceDbContext())
            {
                if (!ctx.Tasks.Any()) return;
                foreach (var task in ctx.Tasks)
                {
                   AddTask(new Task(task.Action, task.Reaction, task.ActionModel, task.ReactionModel, task.Name));
                }
            }
        }
        private void AddTask(Task t)
        {
            Tasks.Add(t);
        }

        public void ExecuteAll()
        {
            foreach (var t in Tasks)
            {
                t.Execute();
            }
            ClearAllTaskFromDb();
        }

        private void ClearAll()
        {
            Tasks.Clear();
            ClearAllTaskFromDb();
        }

        public void Serialize()
        {
            if (!Tasks.GetType().IsSerializable) return;
            try
            {
                using (var stream = new FileStream(_serialize,FileMode.Create))
                {
                    new BinaryFormatter().Serialize(stream, Tasks);
                }
            }
            catch (SerializationException e)
            {
                Console.WriteLine(@"Failed to serialization: " + e.Message);
            }
        }

        public void Deserialize()
        {
            Tasks.Clear();
            try
            {
                if (!File.Exists(_serialize)) return;
                BindingList<Task> temp;
                using (var str = new FileStream(_serialize,FileMode.Open))
                {
                    temp = (BindingList<Task>) new BinaryFormatter().Deserialize(str);
                }
                foreach (var t in temp)
                {
                    Tasks.Add(t);
                }
            }
            catch (SerializationException e)
            {
                Console.WriteLine(@"failed to deserializaton: " + e.Message);
            }
        }
    }
}