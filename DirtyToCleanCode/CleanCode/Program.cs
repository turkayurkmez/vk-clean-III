
using CleanCode.Application;
using CleanCode.Entities;

namespace CleanCode;
internal class Program
{
    static void Main(string[] args)
    {

        List<TimeSheetEntry> timeSheetEntries = getTimeSheetEntriesFromUser();

        PaymentService paymentService = new PaymentService();
        sendEmails(timeSheetEntries, paymentService);

        calculateExtraPayment(timeSheetEntries, paymentService);
        Console.WriteLine();
        Console.Write("Press any key to exit application...");
        Console.ReadKey();
    }

    private static void calculateExtraPayment(List<TimeSheetEntry> timeSheetEntries, PaymentService paymentService)
    {
        var totalHours = timeSheetEntries.Sum(t => t.HoursWorked);
        var extraPayment = paymentService.GetExtraPayment(totalHours, maxHourPerWeek: 40, normalPayment: 10, extraPayment: 15);
        Console.WriteLine($"You will get paid $ {extraPayment} for your work.");
    }

    private static void sendEmails(List<TimeSheetEntry> timeSheetEntries, PaymentService paymentService)
    {
        MailService mailService = new MailService(paymentService);
        var companies = new CompanyService().GetCompanies();
        mailService.SendMailToCompanies(companies, timeSheetEntries);
    }

    static List<TimeSheetEntry> getTimeSheetEntriesFromUser()
    {

        List<TimeSheetEntry> timeSheetEntries = new List<TimeSheetEntry>();
        string answer = string.Empty;
        do
        {
            var timeSheetEntry = getTimeSheetEntryFromUser();
            timeSheetEntries.Add(timeSheetEntry);
            Console.Write("Do you want to enter more time (yes/no): ");
            answer = Console.ReadLine();


        } while (answer.ToLower() == Answers.YES);

        return timeSheetEntries;
    }

    private static TimeSheetEntry getTimeSheetEntryFromUser()
    {

        Console.Write("Enter what you did: ");
        string workDescription = Console.ReadLine();
        Console.Write("How long did you do it for: ");
        string rawTimeWorked = Console.ReadLine();

        double workingHours = getDoubleValue(rawTimeWorked);
        TimeSheetEntry timeSheetEntry = new TimeSheetEntry
        {
            HoursWorked = workingHours,
            WorkDone = workDescription
        };

        return timeSheetEntry;

    }

    private static double getDoubleValue(string rawTimeWorked)
    {
        double workingHours;
        while (!double.TryParse(rawTimeWorked, out workingHours))
        {
            Console.WriteLine();
            Console.WriteLine("Invalid number given");
            Console.Write("How long did you do it for: ");
            rawTimeWorked = Console.ReadLine();
        }

        return workingHours;
    }



}
