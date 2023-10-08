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
    public class CheckingTests
    {
        [TestMethod()]
        public void DepositWithSuccess()
        {
            //arrange
            Checking testCheckAcc = new Checking(1000);
            double DepositAmount = 1000;
            double expectedResult = 2000;

            //act
           testCheckAcc.Deposit(DepositAmount);

            //assert
            Assert.AreEqual(expectedResult, testCheckAcc.Balance);
        }

        [TestMethod()]
        public void DepositWithOutSuccess()
        {
            //arrange
            Checking testCheckAcc = new Checking(1000);
            double DepositAmount = -5;
            double expectedResult = 1000;

            //act
            testCheckAcc.Deposit(DepositAmount);

            //assert
            Assert.AreEqual(expectedResult, testCheckAcc.Balance);

        }

        [TestMethod()]
        public void WithdrawWithSuccess()
        {
            //arrange
            Checking testCheckAcc = new Checking(1000);
            double WithdrawAmount = 600;
            double expectedResult = 400;

            //act
            testCheckAcc.Withdraw(WithdrawAmount);

            //assert
            Assert.AreEqual(expectedResult, testCheckAcc.Balance);
        }

        [TestMethod()]
        public void WithdrawWithOutSuccess() //with overdraft 15
        {
            //arrange
            Checking testCheckAcc = new Checking(1000);
            double WithdrawAmount = 1100;
            //double expectedResult = 985;

            //act
            testCheckAcc.Withdraw(WithdrawAmount);
            double expectedResult = testCheckAcc.Balance;

            //assert
            Assert.AreEqual(expectedResult, testCheckAcc.Balance);
        }
    }
}