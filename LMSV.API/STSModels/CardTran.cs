using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("Card_Trans")]
public partial class CardTran
{
    [Key]
    [Column("card_trans_pk")]
    public int CardTransPk { get; set; }

    [Column("batch_fk")]
    public int BatchFk { get; set; }

    [Column("card_number_fk")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CardNumberFk { get; set; }

    [Column("settlement_fk")]
    public int? SettlementFk { get; set; }

    [Column("fee_settlement_fk")]
    public int? FeeSettlementFk { get; set; }

    [Column("trans_seq_no")]
    public int? TransSeqNo { get; set; }

    [Column("trans_date")]
    public DateTime? TransDate { get; set; }

    [Column("trans_time")]
    public DateTime? TransTime { get; set; }

    [Column("timezone")]
    public string? Timezone { get; set; }

    [Column("trans_code")]
    public string? TransCode { get; set; }

    [Column("trans_amount", TypeName = "decimal(18, 2)")]
    public decimal TransAmount { get; set; }

    [Column("chip_value", TypeName = "decimal(18, 2)")]
    public decimal? ChipValue { get; set; }

    [Column("manual_post_flag")]
    public string? ManualPostFlag { get; set; }

    [Column("create_date")]
    public DateTime? CreateDate { get; set; }

    [Column("created_by")]
    public string? CreatedBy { get; set; }

    [Column("last_update_date")]
    public DateTime? LastUpdateDate { get; set; }

    [Column("last_updated_by")]
    public string? LastUpdatedBy { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("quantity")]
    public string? Quantity { get; set; }

    [Column("other_purchase_amt", TypeName = "decimal(18, 2)")]
    public decimal? OtherPurchaseAmt { get; set; }

    [Column("item_code", TypeName = "decimal(18, 2)")]
    public decimal? ItemCode { get; set; }

    [Column("product_fk")]
    public int? ProductFk { get; set; }

    [Column("hand_keyed")]
    public string? HandKeyed { get; set; }

    [Column("merchant_id")]
    public string? MerchantId { get; set; }

    [Column("activation_location")]
    public string? ActivationLocation { get; set; }

    [Column("instant_reward")]
    public string? InstantReward { get; set; }

    [Column("rebate_base", TypeName = "decimal(18, 2)")]
    public decimal? RebateBase { get; set; }

    [Column("source")]
    public int? Source { get; set; }

    [Column("ref")]
    public string? Ref { get; set; }

    [Column("port_number")]
    public int? PortNumber { get; set; }
}
