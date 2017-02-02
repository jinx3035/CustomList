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
            CustomListClass<int> list = new CustomListClass<int>();
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
            CustomListClass<int> list = new CustomListClass<int>();
            int item = 1;
            int result;
            //Act
            result = list.Remove(item);
            //Assert
            Assert.AreEqual(result, list.Count);
        }

        [TestMethod]
        public void List()
        {
            //Arrange

            //Act

            //Assert

        }

        //[TestMethod]
        //public void List()
        //{
        //    //Arrange

        //    //Act

        //    //Assert

        //}
    }
}
