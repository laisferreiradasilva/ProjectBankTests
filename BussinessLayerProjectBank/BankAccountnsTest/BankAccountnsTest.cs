using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankAccountnsTest
{
    [TestClass]
    public class BankAccountnsTest
    {
        [TestMethod]
        public void BankAccounts_Credit_Success()
        {
            BussinessLayerProjectBank.BankAccountns bankAccountns = new BussinessLayerProjectBank.BankAccountns();
            bool informedValue = bankAccountns.Credit(10);
            Assert.IsTrue(informedValue);
        }
        [TestMethod]
        public void BankAccounts_Credit_Failure()
        {
            BussinessLayerProjectBank.BankAccountns bankAccountns = new BussinessLayerProjectBank.BankAccountns();
            bool informedValue = bankAccountns.Credit(-15);
            Assert.IsFalse(informedValue);
        }
        [TestMethod]
        public void BankAccounts_Debit_Success()
        {
            BussinessLayerProjectBank.BankAccountns bankAccountns = new BussinessLayerProjectBank.BankAccountns();
            bool informedValue = bankAccountns.Debit(300.05);
            Assert.IsTrue(informedValue);
        }
        [TestMethod]
        public void BankAccountns_Debit_Failure()
        {
            BussinessLayerProjectBank.BankAccountns bankAccountns = new BussinessLayerProjectBank.BankAccountns();
            bool informedValue = bankAccountns.Debit(-300.05);
            Assert.IsFalse(informedValue);
        }
        [TestMethod]
        public void BankAccountns_Balance_Success()
        {
            BussinessLayerProjectBank.BankAccountns bankAccountns = new BussinessLayerProjectBank.BankAccountns();
            double informedValue = bankAccountns.Balance(300.05,100.06);
            Assert.IsTrue(informedValue == 199.99 );
        }
        [TestMethod]
        public void BankAccountns_Balance_Success1()
        {
            BussinessLayerProjectBank.BankAccountns bankAccountns = new BussinessLayerProjectBank.BankAccountns();
            double informedValue = bankAccountns.Balance(-300.05, -100.06);
            Assert.IsTrue(informedValue == -199.99);
        }
        [TestMethod]
       public void BankAccountns_Balance_Failure()
        {
            BussinessLayerProjectBank.BankAccountns bankAccountns = new BussinessLayerProjectBank.BankAccountns();
            double informedValue = bankAccountns.Balance(300.05, 100.06);
            Assert.IsFalse(informedValue == 200.05);
        }
       

    }
        
}
