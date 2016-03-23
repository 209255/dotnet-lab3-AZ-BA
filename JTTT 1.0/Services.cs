using System.Collections.Generic;

namespace JTTT_1._0
{
    class Services
    {
        //class ActionReactionPair
        //{
        //    public IReaction Reaction { get; set; }
        //    public List<IAction> Action { get;set; }
        //}
        //private ActionReactionPair _actions = new ActionReactionPair();

        //public void AddActionReaction(IReaction r,ref List<IAction> a)
        //{
        //    _actions = new ActionReactionPair {Reaction = r,Action = a};
        //}
        public static Services Instance
        {
            get { return _instance ?? (_instance = new Services()); }
        }
        
        private static Services _instance;
        public HtmlService Htmlservice;
        public LoggerService Logger;
        public TaskManager AllTasks;
        public ActionRegister ActionRegister;

        private Services()
        {
            Logger = new LoggerService();
            Htmlservice = new HtmlService();
            AllTasks = new TaskManager();
            ActionRegister = new ActionRegister();
        }               
    }
}
