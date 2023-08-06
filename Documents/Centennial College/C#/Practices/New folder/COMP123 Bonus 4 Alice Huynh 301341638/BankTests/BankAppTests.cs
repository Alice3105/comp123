using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BankApp;

namespace BankTests
{
    [TestClass]
    public class BankAppTests
    {
        [TestMethod]
        [Owner("Alice Huynh")]
        [TestCategory("Important")]
        public void Deposit_ValidAmount_UpdatesBalance()
        {
            //Arrange
            double deposit = 1000, balance = 2000, expect = 3000;
            BankAccount anAccount = new BankAccount(balance);

            //Act
            anAccount.Deposit(deposit);
            double actual = anAccount.Balance;

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        [Owner("Alice Huynh")]
        [TestCategory("Important")]
        public void Withdraw_ValidAmount_UpdatesBalance()
        {
            //Arrange
            double withdraw = 1000, balance = 2000, expect = 1000;
            BankAccount anAccount = new BankAccount(balance);

            //Act
            anAccount.Withdraw(withdraw);
            double actual = anAccount.Balance;

            //Assert
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        [Owner("Alice Huynh")]
        [TestCategory("Very Important")]
        //Assert
        [ExpectedException(typeof(ArgumentOutOfRangeException))] 
        public void Withdraw_MoreThan_Balance()
        {
            //Arrange
            double withdraw = 2000, balance = 1000;
            BankAccount anAccount = new BankAccount(balance);
           
             //Act
             anAccount.Withdraw(withdraw);
        }

        [TestMethod]
        [Owner("Alice Huynh")]
        [TestCategory("Very Important")]
        //Assert
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Withdraw_ZeroOrNegative_Balance()
        {
            //Arrange
            double withdraw = 2000, zeroBalance = 0, negativeBalance = -100;
            BankAccount zeroAccount = new BankAccount(zeroBalance);
            BankAccount negativeAccount = new BankAccount(negativeBalance);

            //Act
            zeroAccount.Withdraw(withdraw);
        }

        [TestMethod]
        [Owner("Alice Huynh")]
        [TestCategory("Very Important")]
        //Assert
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Deposit_ZeroOrNegative_Balance()
        {
            //Arrange
            double zeroDeposit = 0, negativeDeposit = -100, balance = 1000;
            BankAccount zeroAccount = new BankAccount(balance);
            BankAccount negativeAccount = new BankAccount(balance);

            //Act
            zeroAccount.Deposit(zeroDeposit);
            zeroAccount.Deposit(negativeDeposit);
        }
    }
}
