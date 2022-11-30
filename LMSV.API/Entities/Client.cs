using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LMSV.API.Entities
{
    [Table("client")]
    public class Client
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }// = string.Empty;

        [Required]
        [MaxLength(255)]
        public string? name { get; set; }

        [Required]
        [MaxLength(255)]
        public string? hash { get; set; }

        [Required]
        public byte isAdmin { get; set; } = 0;

        [MaxLength(100)]
        public string? apiKey { get; set; }

        [MaxLength(100)]
        public string? secret { get; set; }

        //Navigation property - Children
        public virtual ICollection<Transaction> Transactions { get; set; } =
            new List<Transaction>();

    }
}
