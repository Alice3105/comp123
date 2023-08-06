using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    public class BankAccount
    {
        private double balance;
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        public double Balance { get { return balance; } }

        public void Withdraw(double amount)
        {

            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException("Withdrawal cannot be greater than the Balance");
            }
            else if (Balance == 0 || Balance < 0)
            {
                throw new ArgumentOutOfRangeException("Balance cannot be 0 nor negative");
            }
            else
            {
                balance -= amount;
            }
        }

        public void Deposit(double amount)
        {

            if (amount == 0 || amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount cannot be 0 nor negative");
            }
            else
            {
                balance += amount;
            }
        }

        public BankAccount(double balance, int accountNumber = 000, string customerName = "N/A")
        {
            this.balance = balance;
            AccountNumber = accountNumber;
            CustomerName = customerName;
        }

        public override string ToString()
        {
            return $"Balance: {Balance:C3}\n Account Number: {AccountNumber}\n Customer Name: {CustomerName}\n ";
        }
    }
}
