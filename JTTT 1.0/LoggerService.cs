using System.Text;

namespace JTTT_1._0
{
    class LoggerService
    {
        FileWritter writter;

        public void AddAction(string action)
        {
            writter = new FileWritter();
            writter.AppendTextFile(action + "\n");
        }
    }
}
