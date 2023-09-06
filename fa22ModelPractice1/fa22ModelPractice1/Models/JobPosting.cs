//add using directive for the data annotations
using System.ComponentModel.DataAnnotations;

namespace fa22ModelPractice1.Models
{
      public class JobPosting
    {
        //create a named constant for number of months
        //named constants cannot be changed while the code is running
        public const Int32 NUMBER_OF_MONTHS = 12; //this company runs all 12 months

        //create a unique identifier for the job posting
        [Display(Name = "Job Posting ID:")]
        public Int32 JobPostingID { get; set; }


        //create a name for the job posting
        [Display(Name = "Job Posting Name:")]
        public String JobPostingName { get; set; }

       
        //create a property for the monthly salary
        [Display(Name = "Monthly Salary:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal MonthlySalary { get; set; }

        
        //create a property for the annual bonus
        [Display(Name = "Annual Bonus:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal AnnualBonus { get; set; }
        
        
        //create a property for the AnnualSalary
        [Display(Name = "Annual Salary:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        //the private set is here because this property is read-only
        public Decimal AnnualSalary { get; private set; }

        //this is one way to calculate a value that depends on other
        //properties.  This technique will calculate the and store the value into
        //a separate method.  This method only needs to be called once
        public void CalculateAnnualSalary()
        { 
           //multiply the monthly salary by the number of months
           AnnualSalary = MonthlySalary * NUMBER_OF_MONTHS;
        }

        //this is the other way to calculate a value that depends on other
        //properties.  This technique will calculate the value every time that
        //TotalSalary is referenced. This is best for simple or volatile calculations
        [Display(Name = "Total Annual Compensation:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal TotalAnnualCompensation
        { 
            get { return AnnualSalary + AnnualBonus; }
        }
    }
}
