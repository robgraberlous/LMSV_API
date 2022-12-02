using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("WT_Config")]
public partial class STSWtConfig
{
    [Key]
    [Column("wt_config_pk", TypeName = "decimal(18, 2)")]
    public decimal WtConfigPk { get; set; }

    [Column("merchant_fk", TypeName = "decimal(18, 2)")]
    public decimal MerchantFk { get; set; }

    [Column("merchantID")]
    public string? MerchantId { get; set; }

    [Column("name")]
    public string? Name { get; set; }

    [Column("addr")]
    public string? Addr { get; set; }

    [Column("city")]
    public string? City { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("zip")]
    public string? Zip { get; set; }

    public string? ContactLine { get; set; }

    public string? Announce1 { get; set; }

    public string? Announce2 { get; set; }

    public string? BalanceMsg { get; set; }

    public string? MsgFont { get; set; }

    public string? Msg1 { get; set; }

    public string? Msg2 { get; set; }

    public string? Msg3 { get; set; }

    public string? Msg4 { get; set; }

    public string? Msg5 { get; set; }

    public string? Msg6 { get; set; }

    public string? Msg7 { get; set; }

    public bool GiftCards { get; set; }

    public bool LoyaltyCards { get; set; }

    [Column("ClerkIDRequired")]
    public bool ClerkIdrequired { get; set; }

    public bool ClerkPswRequired { get; set; }

    public bool GiftSignatureRequired { get; set; }

    public bool LoyaltySignatureRequired { get; set; }

    public bool TipLine { get; set; }

    [Column("PINrequired")]
    public bool Pinrequired { get; set; }

    [Column("url")]
    public string? Url { get; set; }

    [Column("obsolete")]
    public string? Obsolete { get; set; }

    [Column("create_date")]
    public DateTime? CreateDate { get; set; }

    [Column("created_by")]
    public string? CreatedBy { get; set; }

    [Column("force_sale")]
    public string? ForceSale { get; set; }

    [Column("e_gift")]
    public string? EGift { get; set; }
}
