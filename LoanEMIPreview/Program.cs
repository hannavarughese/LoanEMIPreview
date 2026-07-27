using System;

namespace LoanEMIPreview
{
    class Program
    {
        static void Main(string[] args)
        {
            Loan loan = new Loan();

            LoanService service = new LoanService();

            int choice;

            do
            {
                Console.WriteLine();
                Console.WriteLine("========== Loan EMI Preview ==========");
                Console.WriteLine("1. Calculate EMI");
                Console.WriteLine("2. View Loan Summary");
                Console.WriteLine("3. Clear Details");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice : ");

                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid Choice");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        service.CalculateEMI(loan);
                        break;

                    case 2:
                        service.DisplayLoanSummary(loan);
                        break;

                    case 3:
                        service.ClearLoan(loan);
                        break;

                    case 4:
                        Console.WriteLine("Thank you!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            } while (choice != 4);
        }
    }
}