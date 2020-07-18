using System;
using NUnit.Framework;

namespace GarbageCollectorCore
{
    public class DoubleArray
    {
        [Test]
        public void DoubleArrayInZeroGeneration()
        {
            var array = new double[999];

            var generation = GC.GetGeneration(array);
            Assert.AreEqual(generation, 0);
        }

        [Test]
        public void DoubleArrayInZeroGenerationButHaveThousandElement()
        {
            var array = new double[1000];

            var generation = GC.GetGeneration(array);
            Assert.AreEqual(generation, 0);
        }

        [Test]
        public void DoubleArrayInTwoGeneration()
        {
            var array = new double[1001];

            var generation = GC.GetGeneration(array);
            Assert.AreEqual(generation, 0);
        }
    }
}