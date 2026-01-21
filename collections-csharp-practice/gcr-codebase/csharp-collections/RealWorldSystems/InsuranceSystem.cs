using System;
using System.Collections.Generic;
using System.Linq;
public class InsuranceSystem
{
    public class Policy
    {
        public string PolicyNumber { get; set; }
        public string CoverageType { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
    private HashSet<string> _uniquePolicyNumbers = new HashSet<string>();
    private SortedDictionary<DateTime, List<Policy>> _policiesByExpiry = new SortedDictionary<DateTime, List<Policy>>();
    private List<Policy> _insertionOrderedPolicies = new List<Policy>();
    public void AddPolicy(Policy policy)
    {
        if (_uniquePolicyNumbers.Contains(policy.PolicyNumber))
        {
            Console.WriteLine($"Duplicate Policy Detected: {policy.PolicyNumber}");
            return;
        }
        _uniquePolicyNumbers.Add(policy.PolicyNumber);
        _insertionOrderedPolicies.Add(policy);
        if (!_policiesByExpiry.ContainsKey(policy.ExpiryDate))
	{
            _policiesByExpiry[policy.ExpiryDate] = new List<Policy>();
	}
        _policiesByExpiry[policy.ExpiryDate].Add(policy);
    }
    public List<Policy> GetPoliciesExpiringSoon(int days)
    {
        DateTime limit = DateTime.Now.AddDays(days);
        List<Policy> result = new List<Policy>();

        foreach (var kvp in _policiesByExpiry)
        {
            if (kvp.Key <= limit)
                result.AddRange(kvp.Value);
            else
                break;
        }
        return result;
    }
    public static void Main(string[] args)
    {
        InsuranceSystem system = new InsuranceSystem();
        system.AddPolicy(new Policy { PolicyNumber = "POL-101", CoverageType = "Health", ExpiryDate = DateTime.Now.AddDays(10) });
        system.AddPolicy(new Policy { PolicyNumber = "POL-102", CoverageType = "Auto", ExpiryDate = DateTime.Now.AddDays(45) });
        system.AddPolicy(new Policy { PolicyNumber = "POL-103", CoverageType = "Home", ExpiryDate = DateTime.Now.AddDays(5) });
        system.AddPolicy(new Policy { PolicyNumber = "POL-101", CoverageType = "Health", ExpiryDate = DateTime.Now.AddDays(20) }); 
        Console.WriteLine("\nPolicies expiring within 30 days:");
        List<Policy> expiringSoon = system.GetPoliciesExpiringSoon(30);
        foreach (var policy in expiringSoon)
        {
            Console.WriteLine($"{policy.PolicyNumber} ({policy.CoverageType}) - Expires: {policy.ExpiryDate.ToShortDateString()}");
        }
    }
}