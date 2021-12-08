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
        Other,
        Null
    }
    public class Candidate : Person, IDisplayable
    { 
        private int dismissalReasonInt;
        private string _dismissalReason;
       public Candidate()
        {
            Random rnd = new Random();
            dismissalReasonInt = rnd.Next(0, 7);
            _dismissalReason = Convert.ToString((DismissalReason) dismissalReasonInt);
        }
       public void ShowPersonInfo()
        {
            if (dismissalReasonInt != 7)
            {
                Console.WriteLine($"Hello, I am {FullName}. I want to be a {JobTitle} ({JobDescription}) with a salary from {JobSalary}. I quit my previous job for a reason of {_dismissalReason}");
            }
            else
            {
                Console.WriteLine($"Hello, I am {FullName}. I want to be a {JobTitle} ({JobDescription}) with a salary from {JobSalary}. I haven't worked anywhere before.");
            }
        }
    }
}