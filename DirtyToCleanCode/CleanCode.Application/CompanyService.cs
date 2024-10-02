using CleanCode.Entities;

namespace CleanCode.Application
{
    public class CompanyService
    {
        public List<Company> GetCompanies()
        {
            return new List<Company>()
            {
                new(){ Name = "Acme", ContractedHourlyPrice = 150},
                new(){ Name = "ABC", ContractedHourlyPrice = 125},

            };
        }
    }
}
