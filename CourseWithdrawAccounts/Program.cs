using System;
using System.Globalization;
using CourseWithdrawAccounts.Entities;
using CourseWithdrawAccounts.Entities.Exceptions;

namespace CourseWithdrawAccounts {
    class Program {
        static void Main(string[] args) {

            try {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account account = new Account(number, holder, limit);
                account.Deposit(initialDeposit);
                Console.WriteLine();

                Console.Write("Enter amount for withdraw: ");
                double withdrawAmmount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(withdrawAmmount);
                Console.Write("New balance: ");
                Console.WriteLine(account.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
            catch (DomainException e) {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
            catch (Exception e) {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}