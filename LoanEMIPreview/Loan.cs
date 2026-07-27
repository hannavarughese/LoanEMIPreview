using System;

namespace LoanEMIPreview
{
    public class Loan
    {
        public string ApplicantName { get; set; }
        public double LoanAmount { get; set; }
        public double InterestRate { get; set; }     // Annual %
        public int Duration { get; set; }            // Years

        public double EMI { get; set; }
        public double TotalInterest { get; set; }
        public double TotalRepayment { get; set; }
    }
}