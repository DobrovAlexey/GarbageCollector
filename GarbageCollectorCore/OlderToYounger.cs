using System;
using NUnit.Framework;

namespace GarbageCollectorCore
{
    public class OlderToYounger
    {
        [Test]
        public void OlderToYoungerLink()
        {
            var x = new Foo();  // x -> Gen0

            Assert.AreEqual(GC.GetGeneration(x), 0);    // x == Gen0

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
