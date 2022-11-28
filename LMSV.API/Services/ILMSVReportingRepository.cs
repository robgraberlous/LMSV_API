using LMSV.API.Entities;

namespace LMSV.API.Services
{
    public interface ILMSVReportingRepository
    {
        Task<IEnumerable<Card>> GetCardsAsync();
        Task<Card?> GetCardAsync(long id);
    }
}
