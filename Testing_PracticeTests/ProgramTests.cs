using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testing_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Practice.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void hashingTest()
        {
            //Assert.Fail();
            Assert.AreEqual(Program.hashing("leepadg"), 680131659347);
        }
    }
}