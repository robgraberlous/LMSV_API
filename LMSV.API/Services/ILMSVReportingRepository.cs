using LMSV.API.Entities;

namespace LMSV.API.Services
{
    public interface ILMSVReportingRepository
    {
        IQueryable<Card> GetCards();
    }
}
