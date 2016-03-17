namespace JTTT_1._0
{

    public interface IReaction
    {
        string GetReactionName();
        void DoReaction(string url, string filepath, string emailAdd, string keyword);
    }
}