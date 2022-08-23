namespace MailServiceDecorator
{
   // A list of sent messages - a "fake" database
   public class MessageDatabaseDecorator : MailServiceDecoratorBase
   {
      public List<string> SentMessages { get; private set; } = new List<string>();
      public MessageDatabaseDecorator(IMailService mailService)
          : base(mailService)
      {

      }

      public override bool SendMail(string message)
      {
         if (base.SendMail(message))
         {
            SentMessages.Add(message);
            return true;
         };

         return false;
      }
   }
}