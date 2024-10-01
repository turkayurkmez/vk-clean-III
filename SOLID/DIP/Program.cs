// See https://aka.ms/new-console-template for more information
using DIP;

Console.WriteLine("Hello, World!");
/*
 *  D.I.P: Dependency Inversion Principle
 *  
 *   Bir nesne diğer nesneye bağlı ise (dependency), Büyük sistemler, küçük sistemlere bağlı olmamalı. Küçük sistemler büyük sistemlere dışardan dahil edilmeli.
 */

MailSender mailSender = new MailSender();
TelegramSender telegramSender = new TelegramSender();
SMSSender smsSender = new SMSSender();   
ReportService reportService = new ReportService(smsSender);


reportService.SendReport();
reportService.Sender = new MailSender();
reportService.SendReport();
reportService.Sender = new TelegramSender();
reportService.SendReport();

/*
 *  Giy(IKiyafet kiyafet)
 */