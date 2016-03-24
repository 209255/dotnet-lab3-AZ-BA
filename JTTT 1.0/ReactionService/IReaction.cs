namespace JTTT_1._0
{

    interface IReaction
    {
        string GetReactionName();
        void DoReaction(Model model);
        Model GetEmptyModel();
    }
}