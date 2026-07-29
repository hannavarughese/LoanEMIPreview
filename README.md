# Loan EMI Preview Calculator

A menu-driven C# .NET Console Application that allows users to estimate loan repayments before applying for a loan. The application calculates the monthly EMI, total interest, and total repayment amount while validating user inputs.

---

## Features

- Calculate Monthly EMI
- View Loan Summary
- Clear Entered Loan Details
- Menu-Driven Console Interface
- Input Validation
- Displays monetary values with two decimal places

---

## Business Rules

- Loan amount must be greater than zero.
- Interest rate cannot be negative.
- Loan duration must be at least one year.

---

## Technologies Used

- C#
- .NET Console Application
- Visual Studio

---

## Project Structure

```
LoanEMIPreview
│
├── Program.cs         // Menu and application flow
├── Loan.cs            // Loan model
├── LoanService.cs     // EMI calculations and validation
└── README.md
```

---

## EMI Formula

Monthly Interest Rate

```
r = Annual Interest Rate / (12 × 100)
```

Number of Monthly Payments

```
n = Loan Duration × 12
```

EMI Formula

```
EMI = P × r × (1 + r)^n
      -------------------
      ((1 + r)^n - 1)
```

Where:

- P = Loan Amount
- r = Monthly Interest Rate
- n = Number of Monthly Payments

---

## Sample Output

```
========= Loan EMI Preview =========

1. Calculate EMI
2. View Loan Summary
3. Clear Details
4. Exit

Enter Choice: 1

Applicant Name : Hanna
Loan Amount : 500000
Interest Rate : 8.5
Loan Duration : 5

Monthly EMI      : 10258.73
Total Interest   : 115523.80
Total Repayment  : 615523.80
```

---
## Test Cases

<img width="245" height="293" alt="Testcase2" src="https://github.com/user-attachments/assets/47dd099c-2fc2-40ff-9bb2-48b7631d3a88" />
<img width="262" height="350" alt="Testcase1" src="https://github.com/user-attachments/assets/13ddc7f0-6813-4fe5-9e14-76cf3e9c097a" />

## Validation

- Invalid menu choices are handled.
- Loan amount must be greater than zero.
- Interest rate cannot be negative.
- Loan duration must be at least one year.
- Application continues until Exit is selected.

---

## Future Enhancement

- Compare two different loan options.
