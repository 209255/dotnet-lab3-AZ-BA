using System.Net.Mail;

namespace JTTT_1._0
{
    interface IEmailService
    {
        void Send(EmailMsg message);
    }
}
