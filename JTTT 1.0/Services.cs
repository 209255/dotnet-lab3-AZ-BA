using System.Collections.Generic;

namespace JTTT_1._0
{
    class Services
    {
    
        public static Services Instance => _instance ?? (_instance = new Services());

        private static Services _instance;
        public HtmlService Htmlservice;
        public LoggerService Logger;
        public TaskService Tasks;
        public ActionRegister ActionRegister;
        public ReactionRegister ReactionRegister;

        private Services()
        {
            Logger = new LoggerService();
            Htmlservice = new HtmlService();
            ActionRegister = new ActionRegister();
            ReactionRegister = new ReactionRegister();
            Tasks = new TaskService();
        }               
    }
}
