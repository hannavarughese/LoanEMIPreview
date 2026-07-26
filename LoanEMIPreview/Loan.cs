using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanEMIPreview
{
    public class Loan
    {
        public string ApplicantName { get; set; }
        public double LoanAmount { get; set; }
        public double InterestRate { get; set; }
        public int Duration { get; set; }
        public double EMI { get; set; }
        public double TotalInterest { get; set; }
        public double TotalRepayment { get; set; }//emi pai per month * duration

    }
}
