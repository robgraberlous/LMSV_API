using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("Card_Orders")]
public partial class CardOrder
{
    [Key]
    [Column("card_orders_pk", TypeName = "decimal(18, 2)")]
    public decimal CardOrdersPk { get; set; }

    [Column("product_fk", TypeName = "decimal(18, 2)")]
    public decimal ProductFk { get; set; }

    [Column("press_setup", TypeName = "decimal(18, 2)")]
    public decimal PressSetup { get; set; }

    [Column("per_card_price", TypeName = "decimal(18, 2)")]
    public decimal PerCardPrice { get; set; }

    [Column("printed_by")]
    public string? PrintedBy { get; set; }

    [Column("job_number")]
    public string? JobNumber { get; set; }

    [Column("qr_code_url")]
    public string? QrCodeUrl { get; set; }

    [Column("starting_card_number")]
    public string? StartingCardNumber { get; set; }

    [Column("create_date")]
    public DateTime? CreateDate { get; set; }

    [Column("created_by")]
    public string? CreatedBy { get; set; }
}
