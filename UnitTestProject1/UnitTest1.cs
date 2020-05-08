using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BuyMoviez;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRefund()
        {
            //arrange
            Movie movie1 = new Movie();
            decimal walletBalance = 25m;

            //act
            movie1.RefundMovie(25m);

            //assert
            Assert.AreEqual(walletBalance, movie1.Wallet);


        }

        [TestMethod]
        public void TestFunds()
        {
            //arrange
            Movie movie1 = new Movie();
            movie1.RefundMovie(1500m);
            decimal walletBalance = 1475m;

            //act
            movie1.BuyMovie(25m);

            //assert
            Assert.AreEqual(walletBalance, movie1.Wallet);
        }

        [TestMethod]
        public void TestFundsFailed()
        {
            //arrange
            Movie movie1 = new Movie();
            movie1.RefundMovie(1500m);
            decimal walletBalance = 0m;

            //act
            movie1.BuyMovie(50m);

            //assert
            Assert.AreEqual(walletBalance, movie1.Wallet);
        }
    }
}
