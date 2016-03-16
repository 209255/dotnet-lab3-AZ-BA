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

        public HtmlService htmlservice;
        public LoggerService logger;

        private Services()
        {
            logger = new LoggerService();
            htmlservice = new HtmlService();
        }               
    }
}
