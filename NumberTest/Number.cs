using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using NumberSystem;

namespace NumberTest
{
    [TestFixture]
    public class Number
    {

        [Test]
        public void even()
        {
            NumberSystem.Number n1 = new NumberSystem.Number(16);

            String expectedValue = "EVEN";
            String actualValue = n1.evenAndOdd();

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void odd()
        {
            NumberSystem.Number n1 = new NumberSystem.Number(5);

            String expectedValue = "ODD";
            String actualValue = n1.evenAndOdd();

            Assert.AreEqual(expectedValue, actualValue);
        }

    }
}
