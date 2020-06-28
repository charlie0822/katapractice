using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
namespace Kata.kata3
{

    [TestFixture]
    public class samepletest
    {

        [Test]
        public void sampletest()
        {
            Assert.AreEqual("The Knife", Kata3.BandNameGenerator("knife"));
        }
        [Test]
        public void sampletest1()
        {
            Assert.AreEqual("Tartart", Kata3.BandNameGenerator("tart"));
        }
        public void sampletest2()
        {
            Assert.AreEqual("Sandlesandles", Kata3.BandNameGenerator("sandles"));
        }
        public void sampletest3()
        {
            Assert.AreEqual("The Bed", Kata3.BandNameGenerator("bed"));
        }
        public void sampletest4()
        {
            Assert.AreEqual("B", Kata3.BandNameGenerator("b"));
        }
        public void sampletest5()
        {
            Assert.AreEqual(" ", Kata3.BandNameGenerator(" "));
        }
        public void sampletest6()
        {
            Assert.AreEqual(" ", Kata3.BandNameGenerator(null));
        }
        public void sampletest7()
        {
            Assert.AreEqual("S andles andles", Kata3.BandNameGenerator("s andles"));
        }
        public void sampletest8()
        {
            Assert.AreEqual("The B ed", Kata3.BandNameGenerator("b ed"));
        }






        
    

    }
}
