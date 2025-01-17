namespace InsurancePolicies.Models
{
    public class InsurancePolicy
    {

        public int Id { get; set; }
        public string PolicyHolderName { get; set; }
        public string PolicyNumber { get; set; }
        public string PolicyType { get; set; }
        public decimal PremiumAmount { get; set; }
        public bool IsActive { get; set; }

    }
}
