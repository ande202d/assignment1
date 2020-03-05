using Microsoft.VisualStudio.TestTools.UnitTesting;
using assignment1;
using System;
using System.Collections.Generic;
using System.Text;

namespace assignment1.Tests
{
    [TestClass()]
    public class BogTests
    {
        private Bog b;
        [TestInitialize]
        public void init()
        {
            b = new Bog();
        }


        #region Forfatter
        [TestMethod()]
        public void TestForfatter1()
        {
            b.Forfatter = "Anders";
            Assert.AreEqual("Anders", b.Forfatter);
        }

        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void TestForfatter2()
        {
            b.Forfatter = "A";
        } 
        #endregion

        #region Sidetal
        [TestMethod()]
        public void TestSidetal1()
        {
            b.Sidetal = 4;
            Assert.AreEqual(4, b.Sidetal);
        }
        [TestMethod()]
        public void TestSidetal2()
        {
            b.Sidetal = 1000;
            Assert.AreEqual(1000, b.Sidetal);
        }
        [TestMethod()]
        public void TestSidetal3()
        {
            b.Sidetal = 500;
            Assert.AreEqual(500, b.Sidetal);
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void TestSidetal4()
        {
            b.Sidetal = 1001;
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void TestSidetal5()
        {
            b.Sidetal = 3;
        }
        #endregion

        #region ISBN13

        [TestMethod()]
        public void TestISBN1()
        {
            b.ISBN13 = "1234567890123";
            Assert.AreEqual("1234567890123", b.ISBN13);
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void TestISBN2()
        {
            b.ISBN13 = "123456789012";
        }
        [ExpectedException(typeof(Exception))]
        [TestMethod()]
        public void TestISBN3()
        {
            b.ISBN13 = "12345678901234";
        }

        #endregion

    }
}