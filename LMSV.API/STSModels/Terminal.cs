using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("Terminal")]
public partial class Terminal
{
    [Key]
    [Column("terminal_pk", TypeName = "decimal(18, 2)")]
    public decimal TerminalPk { get; set; }

    [Column("terminal_id")]
    public string? TerminalId { get; set; }

    [Column("merchant_fk", TypeName = "decimal(18, 2)")]
    public decimal MerchantFk { get; set; }

    [Column("application_type")]
    public string? ApplicationType { get; set; }

    [Column("terminal_type")]
    public string? TerminalType { get; set; }

    [Column("serial_no")]
    public string? SerialNo { get; set; }

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

    [Column("hk_credits_ok")]
    public string? HkCreditsOk { get; set; }

    [Column("time_zone")]
    public int? TimeZone { get; set; }

    [Column("manual_close")]
    public string? ManualClose { get; set; }

    [Column("extra_pnt_mult")]
    public int? ExtraPntMult { get; set; }

    [Column("sales_ok")]
    public string? SalesOk { get; set; }

    [Column("lty_accruals_ok")]
    public string? LtyAccrualsOk { get; set; }

    [Column("lty_redeem_ok")]
    public string? LtyRedeemOk { get; set; }

    [Column("ip_address")]
    public string? IpAddress { get; set; }

    [Column("api_key")]
    public string? ApiKey { get; set; }

    [Column("batch_cutoff")]
    public int? BatchCutoff { get; set; }

    [Column("dup_timeout")]
    public int? DupTimeout { get; set; }

    [Column("reg_bonus_pnts", TypeName = "decimal(18, 2)")]
    public decimal? RegBonusPnts { get; set; }

    [Column("add_to_lty_fk", TypeName = "decimal(18, 2)")]
    public decimal? AddToLtyFk { get; set; }

    [Column("lty_chk_timeout")]
    public int? LtyChkTimeout { get; set; }

    [Column("from_no")]
    public string? FromNo { get; set; }

    [Column("crossref_phone_no_on_gc")]
    public string? CrossrefPhoneNoOnGc { get; set; }

    [Column("ave_tran_count")]
    public int? AveTranCount { get; set; }

    [Column("tran_count_limit", TypeName = "decimal(18, 2)")]
    public decimal? TranCountLimit { get; set; }

    [Column("preamble")]
    public string? Preamble { get; set; }

    [Column("preamble_exlude")]
    public string? PreambleExlude { get; set; }
}
