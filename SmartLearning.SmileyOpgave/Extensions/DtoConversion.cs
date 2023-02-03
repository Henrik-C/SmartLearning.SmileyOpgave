using SmartLearning.SmileyOpgave.Entities;
using SmartLearning.SmileyOpgave.Models;
using SmartLearning.SmileyOpgave.Models.Dto;

namespace SmartLearning.SmileyOpgave.Extensions
{
    public static class DtoConversion
    {
        public static IEnumerable<SmileyReportDto> ConvertToDto(this IEnumerable<SmileyReport> reports,
                                                                IEnumerable<Company> companies)
        {
            return (from report in reports
                    join company in companies
                    on report.CompanyId equals company.Id
                    select new SmileyReportDto()
                    {
                        Id = report.Id,
                        Name = company.Name,
                        Cvr = company.Cvr,
                        Address= company.Address,
                        Smiley = (SmileyReportDto.SmileyRating)report.Smiley,
                        DateForSmiley = report.DateForSmiley
                    }).ToList();
        }
    }
}
