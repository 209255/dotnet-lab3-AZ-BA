using System.Collections.Generic;

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
            List<string> names = new List<string>();
            foreach (var action in reg)
                names.Add(action.Key);
            return names;
        }

        public ActionRegister()
        {
            reg = new Dictionary<string, IAction>();
        }

    }
}
