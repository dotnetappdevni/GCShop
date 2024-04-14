using GoCompareShop.GenServices.Interface;
using GoCompareShop.Models;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace GCBasket.Api
{
    public class EmailSenderBasket : IEmailSender
    {
        private readonly IEmailService _emailService;

        public EmailSenderBasket(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            EmailMessageModel emailMessage = new(email,
            subject,
            htmlMessage);

            await _emailService.Send(emailMessage);
        }
    }
}
