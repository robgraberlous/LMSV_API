namespace LMSV.API.Models
{
    public class CardDto
    {
        public long Id { get; set; }
        public decimal Balance { get; set; } = 0.00M;
        public string cardNumber { get; set; } = string.Empty;
        public string? pin { get; set; }
        public string cardTypeId { get; set; } = string.Empty;
        public int active { get; set; } = 0;
        public DateTime? dateActivated { get; set; }
        public DateTime? dateDeactivated { get; set; }
        public string? customerId { get; set; }
        public string? name { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}
