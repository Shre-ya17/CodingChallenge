using System;
using System.Collections.Generic;
using DAO; 
using Entities; 

namespace MainModule
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IPolicyService policyService = new InsuranceServiceImpl();

          
            var newPolicy = new Policy(
                1,                          
                "Health Insurance",            
                "Covers health expenses",      
                500.00m,                      
                "Covers hospitalization",    
                DateTime.Now,                  
                DateTime.Now.AddYears(1),        
                "Active"                        
            );


            bool created = policyService.CreatePolicy(newPolicy);
            Console.WriteLine("Policy Created: " + created);

            var retrievedPolicy = policyService.GetPolicy(1);
            Console.WriteLine("Retrieved Policy: " + retrievedPolicy.ToString());

            newPolicy.Status = "Inactive"; 
            bool updated = policyService.UpdatePolicy(newPolicy);
            Console.WriteLine("Policy Updated: " + updated);

 
            IEnumerable<Policy> allPolicies = policyService.GetAllPolicies();
            Console.WriteLine("All Policies:");
            foreach (var policy in allPolicies)
            {
                Console.WriteLine(policy.ToString());
            }

            bool deleted = policyService.DeletePolicy(1);
            Console.WriteLine("Policy Deleted: " + deleted);
        }
    }
}
