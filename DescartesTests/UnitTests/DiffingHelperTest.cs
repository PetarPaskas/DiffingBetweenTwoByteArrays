using Descartes.Helpers;
using NUnit.Framework;
using Fake = DescartesTests.UnitTests.DiffingHelperTest_FakeData;

namespace DescartesTests.UnitTests
{
    [TestFixture]
    public class DiffingHelperTest
    {
        private DiffingHelper diffingHelper;

        [SetUp]
        public void Setup()
        {
            diffingHelper = new();
        }

        [Test]
        public void Compare_LeftArrayIsLonger_ReturnsResponseBasedAroundLeftArray()
        {
            //Assume
            //Act
            //Assert
            Assert.Pass();
        }

        [Test]
        public void Compare_RightArrayIsLonger_ReturnsResponseBasedAroundRightArray()
        {
            //Assume
            //Act
            //Assert
            Assert.Pass();
        }

        [Test]
        public void Compare_ArraysAreEqual_ReturnsResponseAsEquals()
        {
            //Assume
            //Act
            //Assert
            Assert.Pass();
        }

        [Test]
        public void Compare_OneOfTheArraysIsNull_ThrowsException()
        {
            //Assume
            //Act
            //Assert
            Assert.Pass();
        }
    }
}
