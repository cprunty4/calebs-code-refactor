namespace MailServiceDecorator
{
    // Concrete component
   public class CloudMailService : IMailService
   {
        public bool SendMail(string message)
        {
            Console.WriteLine($"Message \"{message}\" " +
            $"send via {nameof(CloudMailService)}.");
            return true;
        }
   }
}