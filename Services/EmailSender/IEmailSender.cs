using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.EmailSender
{
public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}

