using LMSV.API.STSModels;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.DbContexts;

public partial class GcStsdataContext : DbContext
{
    public GcStsdataContext()
    {
    }

    public GcStsdataContext(DbContextOptions<GcStsdataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<STSAddress> Addresses { get; set; }

    public virtual DbSet<STSCard> Cards { get; set; }

    public virtual DbSet<STSCardOrder> CardOrders { get; set; }

    public virtual DbSet<STSCardTran> CardTrans { get; set; }

    public virtual DbSet<STSChain> Chains { get; set; }

    public virtual DbSet<STSClerk> Clerks { get; set; }

    public virtual DbSet<STSMerchant> Merchants { get; set; }

    public virtual DbSet<STSProduct> Products { get; set; }

    public virtual DbSet<STSTerminal> Terminals { get; set; }

    public virtual DbSet<STSValidProduct> ValidProducts { get; set; }

    public virtual DbSet<STSVenue> Venues { get; set; }

    public virtual DbSet<STSWtConfig> WtConfigs { get; set; }

    public virtual DbSet<STSWtUser> WtUsers { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=lous.database.windows.net;Initial Catalog=GC_STSData;Persist Security Info=True;User ID=wbudwitz@loumalnatis.com; Authentication=Active Directory Password; Encrypt=True; Password=P!zza1212");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<STSCardTran>(entity =>
        {
            entity.Property(e => e.CardTransPk).ValueGeneratedNever();
            entity.ToSqlQuery(
                @"
    SELECT [card_trans_pk]
	    ,[activation_location]
	    ,[batch_fk]
	    ,[card_number_fk]
	    ,[chip_value]
	    ,[create_date]
	    ,[created_by]
	    ,[description]
	    ,[fee_settlement_fk]
	    ,[hand_keyed]
	    ,[instant_reward]
	    ,[item_code]
	    ,[last_update_date]
	    ,[last_updated_by]
	    ,[manual_post_flag]
	    ,[merchant_id]
	    ,[other_purchase_amt]
	    ,[port_number]
	    ,[product_fk]
	    ,[quantity]
	    ,[rebate_base]
	    ,[ref]
	    ,[settlement_fk]
	    ,[source]
	    ,[timezone]
        ,CASE WHEN [trans_code] = 10 THEN -[trans_amount] ELSE [trans_amount] END AS [trans_amount]
	    ,[trans_code]
	    ,[trans_date]
	    ,[trans_seq_no]
	    ,[trans_time]
    FROM [Card_Trans]");

        });

        modelBuilder.Entity<STSMerchant>(entity =>
        {
            entity.Property(e => e.MerchantPk).ValueGeneratedNever();
        });

        modelBuilder.Entity<STSProduct>(entity =>
        {
            entity.Property(e => e.ProductPk).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
