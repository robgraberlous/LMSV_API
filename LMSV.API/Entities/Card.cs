using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSV.API.Entities
{
    [Table("card")]
    public class Card
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public decimal Balance { get; set; } = 0.00M;

        [Required]
        [MaxLength(45)]
        public string cardNumber { get; set; } = string.Empty;

        [MaxLength(45)]
        public string? pin { get; set; }

        [Required]
        public string cardTypeId { get; set; } = string.Empty;

        [Required]
        public byte active { get; set; } = 0;

        public DateTime? dateActivated { get; set; }

        public DateTime? dateDeactivated { get; set; }

        [MaxLength(45)]
        public string? customerId { get; set; }

        [MaxLength(200)]
        public string? name { get; set; }

        [Required]
        public DateTime? createdAt { get; set; }

        public DateTime? updatedAt { get; set; }
    }
}
