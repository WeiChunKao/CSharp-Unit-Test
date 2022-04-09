using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    public class MemCalulatorTests
    {
        [Test]
        public void Sum_ByDefault_ReturnZero()
        {
            MemCalulator calc = new MemCalulator();
            int lastSum = calc.Sum();
            Assert.AreEqual(0, lastSum);
        }
        [TestCase(2,2)]
        [TestCase(4, 4)]
        public void Add_WhenCalled_ChangesSum(int add,int sum)
        {
            MemCalulator calc = MakeCalc();
            calc.Add(add);
            Assert.AreEqual(sum, calc.Sum());
        }

        private static MemCalulator MakeCalc()
        {
            return new MemCalulator();
        }
    }
}