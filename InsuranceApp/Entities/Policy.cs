using System;

namespace Entities
{
    public class Policy
    {
        public int PolicyId { get; set; }
        public string PolicyName { get; set; }
        public string Description { get; set; }
        public decimal PremiumAmount { get; set; }
        public string CoverageDetails { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Status { get; set; }

       
        public Policy() { }

        
        public Policy(int policyId, string policyName, string description, decimal premiumAmount,
                      string coverageDetails, DateTime startDate, DateTime expiryDate, string status)
        {
            PolicyId = policyId;
            PolicyName = policyName;
            Description = description;
            PremiumAmount = premiumAmount;
            CoverageDetails = coverageDetails;
            StartDate = startDate;
            ExpiryDate = expiryDate;
            Status = status;
        }

        public override string ToString()
        {
            return $"Policy ID: {PolicyId}, Name: {PolicyName}, Premium: {PremiumAmount:C}, Status: {Status}";
        }
    }
}
