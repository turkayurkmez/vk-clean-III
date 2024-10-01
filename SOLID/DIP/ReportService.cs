using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    public interface ISender
    {
        void Send();
    }
    public class MailSender : ISender
    {
        public  void Send()
        {
            Console.WriteLine("Mail atıldı");
        }
    }

    public class SMSSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("SMS atıldı");
        }
    }

    public class TelegramSender : ISender
    {
        public void Send()
        {
            Console.WriteLine("Telegram ile mesaj atıldı");
        }
    }

    public class ReportService
    {

        private ISender sender;

        public ISender Sender { get => sender; set => sender = value; }

        public ReportService(ISender mailSender)
        {
                this.sender = mailSender;
        }
        public void SendReport()
        {
            //MailSender mailSender = new MailSender();
            sender.Send();
        }

        public void SendNotificationMail()
        {
            sender.Send();
        }
    }
}
