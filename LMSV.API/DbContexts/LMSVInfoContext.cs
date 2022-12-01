using LMSV.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.DbContexts
{
    public class LMSVInfoContext : DbContext
    {
        public DbSet<Card> Cards { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<EmsUser> EmsUsers { get; set; } = null!;
        public DbSet<GiftCardType> GiftCardTypes { get; set; } = null!;
        public DbSet<Store> Stores { get; set; } = null!;
        public DbSet<Transaction> Transactions { get; set; } = null!;

        public LMSVInfoContext(DbContextOptions<LMSVInfoContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder
                .Entity<Transaction>()
                .ToSqlQuery(
                @"
  SELECT [id]
      ,[amount]
      ,[type]
      ,[reason]
      ,[accountId]
      ,[cardId]
      ,[createdAt]
      ,[transactionDate]
      ,[message]
      ,[terminalId]
      ,[storeId]
      ,CASE WHEN 
        TRY_CONVERT(UNIQUEIDENTIFIER, [clientId]) IS NOT NULL THEN TRY_CONVERT(UNIQUEIDENTIFIER, [clientId]) 
        ELSE TRY_CONVERT(UNIQUEIDENTIFIER, '00000000-0000-0000-0000-000000000000') END AS EmsUserId
      ,CASE WHEN 
        TRY_CONVERT(UNIQUEIDENTIFIER, [clientId]) IS NULL THEN TRY_CONVERT(int, [clientId])
        ELSE TRY_CONVERT(int, '0') END AS ClientId
  FROM [transactions]");

        }
    }
}
