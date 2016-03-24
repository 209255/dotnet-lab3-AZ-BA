using System.ComponentModel;

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
        public void AddToList(Task t)
        {
            _tasksList.Add(t);
        }

        public void ExecuteAll()
        {
            foreach (var t in _tasksList)
            {
                t.CheckAndExecute();
            }
        }

        public void ClearAll()
        {
            _tasksList.Clear();
        }

        public void Serialize()
        {
            
        }

        public void DeSerialize()
        {
            
        }
    }
}
