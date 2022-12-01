using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("Clerk")]
public partial class STSClerk
{
    [Column("entity_id")]
    public string? EntityId { get; set; }

    [Column("clerk_id")]
    public string? ClerkId { get; set; }

    [Column("fname")]
    public string? Fname { get; set; }

    [Column("lname")]
    public string? Lname { get; set; }

    [Column("mname")]
    public string? Mname { get; set; }

    [Column("password")]
    public string? Password { get; set; }

    [Column("activation")]
    public string? Activation { get; set; }

    [Column("sale")]
    public string? Sale { get; set; }

    [Column("accrual")]
    public string? Accrual { get; set; }

    [Column("redemption")]
    public string? Redemption { get; set; }

    [Column("tip")]
    public string? Tip { get; set; }

    [Column("renewal")]
    public string? Renewal { get; set; }

    [Column("setup_date")]
    public DateTime? SetupDate { get; set; }

    [Key]
    [Column("clerk_pk", TypeName = "decimal(18, 2)")]
    public decimal ClerkPk { get; set; }
}
