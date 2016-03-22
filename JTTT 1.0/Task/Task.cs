namespace JTTT_1._0
{
    abstract class Task
    {
        protected IAction Action;
        protected IReaction Reaction;
        protected string Name;

        protected Task(string name)
        {
            Name = name;
        }

        public bool CheckAndExecute()
        {
            return true;
        }
    }
}