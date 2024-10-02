using CleanCode.Entities;

namespace CleanCode.Application
{
    public class MailService
    {
        private readonly IPaymentService paymentService;

        public MailService(IPaymentService paymentService)
        {
            this.paymentService = paymentService;
        }

        public void SendMailToCompanies(List<Company> companies, List<TimeSheetEntry> timeSheetEntries)
        {


            companies.ForEach(company =>
            {
                double totalPriceForCompany = paymentService.GetTotalBillForCompany(timeSheetEntries, company);
                Console.WriteLine("Simulating Sending email to " + company.Name);
                Console.WriteLine($"Your bill is $ {totalPriceForCompany} for the hours worked.");
            });



        }


    }
}
