using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("Merchant")]
public partial class Merchant
{
    [Key]
    [Column("merchant_pk")]
    public int MerchantPk { get; set; }

    [Column("merchant_id")]
    public string? MerchantId { get; set; }

    [Column("chain_fk")]
    public int ChainFk { get; set; }

    [Column("dba_name")]
    public string? DbaName { get; set; }

    [Column("contact_prefix")]
    public string? ContactPrefix { get; set; }

    [Column("contact_fname")]
    public string? ContactFname { get; set; }

    [Column("contact_lname")]
    public string? ContactLname { get; set; }

    [Column("phone1")]
    public string? Phone1 { get; set; }

    [Column("phone2")]
    public string? Phone2 { get; set; }

    [Column("fax")]
    public string? Fax { get; set; }

    [Column("sic")]
    public string? Sic { get; set; }

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

    [Column("email")]
    public string? Email { get; set; }
}
