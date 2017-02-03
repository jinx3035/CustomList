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
            int expectedLength = 1;
            //Act
            list.Add(6);
            //Assert
            Assert.AreEqual(expectedLength, list.Count);
        }

        [TestMethod]
        public void EstablishIndex()
        {
            //Arrange
            CustomListClass<int> list = new CustomListClass<int>();
            int determineIndex;
            int actualIndex;

            //Act
            list.IndexOf();

            //Assert

        }

        //        [TestMethod]
        //        public void RemoveFromList()
        //        {
        //            //Arrange
        //            CustomListClass<int> list = new CustomListClass<int>();
        //            int expectedLength = 1;
        //;
        //            //Act
        //            list.Remove(3);

        //            //Assert
        //            Assert.AreEqual(expectedLength, list.Count);
        //        }

        //[TestMethod]
        //public void List()
        //{
        //    //Arrange

        //    //Act

        //    //Assert

        //}
    }
}
