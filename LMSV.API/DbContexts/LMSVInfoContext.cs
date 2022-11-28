using LMSV.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.DbContexts
{
    public class LMSVInfoContext : DbContext
    {
        public DbSet<Card> Cards { get; set; } = null!;

        public LMSVInfoContext(DbContextOptions<LMSVInfoContext> options)
            : base(options)
        {

        }
    }
}
