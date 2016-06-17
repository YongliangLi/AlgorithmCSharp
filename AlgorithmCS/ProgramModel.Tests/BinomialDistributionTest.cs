using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramModels;

namespace ProgramModel.Tests
{
    [TestClass]
    public class BinomialDistributionTest
    {
        BinomialDistribution bd=new BinomialDistribution();

        [TestMethod]
        public void Should_do_Recursive()
        {
            var result= bd.Binaomial(5, 2, .25);
            Assert.AreEqual(result, 0.263671875);

        }

        [TestMethod]
        public void Should_do_Loop()
        {
            var result = bd.Binomial2(5, 2, .25);
            Assert.AreEqual(result, 0.263671875);

        }

    }
}
