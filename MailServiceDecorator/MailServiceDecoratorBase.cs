namespace MailServiceDecorator
{
    // Decorator
   public class MailServiceDecoratorBase : IMailService
   {
        private readonly IMailService _mailService;

        public MailServiceDecoratorBase(IMailService mailService)
        {
            _mailService = mailService;
        }
      public virtual bool SendMail(string message)
      {
         return _mailService.SendMail(message);
      }
   }
}