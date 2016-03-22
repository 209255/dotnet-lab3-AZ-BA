using System.Collections.Generic;
using System.Linq;

namespace JTTT_1._0
{
    class ActionRegister
    {
        readonly Dictionary<string, IAction> _reg;

        public void RegisterAction(IAction action)
        {
            _reg.Add(action.GetActionName(), action);
        }

        public IAction GetAction(string actionName)
        {
            return _reg[actionName];
        }

        public List<string> GetActionNames()
        {
            return _reg.Select(action => action.Key).ToList();
        }

        public ActionRegister()
        {
            _reg = new Dictionary<string, IAction>();
        }

    }
}
