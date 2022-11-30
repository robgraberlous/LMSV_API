﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LMSV.API.Entities
{
    [Table("users", Schema = "emsBackend")]
    public class EmsUser
    {
        [Required]
        public short active { get; set; } = 0;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
//        [Column(TypeName = "guid")]
        public Guid Id { get; set; }// = string.Empty;

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
