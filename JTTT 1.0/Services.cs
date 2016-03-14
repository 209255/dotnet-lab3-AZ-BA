namespace JTTT_1._0
{
    public class Services
    {
        public static Services Instance
        {
            get
            {
                if (instance == null)
                    instance = new Services();
                return instance;
            }
        }
        private static Services instance;


        private Services()
        {

        }
    }
}
