using CleanCode.Entities;

namespace CleanCode.Application
{
    public class PaymentService : IPaymentService
    {
        public double GetExtraPayment(double totalHours, int maxHourPerWeek, double normalPayment, double extraPayment)
        {
            var billAmount = 0.0;
            if (totalHours > maxHourPerWeek)
            {
                var extra = (totalHours - maxHourPerWeek) * extraPayment;
                var normal = maxHourPerWeek * normalPayment;
                billAmount = extra + normal;
            }
            else
            {
                billAmount = totalHours * normalPayment;
                //Console.WriteLine("You will get paid $" + (totalHours * 10) + " for your time.");
            }

            return billAmount;
        }


        public double GetTotalBillForCompany(List<TimeSheetEntry> timeSheetEntries, Company company)
        {

            double totalHours = timeSheetEntries
                                     .Where(x => isThatCompany(x, company.Name))
                                     .Sum(x => x.HoursWorked);

            return totalHours * company.ContractedHourlyPrice;
        }



        private bool isThatCompany(TimeSheetEntry timeSheetEntry, string companyName)
        {
            var completedWork = timeSheetEntry.WorkDone.ToLower();
            var lowerCompanyName = companyName.ToLower();
            return completedWork.Contains(lowerCompanyName);
        }
    }
}
