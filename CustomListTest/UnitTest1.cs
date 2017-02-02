using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddToList()
            {
            //Arrange
            CustomListClass list = new CustomListClass();
            int item = 1;
            int result;
            //Act
            result = list.Add(item);
            //Assert
            Assert.AreEqual(result, list.Count);
        }

        [TestMethod]
        public void RemoveFromList()
        {
            //Arrange
            CustomListClass list = new CustomListClass();
            int item = 1;
            int result;
            //Act
            result = list.Remove(item);
            //Assert
            Assert.AreEqual(result, list.Count);
        }
    }
}
