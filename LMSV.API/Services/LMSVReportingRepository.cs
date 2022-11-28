using LMSV.API.DbContexts;
using LMSV.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.Services
{
    public class LMSVReportingRepository : ILMSVReportingRepository
    {
        private readonly CardInfoContext _context;

        public LMSVReportingRepository(CardInfoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<IEnumerable<Card>> GetCardsAsync()
        {
            return await _context.Cards.OrderBy(c => c.cardNumber).ToListAsync();
        }

        public async Task<Card?> GetCardAsync(long id)
        {
            return await _context.Cards
                .Where(c => c.Id == id).FirstOrDefaultAsync();
        }
    }
}
