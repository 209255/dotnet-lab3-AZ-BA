using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace JTTT_1._0
{
    class TaskService
    {
        readonly BindingList<Task> _tasksList;
        private readonly string _fileName;

        public TaskService()
        {
            _tasksList = new BindingList<Task>();
        }

        public BindingList<Task> Tasks
        {
            get { return _tasksList; }
        }
        public void AddTask(Task t)
        {
            _tasksList.Add(t);
        }

        public void ExecuteAll()
        {
            foreach (var t in _tasksList)
            {
                t.Execute();
            }
        }

        public void ClearAll()
        {
            _tasksList.Clear();
        }

        public void Serialize()
        {
            Stream stream = File.Open(_fileName, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, _tasksList);
            stream.Close();
        }

        public void Deserialize()
        {
            if (!File.Exists(_fileName)) return;
            Stream stream = File.Open(_fileName, FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            _tasksList.Clear();
            BindingList<Task> loaded = (BindingList<Task>)formatter.Deserialize(stream);

            foreach (var t in loaded)
            {
                _tasksList.Add(t);
            }

            stream.Close();
        }
    }
}
