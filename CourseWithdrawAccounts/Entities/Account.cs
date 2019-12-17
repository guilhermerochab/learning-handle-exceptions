using System;
using CourseWithdrawAccounts.Entities.Exceptions;

namespace CourseWithdrawAccounts.Entities {
    public class Account {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() {
        }

        public Account(int number, string holder, double withdrawLimit) {
            Number = number;
            Holder = holder;
            Balance = 0.00;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double ammount) {
            Balance += ammount;
        }

        public void Withdraw(double ammount) {
            if (ammount > WithdrawLimit) {
                throw new DomainException("The amount exceeds withdraw limit");
            }
            if (ammount >
                Balance) {
                throw new DomainException("Not enough balance");
            }

            Balance -= ammount;
        }
    }
}
