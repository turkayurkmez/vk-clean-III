using CleanCode.Entities;

namespace CleanCode.Application
{
    public interface IPaymentService
    {
        double GetExtraPayment(double totalHours, int maxHourPerWeek, double normalPayment, double extraPayment);
        double GetTotalBillForCompany(List<TimeSheetEntry> timeSheetEntries, Company company);
    }
}