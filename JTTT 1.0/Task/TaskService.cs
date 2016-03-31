using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

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

        public void AddTask(Task t)
        {
            Tasks.Add(t);
        }

        public void ExecuteAll()
        {
            foreach (var t in Tasks)
            {
                t.Execute();
            }
        }

        public void ClearAll()
        {
            Tasks.Clear();
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
                throw;
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
                throw;
            }
        }
    }
}