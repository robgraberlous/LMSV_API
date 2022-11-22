using LMSV.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.DbContexts
{
    public class CardInfoContext : DbContext
    {
        public DbSet<Card> Cards { get; set; } = null!;

        public CardInfoContext(DbContextOptions<CardInfoContext> options)
            : base(options)
        {

        }
    }
}
