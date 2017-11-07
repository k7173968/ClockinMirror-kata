using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClockinMirror
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("12:02", Program.WhatIsTheTime("11:58"));           
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("06:35", Program.WhatIsTheTime("05:25"));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("11:59", Program.WhatIsTheTime("12:01"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("12:00", Program.WhatIsTheTime("12:00"));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("02:00", Program.WhatIsTheTime("10:00"));
        }
    }
}
