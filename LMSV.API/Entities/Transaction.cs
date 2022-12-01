using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSV.API.Entities
{
    [Table("transactions")]
    public class Transaction
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public decimal amount { get; set; } = 0.00M;

        [Required]
        [MaxLength(45)]
        public string type { get; set; } = string.Empty;

        [MaxLength(150)]
        public string? reason { get; set; }

        [MaxLength(45)]
        public string? accountId { get; set; }

        [Required]
        public long cardId { get; set; } = 0L;

        [Required]
        public DateTime? createdAt { get; set; }

        [Required]
        public DateTime? transactionDate { get; set; }

        [MaxLength(150)]
        public string? message { get; set; }

        [MaxLength(255)]
        public string? terminalId { get; set; }

        [Required]
        public int storeId { get; set; } = 0;

        [Required]
        public Guid EmsUserId { get; set; }

        [Required]
        public int ClientId { get; set; }

        //Navigation Property - Parents
        [ForeignKey("cardId")]
        public Card? Card { get; set; }

        public EmsUser? EmsUser { get; set; }

        public Store? Store { get; set; }
    }
}
