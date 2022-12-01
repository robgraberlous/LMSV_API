using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("Venue")]
public partial class Venue
{
    [Key]
    [Column("venue_pk", TypeName = "decimal(18, 2)")]
    public decimal VenuePk { get; set; }

    [Column("venue_id")]
    public string? VenueId { get; set; }

    [Column("venue_name")]
    public string? VenueName { get; set; }

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

    [Column("send_residuals")]
    public string? SendResiduals { get; set; }

    [Column("email")]
    public string? Email { get; set; }
}
