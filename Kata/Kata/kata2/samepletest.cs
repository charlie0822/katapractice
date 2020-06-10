using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Kata.kata2
{
    [TestFixture]
    class sampletest
    {
        [Test]
        public void samepletest()
        {

            Assert.AreEqual(0, Kata2.DeadAntCount("ant ant ant ant"));
            Assert.AreEqual(0, Kata2.DeadAntCount(null));
            Assert.AreEqual(2, Kata2.DeadAntCount("ant anantt aantnt"));
            Assert.AreEqual(1, Kata2.DeadAntCount("ant ant .... a nt"));
        }
    }
}