using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount anAccount = new BankAccount(20_000, 301341, "Margo Robbie");
            Console.WriteLine(anAccount.ToString());

            Console.WriteLine("Please enter an amount to deposit.");
            double deposit = Convert.ToDouble(Console.ReadLine());
            anAccount.Deposit(deposit);

            Console.WriteLine("Please enter an amount to withdraw.");
            double withdraw = Convert.ToDouble(Console.ReadLine());
            anAccount.Withdraw(withdraw);

            Console.WriteLine(anAccount.ToString());

        }
    }
}
