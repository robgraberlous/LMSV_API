using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSV.API.Entities
{
    [Table("giftCardType")]
    public class GiftCardType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string? name { get; set; } = string.Empty;

        [MaxLength(45)]
        public string? prefix { get; set; }

        [Required]
        public byte isReloadable { get; set; } = 0;

        [Required]
        public byte isSequential { get; set; } = 0;

        public DateTime? issueStartDate { get; set; }

        public DateTime? issueEndDate { get; set; }

        [Required]
        public byte isActive { get; set; } = 0;

        public byte? canBeDeactivated { get; set; }

        public DateTime? redemptionStartDate { get; set; }

        public DateTime? redemptionEndDate { get; set; }

        [Column(TypeName = "decimal(10,2)")] 
        public decimal? minimumActivationAmount { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? maximumTransactionAmount { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? maximumCardBalance { get; set; }

        [Required]
        public byte isVirtualGiftCard { get; set; } = 0;

        [MaxLength(45)]
        public string? defaultActivationStoreId { get; set; }

        public DateTime? devalueDate { get; set; }

        [Column(TypeName = "text")]
        public string? programTypeDescription { get; set; }

        public byte? allowCreditBalance { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? creditLimit { get; set; }

        [MaxLength(45)]
        public string? cardTypeCategoryId { get; set; }

        [Required]
        public int length { get; set; } = 0;

        public byte? isLegacy { get; set; }

        [Required]
        public DateTime? createdAt { get; set; }

        public DateTime? updatedAt { get; set; }

        public byte? isPromo { get; set; }

        [Required]
        [MaxLength(100)]
        public string emailTemplateId { get; set; } = string.Empty;

        //Navigation property - Children
        public virtual ICollection<Card> Cards { get; set; } =
            new List<Card>();
    }
}
