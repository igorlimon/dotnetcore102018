using System.Collections.Generic;
using ListOperation;
using Moq;
using NUnit.Framework;

namespace ListTests
{
    [TestFixture]
    public class ListUnitTests
    {
        private ListOperation.List _testedList;
        private Mock<IDataList> _mockDataList;

        [SetUp]
        public void Setup()
        {
            _mockDataList = new Mock<IDataList>();
            _testedList = new ListOperation.List(_mockDataList.Object);
        }

        [Test]
        public void List_GetSortedList_ItemsExist_ItemsAreOrdered()
        {
            // Arrange
            _mockDataList
                .Setup(m => m.GetData())
                .Returns(new List<string>()
                {
                    "A",
                    "R",
                    "M"
                });

            // Act
            var sortedList = _testedList.GetSortedList();

            // Assert
            Assert.AreEqual(3, sortedList.Count);
            Assert.AreEqual("A", sortedList[0]);
            Assert.AreEqual("M", sortedList[1]);
            Assert.AreEqual("R", sortedList[2]);
        }
    }
}
