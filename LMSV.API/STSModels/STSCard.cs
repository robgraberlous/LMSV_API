using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace LMSV.API.STSModels;

[Table("Card")]
[Index("ProductFk", Name = "IX_Card_product_fk")]
public partial class STSCard
{
    [Key]
    [Column("card_number")]
    [StringLength(20)]
    [Unicode(false)]
    public string CardNumber { get; set; } = null!;

    [Column("product_fk")]
    public int ProductFk { get; set; }

    [Column("activation_date")]
    public DateTime ActivationDate { get; set; }

    [Column("status")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("activation_location")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ActivationLocation { get; set; }

    [Column("activation_terminal")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ActivationTerminal { get; set; }

    [Column("fname")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Fname { get; set; }

    [Column("lname")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Lname { get; set; }

    [Column("mname")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Mname { get; set; }

    [Column("address1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [Column("address2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [Column("address3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [Column("city")]
    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [Column("state")]
    [StringLength(50)]
    [Unicode(false)]
    public string? State { get; set; }

    [Column("zip")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Zip { get; set; }

    [Column("phone1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Phone1 { get; set; }

    [Column("phone2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Phone2 { get; set; }

    [Column("obsolete")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Obsolete { get; set; }

    [Column("create_date")]
    public DateTime? CreateDate { get; set; }

    [Column("created_by")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column("point_value", TypeName = "decimal(18, 2)")]
    public decimal? PointValue { get; set; }

    [Column("cash_value", TypeName = "decimal(18, 2)")]
    public decimal? CashValue { get; set; }

    [Column("PIN")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Pin { get; set; }

    [Column("spend_limit", TypeName = "decimal(18, 2)")]
    public decimal? SpendLimit { get; set; }

    [Column("spend_limit_period", TypeName = "decimal(18, 2)")]
    public decimal? SpendLimitPeriod { get; set; }

    [Column("school_address1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SchoolAddress1 { get; set; }

    [Column("school_address2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SchoolAddress2 { get; set; }

    [Column("school_city")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SchoolCity { get; set; }

    [Column("school_state")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SchoolState { get; set; }

    [Column("school_zip")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SchoolZip { get; set; }

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("email_parent")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmailParent { get; set; }

    [Column("school")]
    [StringLength(50)]
    [Unicode(false)]
    public string? School { get; set; }

    [Column("club")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Club { get; set; }

    [Column("grad_date")]
    public DateTime? GradDate { get; set; }

    [Column("date_of_birth")]
    public DateTime? DateOfBirth { get; set; }

    [Column("purchase_date")]
    public DateTime? PurchaseDate { get; set; }

    [Column("credit_card_type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CreditCardType { get; set; }

    [Column("credit_card_num")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CreditCardNum { get; set; }

    [Column("credit_card_exp")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CreditCardExp { get; set; }

    [Column("credit_card_fname")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CreditCardFname { get; set; }

    [Column("credit_card_lname")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CreditCardLname { get; set; }

    [Column("maiden_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MaidenName { get; set; }

    [Column("mail_to")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MailTo { get; set; }

    [Column("mail_delivery")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MailDelivery { get; set; }

    [Column("feedback")]
    [Unicode(false)]
    public string? Feedback { get; set; }

    [Column("begin_point_value", TypeName = "decimal(18, 2)")]
    public decimal? BeginPointValue { get; set; }

    [Column("prev_balance", TypeName = "decimal(18, 2)")]
    public decimal? PrevBalance { get; set; }

    [Column("replacement_card_num")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReplacementCardNum { get; set; }

    [Column("mobile_phone")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MobilePhone { get; set; }

    //Navigation - Parents
    [ForeignKey("ProductFk")]
    public STSProduct? Product { get; set; }

}
