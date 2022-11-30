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
        public DbSet<Transaction> Transactions { get; set; } = null!;

        public LMSVInfoContext(DbContextOptions<LMSVInfoContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder
            //    .Entity<Transaction>()
            //    .Property(t => t.oldClientId)
            //    .HasComputedColumnSql("CASE WHEN LEN([clientId]) < 10 THEN CAST([clientId] AS INT) ELSE 0 END");

            //modelBuilder
            //    .Entity<Transaction>().Ignore(t => t.oldClientId);

            modelBuilder
                .Entity<Transaction>()
                .ToSqlQuery<Transaction>(
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
      ,CASE WHEN TRY_CONVERT(UNIQUEIDENTIFIER, [clientId]) IS NOT NULL THEN [clientId] ELSE '' END AS clientId
	  ,CASE WHEN TRY_CONVERT(UNIQUEIDENTIFIER, [clientId]) IS NULL THEN [clientId] ELSE '' END AS oldClientId
  FROM [transactions]");

            modelBuilder
                .Entity<Client>()
                .Property(c => c.Id)
                .HasConversion(
                    v => int.Parse(v),
                    v => v.ToString(),
                    null
                );
        }
    }
}
