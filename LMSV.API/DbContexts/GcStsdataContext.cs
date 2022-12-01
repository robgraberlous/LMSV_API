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

    public virtual DbSet<CardTran> CardTrans { get; set; }

    public virtual DbSet<Chain> Chains { get; set; }

    public virtual DbSet<Clerk> Clerks { get; set; }

    public virtual DbSet<Merchant> Merchants { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Terminal> Terminals { get; set; }

    public virtual DbSet<ValidProduct> ValidProducts { get; set; }

    public virtual DbSet<Venue> Venues { get; set; }

    public virtual DbSet<WtConfig> WtConfigs { get; set; }

    public virtual DbSet<WtUser> WtUsers { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=lous.database.windows.net;Initial Catalog=GC_STSData;Persist Security Info=True;User ID=wbudwitz@loumalnatis.com; Authentication=Active Directory Password; Encrypt=True; Password=P!zza1212");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CardTran>(entity =>
        {
            entity.Property(e => e.CardTransPk).ValueGeneratedNever();
        });

        modelBuilder.Entity<Merchant>(entity =>
        {
            entity.Property(e => e.MerchantPk).ValueGeneratedNever();
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.ProductPk).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
