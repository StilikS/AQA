using System;

namespace Exercise3.Domain
{
    enum DismissalReason
    {
        FamilyReasons,
        ProfessionalGrowthLack,
        LowSalary,
        BadTeamMicroclimate,
        LackManagementUnderstanding,
        Other
    }
    
    class Candidate : Person, IDisplayable
    {
        public DismissalReason? DismissalReason = null;

        //public Candidate() /*(string FirstName, string LastName): base(FirstName, LastName)*/
        //{
        //}*/
        
        public void ShowPersonInfo()
        {
            if (DismissalReason != null)
            {
                Console.WriteLine($"Hello, I am {FullName}. I want to be a {JobTitle} ({JobDescription}) with a salary from {JobSalary}. I quit my previous job for a reason of {DismissalReason}");
            }
            else
            {
                Console.WriteLine($"Hello, I am {FullName}. I want to be a {JobTitle} ({JobDescription}) with a salary from {JobSalary}. I haven't worked anywhere before.");
            }
            
        }
    
    }
}