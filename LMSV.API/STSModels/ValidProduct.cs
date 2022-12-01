using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("Valid_Products")]
public partial class ValidProduct
{
    [Key]
    [Column("valid_products_pk", TypeName = "decimal(18, 2)")]
    public decimal ValidProductsPk { get; set; }

    [Column("product_fk", TypeName = "decimal(18, 2)")]
    public decimal ProductFk { get; set; }

    [Column("chain_id")]
    public string? ChainId { get; set; }

    [Column("product_name")]
    public string? ProductName { get; set; }

    [Column("credits_ok")]
    public string? CreditsOk { get; set; }

    [Column("redeem_ok")]
    public string? RedeemOk { get; set; }

    [Column("mall_card")]
    public string? MallCard { get; set; }

    [Column("commision", TypeName = "decimal(18, 2)")]
    public decimal? Commision { get; set; }

    [Column("admin_fee", TypeName = "decimal(18, 2)")]
    public decimal? AdminFee { get; set; }

    [Column("sub_product_of", TypeName = "decimal(18, 2)")]
    public decimal? SubProductOf { get; set; }
}
