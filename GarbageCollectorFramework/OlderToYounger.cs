using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GarbageCollectorFramework
{
    public class OlderToYounger
    {
        [TestMethod]
        public void DoubleArrayInZeroGeneration()
        {
            var x = new Foo();  // x -> Gen0

            Assert.AreEqual(GC.GetGeneration(x), 0);

            GC.Collect();   // x -> Gen1

            x.Field = new Boo();    // x.Field => Gen0

            Assert.AreEqual(GC.GetGeneration(x), 1);    // x == Gen1
            Assert.AreEqual(GC.GetGeneration(x.Field), 0);  // x.Field == Gen0
        }

        public class Foo
        {
            public Boo Field { get; set; }
        }

        public class Boo
        {
        }
    }
}
