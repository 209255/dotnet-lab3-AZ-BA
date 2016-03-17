using System.Collections.Generic;
using System.Linq;

namespace JTTT_1._0
{
    class ActionRegister
    {
        Dictionary<string, IAction> reg;

        public void RegisterAction(IAction action)
        {
            reg.Add(action.GetActionName(), action);
        }

        public IAction GetAction(string actionName)
        {
            return reg[actionName];
        }

        public List<string> GetActionNames()
        {
            return reg.Select(action => action.Key).ToList();
        }

        public ActionRegister()
        {
            reg = new Dictionary<string, IAction>();
        }

    }
}
