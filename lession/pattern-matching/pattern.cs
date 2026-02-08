// void calulator() {}

// string bankRecords = """
//     DEPOSIT,   10000, Initial balance
//     DEPOSIT,     500, regular deposit
//     WITHDRAWAL, 1000, rent
//     DEPOSIT,    2000, freelance payment
//     WITHDRAWAL,  300, groceries
//     DEPOSIT,     700, gift from friend
//     WITHDRAWAL,  150, utility bill
//     DEPOSIT,    1200, tax refund
//     WITHDRAWAL,  500, car maintenance
//     DEPOSIT,     400, cashback reward
//     WITHDRAWAL,  250, dining out
//     DEPOSIT,    3000, bonus payment
//     WITHDRAWAL,  800, loan repayment
//     DEPOSIT,     600, stock dividends
//     WITHDRAWAL,  100, subscription fee
//     DEPOSIT,    1500, side hustle income
//     WITHDRAWAL,  200, fuel expenses
//     DEPOSIT,     900, refund from store
//     WITHDRAWAL,  350, shopping
//     DEPOSIT,    2500, project milestone payment
//     WITHDRAWAL,  400, entertainment
//     """;

// decimal total = 0;
// var reader = new StringReader(bankRecords);

// string? line;
// while((line = reader.ReadLine()) is not null)
// {
//     if(string.IsNullOrWhiteSpace(line)) continue;

//     string[] parts = line.Split(',');
//     // [WITHDRAWAL, 1000, rent]
//     string behavior = parts[0];
//     decimal amount = Decimal.Parse(parts[1]);
//     string status = parts[2];

//     if(behavior.ToUpper() is "WITHDRAWAL")
//     {
//         total -= amount;
//     } else
//     {
//         total += amount;
//     }
//     // can be replace with switch
//     // total += amount switch 
//     // {
//     //     (TransactionType.Deposit, var amount) => amount,
//     //     (TransactionType.Withdrawal, var amount) => -amount,
//     //     _=> 0.0, // catch every case remaining
//     // }

// currentBalance = 0.0;

// foreach (var transaction in TransactionRecordType(bankRecords))
// {
//     currentBalance += transaction switch
//     {
//         Deposit d => d.Amount,
//         Withdrawal w => -w.Amount,
//         _ => 0.0,
//     };
//     Console.WriteLine($" {transaction} => New Balance: {currentBalance}");
// }

// static IEnumerable<object?> TransactionRecordType(string inputText)
// {
//     var reader = new StringReader(inputText);
//     string? line;
//     while ((line = reader.ReadLine()) is not null)
//     {
//         string[] parts = line.Split(',');

//         string? transactionType = parts[0]?.Trim();
//         if (double.TryParse(parts[1].Trim(), out double amount))
//         {
//             // Update the balance based on transaction type
//             if (transactionType?.ToUpper() is "DEPOSIT")
//                 yield return new Deposit(amount, parts[2]);
//             else if (transactionType?.ToUpper() is "WITHDRAWAL")
//                 yield return new Withdrawal(amount, parts[2]);
//         }
//     }

    
// }


// }

// Console.WriteLine(total);

// public record Deposit(double Amount, string description);
// public record Withdrawal(double Amount, string description);

