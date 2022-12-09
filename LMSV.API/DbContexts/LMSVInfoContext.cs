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
                .Entity<EmsUser>()
                .ToSqlQuery(
                @"
    SELECT TOP (1000) [active]
        ,[id]
        ,[created_at]
        ,[updated_at]
        ,[name]
        ,[email]
        ,[phone]
        ,[emailVerified]
        ,[image]
    FROM [emsBackend].[users]
    union
    select CONVERT(SMALLINT, 0)
    ,TRY_CONVERT(UNIQUEIDENTIFIER, '00000000-0000-0000-0000-000000000000')
    ,SYSUTCDATETIME()
    ,SYSUTCDATETIME()
    ,''
    ,''
    ,''
    ,''
    ,''");
            
                modelBuilder
                .Entity<Transaction>()
                .ToSqlQuery(
                @"
  SELECT [id]
      ,CASE WHEN [type] IN ('redemption', 'refund') 
        OR ([type] = 'adjustment' AND [reason] = 'refund') THEN -[amount] ELSE [amount] END AS [amount]
      ,[type]
      ,[reason]
      ,[accountId]
      ,[cardId]
      ,[createdAt]
      ,CONVERT(DATETIME, DATEADD(hh, -6, [transactionDate]) AT TIME ZONE 'UTC' AT TIME ZONE 'Central Standard Time') AS [transactionDate]
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
