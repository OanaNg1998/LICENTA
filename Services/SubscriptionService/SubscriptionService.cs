using JUSTMOVE.Models;
using JUSTMOVE.Repositories.QRCode;
using JUSTMOVE.Repositories.SubscriptionRepository;
using JUSTMOVE.Services.EmailSender;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JUSTMOVE.Services.SubscriptionService
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository _subscriptionRepository;

        private readonly IEmailSender _emailSender;
        private readonly ISaleQRCodeRepository _qrCodeRepository;

        public SubscriptionService(ISubscriptionRepository subscriptionRepository, IEmailSender emailSender,ISaleQRCodeRepository qrCodeRepository)
        {
            _subscriptionRepository = subscriptionRepository;
            _emailSender = emailSender;
            _qrCodeRepository = qrCodeRepository;

        }
        public Subscription CreateSubscription(Subscription subscription)
        {
            if (_subscriptionRepository.FindById(subscription.Id) != null)//nu exista alt abonament
            {
                return null;
            }
            _subscriptionRepository.Create(subscription);
          
           

            _subscriptionRepository.SaveChanges();
            return subscription;
        }
        public async Task<string> GetQRCodeAsync( string emailAddress)
        {
            // var qrText = "maimuta";
            Random random = new Random();
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var qrText =  new string(Enumerable.Repeat(chars, 10)
      .Select(s => s[random.Next(s.Length)]).ToArray());
           // Console.Write(qrText);
            QRCoder.QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            // Image qrImage = (Image)qrCodeImage;
            using (MemoryStream ms = new MemoryStream())
            {
                qrCodeImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] byteArr = ms.ToArray();
                string b64Txt = Convert.ToBase64String(byteArr);
                string message;
              
                string hrefText = "data:image/png;base64," + b64Txt;
                message = "<p><img src='" + hrefText + "'</p>";
                //aici
                SaleQRCode code = new SaleQRCode
                {
                    Id = Guid.NewGuid().ToString(),
                    QRText = qrText,
                    Image = hrefText,

                };
                _qrCodeRepository.Create(code);
                //aici

                await _emailSender.SendEmailAsync(emailAddress/*"oana_neagu98@yahoo.com"*/, "Discount",
                       message);
                return hrefText;
            }
            
           

        }
    }
}
