using Entities;
using System.Collections.Generic;

namespace DAO
{
    public class InsuranceServiceImpl : IPolicyService
    {
        public bool CreatePolicy(Policy policy)
        {
            
            return true; 
        }

        public Policy GetPolicy(int policyId)
        {
            
            return new Policy(); 
        }

        public IEnumerable<Policy> GetAllPolicies()
        {
     
            return new List<Policy>(); 
        }

        public bool UpdatePolicy(Policy policy)
        {
      
            return true; 
        }

        public bool DeletePolicy(int policyId)
        {
            
            return true; 
        }
    }
}
