using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEMIPreview
{
    public class LoanService
    {
        public void CalculateEMI(Loan loan)
        {
            Console.WriteLine("Enter Loan Amount  : ");
            string input = Console.ReadLine();

            loan.LoanAmount = input != null ? Convert.ToDouble(input) : 0;
            Console.WriteLine("Enter Interest Rate : ");
            string rate = Console.ReadLine();
            loan.InterestRate = rate != null ? Convert.ToDouble(rate) : 0;
            Console.WriteLine("Enter Duration (in months) : ");
            string duration = Console.ReadLine();
            loan.Duration = duration != null ? Convert.ToInt32(duration) : 0;
            loan.EMI = (loan.LoanAmount * loan.InterestRate * Math.Pow(1 + loan.InterestRate, loan.Duration)) / (Math.Pow(1 + loan.InterestRate, loan.Duration) - 1);
            loan.TotalInterest = loan.EMI * loan.Duration - loan.LoanAmount;
            loan.TotalRepayment = loan.LoanAmount + loan.TotalInterest;

            Console.WriteLine("emi"+loan.EMI+"Total Interest: "+loan.TotalInterest+"Total Repayment: "+loan.TotalRepayment);
        }

        public void DisplayLoanSummary(Loan loan)
        {
            Console.WriteLine("Loan Summary");
            Console.WriteLine($"Applicant Name: {loan.ApplicantName}");
            Console.WriteLine($"Loan Amount: {loan.LoanAmount}");
            Console.WriteLine($"Interest Rate: {loan.InterestRate}");
            Console.WriteLine($"Duration: {loan.Duration}");
            Console.WriteLine($"EMI: {loan.EMI}");
            Console.WriteLine($"Total Interest: {loan.TotalInterest}");
            Console.WriteLine($"Total Repayment: {loan.TotalRepayment}");
        }

        public void ClearLoan(Loan loan)
        {
            Console.WriteLine("Loan details cleared.");
        }
    }
}
