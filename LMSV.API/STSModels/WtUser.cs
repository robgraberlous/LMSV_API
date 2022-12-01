using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("WT_Users")]
public partial class WtUser
{
    [Key]
    [Column("wt_users_pk", TypeName = "decimal(18, 2)")]
    public decimal WtUsersPk { get; set; }

    [Column("merchant_fk", TypeName = "decimal(18, 2)")]
    public decimal MerchantFk { get; set; }

    [Column("username")]
    public string? Username { get; set; }

    [Column("password")]
    public string? Password { get; set; }

    [Column("rights")]
    public string? Rights { get; set; }

    [Column("merchantID")]
    public string? MerchantId { get; set; }

    [Column("terminalID")]
    public string? TerminalId { get; set; }

    [Column("userConfig")]
    public string? UserConfig { get; set; }

    [Column("obsolete")]
    public string? Obsolete { get; set; }

    [Column("create_date")]
    public DateTime? CreateDate { get; set; }

    [Column("created_by")]
    public string? CreatedBy { get; set; }
}
