using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_Unit_Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Unit_Testing.Tests
{
    [TestClass()]
    public class SavingsTests
    {
        [TestMethod()]
        public void DepositWithSuccess()
        {
            //arrange
            Savings testSaveAcc = new Savings(2563);
            double DepositAmount = 1400;

            //act
            testSaveAcc.Deposit(DepositAmount);
            double expectedResult = testSaveAcc.Balance;

            //assert
            Assert.AreEqual(expectedResult, testSaveAcc.Balance);
        }

        [TestMethod()]
        public void DepositWithOutSuccess()
        {
            //arrange
            Savings testSaveAcc = new Savings(2000);
            double DepositAmount = -5;

            //act
            testSaveAcc.Deposit(DepositAmount);
            double expectedResult = testSaveAcc.Balance;

            //assert
            Assert.AreEqual(expectedResult, testSaveAcc.Balance);

        }

        [TestMethod()]
        public void WithdrawWithSuccess()
        {
            //arrange
            Savings testSaveAcc = new Savings(2340);
            double WithdrawAmount = 600;

            //act
            testSaveAcc.Withdraw(WithdrawAmount);
            double expectedResult = testSaveAcc.Balance;

            //assert
            Assert.AreEqual(expectedResult, testSaveAcc.Balance);
        }

        [TestMethod()]
        public void WithdrawWithOutSuccess() 
        {
            //arrange
            Savings testSaveAcc = new Savings(2000);
            double WithdrawAmount = -5;

            //act
            testSaveAcc.Withdraw(WithdrawAmount);
            double expectedResult = testSaveAcc.Balance;

            //assert
            Assert.AreEqual(expectedResult, testSaveAcc.Balance);
        }
    }
}