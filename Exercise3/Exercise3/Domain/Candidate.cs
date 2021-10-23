using System;

namespace Exercise3.Domain
{
    class Candidate : Person
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
        
        DismissalReason [] dismissalReasonArray = (DismissalReason[])Enum.GetValues(typeof(DismissalReason));



        public void Qwer()
        {
            var values = Enum.GetValues(typeof(DismissalReason));
            Console.WriteLine(values);
        }
            
         

    }
}