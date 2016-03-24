namespace JTTT_1._0
{
    abstract class Task
    {
        protected string ActionName;
        protected string ReactionName;
        protected Model ActionModel;
        protected string Name;

        protected Task(string name)
        {
            Name = name;
        }

        public bool Execute()
        {
            return true;
        }
    }
}