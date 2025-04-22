using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using NumberSystem;

namespace NumberNUnit
{
    [TestFixture]
    public class NumberTestNUnit
    {

        [Test]
        public void even()
        {
            Number n1 = new Number(16);

            String expectedValue = "EVEN";
            String actualValue = n1.evenAndOdd();

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void odd()
        {
            Number n1 = new Number(5);

            String expectedValue = "ODD";
            String actualValue = n1.evenAndOdd();

            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}
