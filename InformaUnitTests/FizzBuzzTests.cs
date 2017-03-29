using System.Collections.Generic;
using System.Linq;
using InformaFizzBuzz;
using NUnit.Framework;

namespace InformaUnitTests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [SetUp]
        public void SetUp()
        {
            _calculation = new Calculation();
        }

        private ICalculation _calculation;


        [Test]
        [TestCase(3, Result = "lucky")]
        [TestCase(13, Result = "lucky")]
        public string DisplayNumber_Can_Contain_3_Being_Part_Of_The_Number_Returns_Lucky(int args)
        {
            //Act
            return _calculation.DisplayNumber(args);
        }


        [Test]
        public void DisplayNumber_CanBeDivisableBy15_Returns_Buzz()
        {
            //Arrange
            var input = 15;

            //Act
            var actualResult = _calculation.DisplayNumber(input);

            //Assert
            Assert.AreEqual("fizzbuzz", actualResult);
        }

        [Test]
        public void DisplayNumber_CanBeDivisableBy15_Will_Return_Collection_Includes_FizzBuzzCount()
        {
            //Arrange
            var expectedResult = new List<string>
            {
                "1",
                "2",
                "lucky",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "lucky",
                "14",
                "fizzbuzz",
                "16",
                "17",
                "fizz",
                "19",
                "buzz"
            };
            var expectedFizzBuzzCount = 1;

            //Act
            var actualResult = Enumerable.Range(1, 20).Select(x => _calculation.DisplayNumber(x)).ToList();
            var actualFizzBuzzCount = _calculation.FizzBuzzCount;

            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedFizzBuzzCount, actualFizzBuzzCount);
        }

        [Test]
        [TestCase(9, Result = "fizz")]
        [TestCase(6, Result = "fizz")]
        [TestCase(12, Result = "fizz")]
        public string DisplayNumber_CanBeDivisableBy3_Returns_Fizz(int args)
        {
            //Act
            return _calculation.DisplayNumber(args);
        }


        [Test]
        public void DisplayNumber_CanBeDivisableBy5_Returns_Buzz()
        {
            //Arrange
            var input = 5;

            //Act
            var actualResult = _calculation.DisplayNumber(input);

            //Assert
            Assert.AreEqual("buzz", actualResult);
        }

        [Test]
        [TestCase(10, Result = "buzz")]
        [TestCase(20, Result = "buzz")]
        public string DisplayNumber_CanBeDivisableBy5_Returns_Fizz(int args)
        {
            //Act
            return _calculation.DisplayNumber(args);
        }


        [Test]
        public void DisplayNumber_CanBeDivisableBy5_Will_Return_Collection_Includes_BuzzCount()
        {
            //Arrange
            var expectedResult = new List<string>
            {
                "1",
                "2",
                "lucky",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "lucky",
                "14",
                "fizzbuzz",
                "16",
                "17",
                "fizz",
                "19",
                "buzz"
            };
            var expectedBuzzCount = 3;

            //Act
            var actualResult = Enumerable.Range(1, 20).Select(x => _calculation.DisplayNumber(x)).ToList();
            var actualBuzzCount = _calculation.BuzzCount;

            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedBuzzCount, actualBuzzCount);
        }

        [Test]
        public void DisplayNumber_Contains3_Will_Return_Collection_Includes_LuckyCount()
        {
            //Arrange
            var expectedResult = new List<string>
            {
                "1",
                "2",
                "lucky",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "lucky",
                "14",
                "fizzbuzz",
                "16",
                "17",
                "fizz",
                "19",
                "buzz"
            };
            var expectedLuckyCount = 2;

            //Act
            var actualResult = Enumerable.Range(1, 20).Select(x => _calculation.DisplayNumber(x)).ToList();
            var actualLuckyCount = _calculation.LuckyCount;

            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedLuckyCount, actualLuckyCount);
        }


        [Test]
        [TestCase(1, Result = "1")]
        [TestCase(8, Result = "8")]
        [TestCase(2, Result = "2")]
        [TestCase(7, Result = "7")]
        public string DisplayNumber_NotDivisableBy3_5_Or_15(int args)
        {
            //Act
            return _calculation.DisplayNumber(args);
        }


        [Test]
        public void DisplayNumber_Will_Return_Collection_Includes_IntegerCount()
        {
            //Arrange
            var expectedResult = new List<string>
            {
                "1",
                "2",
                "lucky",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "lucky",
                "14",
                "fizzbuzz",
                "16",
                "17",
                "fizz",
                "19",
                "buzz"
            };
            var expectedIntegerCount = 10;

            //Act
            var actualResult = Enumerable.Range(1, 20).Select(x => _calculation.DisplayNumber(x)).ToList();
            var actualIntegerCount = _calculation.NumberCount;

            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
            Assert.AreEqual(expectedIntegerCount, actualIntegerCount);
        }
    }
}