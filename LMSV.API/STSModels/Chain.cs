using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("Chain")]
public partial class Chain
{
    [Key]
    [Column("chain_pk", TypeName = "decimal(18, 2)")]
    public decimal ChainPk { get; set; }

    [Column("chain_id")]
    public string? ChainId { get; set; }

    [Column("venue_fk", TypeName = "decimal(18, 2)")]
    public decimal VenueFk { get; set; }

    [Column("chain_name")]
    public string? ChainName { get; set; }

    [Column("acquirer_fin_inst_fk", TypeName = "decimal(18, 2)")]
    public decimal? AcquirerFinInstFk { get; set; }

    [Column("ach_bank_name")]
    public string? AchBankName { get; set; }

    [Column("ach_aba_no")]
    public string? AchAbaNo { get; set; }

    [Column("ach_account_no")]
    public string? AchAccountNo { get; set; }

    [Column("fed_tax_id")]
    public string? FedTaxId { get; set; }

    [Column("state_tax_id")]
    public string? StateTaxId { get; set; }

    [Column("discount_rate", TypeName = "decimal(18, 2)")]
    public decimal? DiscountRate { get; set; }

    [Column("transaction_fee", TypeName = "decimal(18, 2)")]
    public decimal? TransactionFee { get; set; }

    [Column("comments")]
    public string? Comments { get; set; }

    [Column("obsolete")]
    public string? Obsolete { get; set; }

    [Column("create_date")]
    public DateTime? CreateDate { get; set; }

    [Column("created_by")]
    public string? CreatedBy { get; set; }

    [Column("last_update_date")]
    public DateTime? LastUpdateDate { get; set; }

    [Column("last_updated_by")]
    public string? LastUpdatedBy { get; set; }

    [Column("billing_plan")]
    public string? BillingPlan { get; set; }

    [Column("iso_plan_id")]
    public int? IsoPlanId { get; set; }

    [Column("monthly_min", TypeName = "decimal(18, 2)")]
    public decimal? MonthlyMin { get; set; }

    [Column("credit_fee", TypeName = "decimal(18, 2)")]
    public decimal? CreditFee { get; set; }

    [Column("purchase_fee", TypeName = "decimal(18, 2)")]
    public decimal? PurchaseFee { get; set; }

    [Column("loy_accrual_fee", TypeName = "decimal(18, 2)")]
    public decimal? LoyAccrualFee { get; set; }

    [Column("loy_redeem_fee", TypeName = "decimal(18, 2)")]
    public decimal? LoyRedeemFee { get; set; }

    [Column("credit_fee_to_ISO", TypeName = "decimal(18, 2)")]
    public decimal? CreditFeeToIso { get; set; }

    [Column("purchase_fee_to_ISO", TypeName = "decimal(18, 2)")]
    public decimal? PurchaseFeeToIso { get; set; }

    [Column("loy_accrual_fee_to_ISO", TypeName = "decimal(18, 2)")]
    public decimal? LoyAccrualFeeToIso { get; set; }

    [Column("loy_redeem_fee_to_ISO", TypeName = "decimal(18, 2)")]
    public decimal? LoyRedeemFeeToIso { get; set; }

    [Column("flat_monthly_fee", TypeName = "decimal(18, 2)")]
    public decimal? FlatMonthlyFee { get; set; }

    [Column("max_trans_count", TypeName = "decimal(18, 2)")]
    public decimal? MaxTransCount { get; set; }

    [Column("paid_through")]
    public DateTime? PaidThrough { get; set; }

    [Column("flat_monthly_fee_ISO", TypeName = "decimal(18, 2)")]
    public decimal? FlatMonthlyFeeIso { get; set; }

    [Column("payment_method")]
    public string? PaymentMethod { get; set; }

    [Column("billing_email")]
    public string? BillingEmail { get; set; }

    [Column("monthly_min_ISO", TypeName = "decimal(18, 2)")]
    public decimal? MonthlyMinIso { get; set; }

    [Column("industry")]
    public string? Industry { get; set; }

    [Column("bill_bal_inq")]
    public string? BillBalInq { get; set; }

    [Column("discount_rate_iso", TypeName = "decimal(18, 2)")]
    public decimal? DiscountRateIso { get; set; }
}
