namespace JTTT_1._0
{

   public interface IReaction
    {
        string GetReactionName();
        void DoReaction(IModel model);
        IModel GetEmptyModel();
    }
}