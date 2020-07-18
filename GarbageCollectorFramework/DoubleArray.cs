using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GarbageCollectorFramework
{
    [TestClass]
    public class DoubleArray
    {
        [TestMethod]
        public void DoubleArrayInZeroGeneration()
        {
            var array = new double[999];

            var generation = GC.GetGeneration(array);
            Assert.AreEqual(generation, 0);
        }

        [TestMethod]
        public void DoubleArrayInTwoGeneration()
        {
            var array = new double[1000];

            var generation = GC.GetGeneration(array);
            Assert.AreEqual(generation, 2);
        }
    }
}