using System;

namespace LoanEMIPreview
{
    public class LoanService
    {
        public void CalculateEMI(Loan loan)
        {
            Console.Write("Enter Applicant Name : ");
            loan.ApplicantName = Console.ReadLine();

            // Loan Amount
            while (true)
            {
                Console.Write("Enter Loan Amount : ");

                if (double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
                {
                    loan.LoanAmount = amount;
                    break;
                }

                Console.WriteLine("Invalid Loan Amount.");
            }

            // Interest Rate
            while (true)
            {
                Console.Write("Enter Annual Interest Rate (%) : ");

                if (double.TryParse(Console.ReadLine(), out double rate) && rate >= 0)
                {
                    loan.InterestRate = rate;
                    break;
                }

                Console.WriteLine("Invalid Interest Rate.");
            }

            // Duration
            while (true)
            {
                Console.Write("Enter Loan Duration (Years) : ");

                if (int.TryParse(Console.ReadLine(), out int years) && years >= 1)
                {
                    loan.Duration = years;
                    break;
                }

                Console.WriteLine("Invalid Duration.");
            }

            double principal = loan.LoanAmount;

            double monthlyRate = (loan.InterestRate / 100) / 12;

            int months = loan.Duration * 12;

            if (monthlyRate == 0)
            {
                loan.EMI = principal / months;
            }
            else
            {
                loan.EMI = principal * monthlyRate *
                           Math.Pow(1 + monthlyRate, months) /
                           (Math.Pow(1 + monthlyRate, months) - 1);
            }

            loan.TotalRepayment = loan.EMI * months;

            loan.TotalInterest = loan.TotalRepayment - principal;

            Console.WriteLine("\nEMI calculated successfully.");
        }

        public void DisplayLoanSummary(Loan loan)
        {
            if (loan.LoanAmount == 0)
            {
                Console.WriteLine("No loan details available.");
                return;
            }

            Console.WriteLine();
            Console.WriteLine("========== Loan Summary ==========");

            Console.WriteLine($"Applicant Name     : {loan.ApplicantName}");
            Console.WriteLine($"Loan Amount        : {loan.LoanAmount:F2}");
            Console.WriteLine($"Interest Rate      : {loan.InterestRate:F2}%");
            Console.WriteLine($"Duration           : {loan.Duration} Years");
            Console.WriteLine($"Monthly EMI        : {loan.EMI:F2}");
            Console.WriteLine($"Total Interest     : {loan.TotalInterest:F2}");
            Console.WriteLine($"Total Repayment    : {loan.TotalRepayment:F2}");
        }

        public void ClearLoan(Loan loan)
        {
            loan.ApplicantName = "";
            loan.LoanAmount = 0;
            loan.InterestRate = 0;
            loan.Duration = 0;
            loan.EMI = 0;
            loan.TotalInterest = 0;
            loan.TotalRepayment = 0;

            Console.WriteLine("Loan details cleared successfully.");
        }
        //public void CompareLoans()
        //{
        //    Loan loan1 = new Loan();
        //    Loan loan2 = new Loan();

        //    Console.WriteLine("\n========== Enter Details for Loan 1 ==========");
        //    CalculateEMI(loan1);

        //    Console.WriteLine("\n========== Enter Details for Loan 2 ==========");
        //    CalculateEMI(loan2);

        //    Console.WriteLine("\n========== Loan 1 Summary ==========");
        //    DisplayLoanSummary(loan1);

        //    Console.WriteLine("\n========== Loan 2 Summary ==========");
        //    DisplayLoanSummary(loan2);

        //    Console.WriteLine("\n========== Comparison ==========");

        //    // EMI Comparison
        //    if (loan1.EMI < loan2.EMI)
        //        Console.WriteLine($"{loan1.ApplicantName} has the lower EMI.");
        //    else if (loan2.EMI < loan1.EMI)
        //        Console.WriteLine($"{loan2.ApplicantName} has the lower EMI.");
        //    else
        //        Console.WriteLine("Both loans have the same EMI.");

        //    // Interest Comparison
        //    if (loan1.TotalInterest < loan2.TotalInterest)
        //        Console.WriteLine($"{loan1.ApplicantName} has lower total interest.");
        //    else if (loan2.TotalInterest < loan1.TotalInterest)
        //        Console.WriteLine($"{loan2.ApplicantName} has lower total interest.");
        //    else
        //        Console.WriteLine("Both loans have the same total interest.");

        //    // Repayment Comparison
        //    if (loan1.TotalRepayment < loan2.TotalRepayment)
        //        Console.WriteLine($"{loan1.ApplicantName} is the cheaper overall loan.");
        //    else if (loan2.TotalRepayment < loan1.TotalRepayment)
        //        Console.WriteLine($"{loan2.ApplicantName} is the cheaper overall loan.");
        //    else
        //        Console.WriteLine("Both loans cost the same.");
        //}
    }
}