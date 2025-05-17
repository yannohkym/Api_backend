namespace InsurancePolicies.Models
{
    public class InsurancePolicy
    {

        public int Id { get; set; }
        public required string PolicyHolderName { get; set; }
        public required string PolicyNumber { get; set; }
        public required string PolicyType { get; set; }
        public decimal PremiumAmount { get; set; }
        public bool IsActive { get; set; }

    }
}
