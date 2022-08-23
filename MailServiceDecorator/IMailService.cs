namespace MailServiceDecorator
{
    // Component
    public interface IMailService
    {
         bool SendMail(string message);
    }
}