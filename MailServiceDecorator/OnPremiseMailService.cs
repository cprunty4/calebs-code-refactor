namespace MailServiceDecorator
{
   public class OnPremiseMailService : IMailService
   {
      public bool SendMail(string message)
      {
         Console.WriteLine($"Message \"{message}\" " +
         $"send via {nameof(OnPremiseMailService)}.");
         return true;
      }
   }
}