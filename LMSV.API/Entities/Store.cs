using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSV.API.Entities
{
    [Table("str_store")]
    public class Store
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int storeId { get; set; }

        [Required]
        [MaxLength(20)]
        public string storeNumber { get; set; } = string.Empty;

        [Required]
        [MaxLength(100)]
        public string storeName { get; set; } = string.Empty;

        public DateTime? openDate { get; set; }

        public DateTime? closedDate { get; set; }

        [Required]
        public bool showReporting { get; set; } = false;

        [Required]
        public DateTime? compareDate { get; set; }

        [Required]
        public bool isClosed { get; set; } = false;

        public DateTime? createDate { get; set; }

        [Required]
        public DateTime validFrom { get; set; }

        [Required]
        public DateTime validTo { get; set; }

        public string? legacyStoreCode { get; set; }

        public string? storePhone { get; set; }

        //Navigation Property - Parents

        //Navigation property - Children
        public virtual ICollection<Transaction> Transactions { get; set; } =
            new List<Transaction>();

    }
}
