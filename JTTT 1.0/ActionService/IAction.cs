
using System;

namespace JTTT_1._0
{
    
    public interface IAction
    {
        string GetActionName();
        string DoAction(Model model);
        Model GetEmptyModel();
    }
}
