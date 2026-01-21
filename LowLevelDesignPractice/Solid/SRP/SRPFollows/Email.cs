using System.Net.Mail;

namespace SRP
{
    class EmailService
    {
        public void Send(string to, string from, string body)
        {
            SmtpClient client = new SmtpClient(to);
            client.Send(to,from, body, "Invoice Attached");
        }
    }
}