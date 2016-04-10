namespace JTTT_1._0
{

   public abstract class IReaction
    {
        public int Id { get; set; }
       // public virtual Task Task { get; set; }
        public abstract string GetReactionName();
        public abstract  void DoReaction(IModel model);
        public abstract IModel GetEmptyModel();
        public abstract ReactionView GetView();
    }
}