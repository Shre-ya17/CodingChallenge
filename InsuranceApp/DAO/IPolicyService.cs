using Entities;
using System.Collections.Generic;

public interface IPolicyService
{
    bool CreatePolicy(Policy policy);
    Policy GetPolicy(int policyId);
    IEnumerable<Policy> GetAllPolicies(); // Ensure this method is defined correctly
    bool UpdatePolicy(Policy policy);
    bool DeletePolicy(int policyId);
}
