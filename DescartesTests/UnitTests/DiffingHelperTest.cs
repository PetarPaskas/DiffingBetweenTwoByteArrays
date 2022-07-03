using Descartes.Domain;
using Descartes.Helpers;
using NUnit.Framework;
using System;
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
            var left = Fake.GenerateFakeArray(sizeInKB: 2);
            var right = Fake.GenerateFakeArray(sizeInKB: 1);
            //Act
            DiffingCompareResponse result = diffingHelper.Compare(left, right);
            //Assert
            Assert.IsTrue(result.DiffResultType == CompareStatus.SizeDoNotMatch);
        }

        [Test]
        public void Compare_RightArrayIsLonger_ReturnsResponseBasedAroundRightArray()
        {
            //Assume
            var left = Fake.GenerateFakeArray(sizeInKB: 1);
            var right = Fake.GenerateFakeArray(sizeInKB: 2);
            //Act
            DiffingCompareResponse result = diffingHelper.Compare(left, right);
            //Assert
            Assert.IsTrue(result.DiffResultType == CompareStatus.SizeDoNotMatch);
        }


        [Test]
        public void Compare_ArraysAreOnSameMemLocation_ReturnsResponseAsEquals()
        {
            //Assume
            var both = Fake.GenerateFakeArray(sizeInKB: 1);
            //Act
            DiffingCompareResponse result = diffingHelper.Compare(both, both);
            //Assert
            Assert.IsTrue(result.DiffResultType == CompareStatus.Equals);
        }

        [Test]
        public void Compare_ArraysAreEqualAndDifferentMemoryLocation_ReturnsResponseAsEquals()
        {
            //Assume
            byte[] left = new byte[3] { 22, 22, 22 };
            byte[] right = new byte[3] { 22, 22, 22 };
            //Act
            DiffingCompareResponse result = diffingHelper.Compare(left, right);
            //Assert
            Assert.IsTrue(result.DiffResultType == CompareStatus.Equals);
        }

        [Test]
        public void Compare_ArraysAreEqualButDifferentContent_ReturnsResponseDifferences()
        {
            //Assume
            var left = Fake.GenerateFakeArray(sizeInKB: 1);
            var right = Fake.GenerateFakeArray(sizeInKB: 1);
            //Act
            DiffingCompareResponse result = diffingHelper.Compare(left, right);
            //Assert
            Assert.IsTrue(result.DiffResultType == CompareStatus.ContentDoNotMatch);
        }

        [Test]
        public void Compare_OneOfTheArraysIsNull_ThrowsException()
        {
            //Assume
            var left = Fake.GenerateFakeArray(sizeInKB: 1);
            byte[] right = null;
            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => { DiffingCompareResponse result = diffingHelper.Compare(left, right); });
        }
    }
}
