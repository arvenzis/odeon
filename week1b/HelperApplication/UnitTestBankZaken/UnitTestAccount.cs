using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BankZaken;

namespace UnitTestBankZaken
{
    [TestClass]
    public class UnitTestAccount
    {
        [TestMethod]
        public void Test_WhenInstantiatingAccount_ItShouldNotEqualsNull()
        {
            Account account = new Account();
            Assert.AreNotEqual(null, account);
        }

        //[TestMethod]
        //public void TestClass_WhenGetNameProperty_ShouldReturnStringMichael()
        //{
        //    Account account = new Account();
        //    account.Name = "Michael";
        //    Assert.AreNotEqual("Michael", account.Name);
        //}
    }
}
