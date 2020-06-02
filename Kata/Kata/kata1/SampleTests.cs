using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Kata.kata1
{
    [TestFixture]
    class SampleTests
    {
        [Test]
        public void SampleTest()
        {
            string testnull = null;
            Assert.AreEqual("four", kataAverageString.AverageString("zero nine five two"));
            Assert.AreEqual("three", kataAverageString.AverageString("four six two three"));
            Assert.AreEqual("three", kataAverageString.AverageString("one two three four five"));
            Assert.AreEqual("four", kataAverageString.AverageString("five four"));
            Assert.AreEqual("zero", kataAverageString.AverageString("zero zero zero zero zero"));
            Assert.AreEqual("two", kataAverageString.AverageString("one one eight one"));
            Assert.AreEqual("n/a", kataAverageString.AverageString(""));
            Assert.AreEqual("n/a", kataAverageString.AverageString("oNe OnE eIGht one"));
            Assert.AreEqual("n/a", kataAverageString.AverageString(testnull));
        }
    }
}
