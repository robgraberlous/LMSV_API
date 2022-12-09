using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMSV.API.Entities
{
    [Table("users", Schema = "emsBackend")]
    public class EmsUser
    {
        [Required]
        public Int16 active { get; set; } = 0;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public DateTime? created_at { get; set; }

        [Required]
        public DateTime? updated_at { get; set; }

        [MaxLength(255)]
        public string? name { get; set; }

        [MaxLength(255)]
        public string? email { get; set; }

        [MaxLength(255)]
        public string? phone { get; set; }

        [MaxLength(255)]
        public string? emailVerified { get; set; }

        [MaxLength(255)]
        public string? image { get; set; }

    }
}
