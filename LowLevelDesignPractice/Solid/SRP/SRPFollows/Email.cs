using System.Net.Mail;

class EmailService
{
    public void Send(string to, string from, string body)
    {
        SmtpClient client = new SmtpClient(to);
        client.Send(to,from, body, "Invoice Attached");
    }
}