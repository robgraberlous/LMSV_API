using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("Product")]
public partial class STSProduct
{
    [Key]
    [Column("product_pk")]
    public int ProductPk { get; set; }

    [Column("product_id")]
    public string? ProductId { get; set; }

    [Column("product_name")]
    public string? ProductName { get; set; }

    [Column("description")]
    public string? Description { get; set; }

    [Column("obsolete")]
    public string? Obsolete { get; set; }

    [Column("create_date")]
    public DateTime CreateDate { get; set; }

    //Navigation - Children
    public ICollection<STSCard> Cards { get; set; } = new List<STSCard>();
}
