using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("Address")]
public partial class STSAddress
{
    [Key]
    [Column("address_pk", TypeName = "decimal(18, 2)")]
    public decimal AddressPk { get; set; }

    [Column("entity_fk", TypeName = "decimal(18, 2)")]
    public decimal EntityFk { get; set; }

    [Column("entity_type")]
    public string? EntityType { get; set; }

    [Column("contact_prefix")]
    public string? ContactPrefix { get; set; }

    [Column("contact_fname")]
    public string? ContactFname { get; set; }

    [Column("contact_lname")]
    public string? ContactLname { get; set; }

    [Column("address1")]
    public string? Address1 { get; set; }

    [Column("address2")]
    public string? Address2 { get; set; }

    [Column("address3")]
    public string? Address3 { get; set; }

    [Column("city")]
    public string? City { get; set; }

    [Column("state")]
    public string? State { get; set; }

    [Column("zip")]
    public string? Zip { get; set; }

    [Column("country")]
    public string? Country { get; set; }

    [Column("phone1")]
    public string? Phone1 { get; set; }

    [Column("phone2")]
    public string? Phone2 { get; set; }

    public string? Fax { get; set; }

    [Column("email")]
    public string? Email { get; set; }

    [Column("comments")]
    public string? Comments { get; set; }

    [Column("create_date")]
    public DateTime CreateDate { get; set; }
}
