using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTTT_1._0
{
    class TaskManager
    {
        readonly BindingList<Task> _tasksList;

        public TaskManager()
        {
            _tasksList = new BindingList<Task>();
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
    }
}
