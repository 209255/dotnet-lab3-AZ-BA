using JTTT_1._0.Database;

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
        public TaskServiceDbContext TaskServiceDbContext;
        public WeatherService WeatherService;

        private Services()
        {
            Logger = new LoggerService();
            Htmlservice = new HtmlService();
            ActionRegister = new ActionRegister();
            ReactionRegister = new ReactionRegister();
            Tasks = new TaskService();
            TaskServiceDbContext = new TaskServiceDbContext();
            WeatherService = new WeatherService();

        }               
    }
}
