using D6;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Power.Tests
{
    [TestClass]
    public class DeskFansTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p1 =new DeskFan(new PowerLowerThanZero());
            var expected = "Slow";
            var actual = p1.Work();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Than200()
        {
            var p2 = new DeskFan(new PowerThan200());
            var expected1 = "Explostion";
            var actual1 = p2.Work();
            Assert.AreEqual(expected1, actual1);
        }
     
    }
       class PowerLowerThanZero : PowerSupply
        {
            public override  int GetPower()
            {
                return 0;
            }
           
        }

        class PowerThan200:PowerSupply
        {
            public override int GetPower()
            {
                return 2001;
            }
        }
}
