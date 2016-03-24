
namespace JTTT_1._0
{
    interface IAction
    {
        string GetActionName();
        string DoAction(Model model);
        Model GetEmptyModel();
    }
}
