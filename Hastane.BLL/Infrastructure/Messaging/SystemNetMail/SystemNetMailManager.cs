using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Hastane.BLL.Infrastructure.Messaging.Abstracts;

namespace Hastane.BLL.Infrastructure.Messaging.SystemNetMail
{
    public class SystemNetMailManager : IMessaging
    {
        private bool _isSucceed = false;

        public bool IsSucceed
        {
            get { return _isSucceed; }
        }

        public void SendMessage(MessageTemplate msj)
        {
            var message = new MailMessage {From = new MailAddress(msj.From)};

            foreach (var item in msj.To)
            {
                message.To.Add(item);
            }

            message.Body = msj.MessageBody;
            message.Subject = msj.MessageSubject;

            var client = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                Credentials = new NetworkCredential("mailadresi@mailadrei.com", "MailAdresiSifresi"),
                EnableSsl = true
            };

            try
            {
                client.Send(message);
                _isSucceed = true;
            }
            catch (Exception)
            {
                _isSucceed = true;
            }
        }
    }
}
