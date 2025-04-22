using NumberSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NumberXUnit
{
    public class NumberTest
    {

        // Comumente chamado de "System Under Test", ao que parece usarei sempre a cada classe
        private readonly Number _sut;

        public NumberTest()
        {
            _sut = new Number(16);
        }



        [Fact]
        public void IsNumberEven()
        {
            Number n1 = new Number(16);

            String expectedValue = "EVEN";
            String actualValue = n1.evenAndOdd();

            Assert.Equal(expectedValue, actualValue);
        }

        [Fact]
        public void IsNumberOdd()
        {
            Number n1 = new Number(5);

            String expectedValue = "ODD";
            String actualValue = n1.evenAndOdd();

            Assert.Equal(expectedValue, actualValue);
        }

    }
}
