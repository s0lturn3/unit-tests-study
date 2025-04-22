using NumberSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace NumberXUnit
{
    public class NumberTestXUnit
    {

        // Comumente chamado de "System Under Test", ao que parece usarei sempre a cada classe
        private readonly Number _sut;
        private readonly ITestOutputHelper _output;

        public NumberTestXUnit(ITestOutputHelper output)
        {
            _output = output;
            _sut = new Number(16);
        }


        #region Testes simples

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

        #endregion Testes simples

        #region Testes com parâmetros

        [Theory]
        [InlineData(2)]
        [InlineData(8)]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(100)]
        public void IsNumberEvenWithParams(int number)
        {
            Number n1 = new Number(number);

            String expectedValue = "EVEN";
            String actualValue = n1.evenAndOdd();

            Assert.Equal(expectedValue, actualValue);
        }

        [Theory]
        [InlineData(7)]
        [InlineData(9)]
        [InlineData(15)]
        [InlineData(235)]
        [InlineData(985)]
        public void IsNumberOddWithParams(int number)
        {
            Number n1 = new Number(number);

            String expectedValue = "ODD";
            String actualValue = n1.evenAndOdd();

            Assert.Equal(expectedValue, actualValue);
        }

        #endregion Testes com parâmetros

        #region Pular um teste

        [Fact(Skip = "Teste não escrito ainda")]
        public void IsNumberOddDecimal()
        {
            // ...
        }

        #endregion Pular um teste

        #region Testes com parâmetros dinâmicos

        public static IEnumerable<object[]> OddTestData()
        {
            yield return new object[] { 3, 9 };
        }
        
        public static IEnumerable<object[]> EvenTestData()
        {
            yield return new object[] { 2, 6 };
            yield return new object[] { 568, 692 };
            yield return new object[] { 876, 12, 42, 78 };
        }


        [Theory(Skip = "Teste não escrito ainda")]
        [MemberData(nameof(EvenTestData))]
        public void AreNumbersEven(params object[] numbers)
        {
            // ...
        }

        #endregion Testes com parâmetros dinâmicos


        #region Teste com retorno

        [Fact]
        public void GUIDIsNotEmpty()
        {
            Guid id = _sut.genericGuid;
            Assert.NotEqual(Guid.Empty, id);

            _output.WriteLine(id.ToString());
        }

        #endregion Teste com retorno

    }
}
