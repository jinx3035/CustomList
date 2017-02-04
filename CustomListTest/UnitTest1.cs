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
        public void RemoveFromList()
        {
            //Arrange
            CustomListClass<int> list = new CustomListClass<int>() {4,3};
            int expectedLength = 1;
            
            //Act
            list.Remove(3);

            //Assert
            Assert.AreEqual(expectedLength, list.Count);
        }

        [TestMethod]
        public void IterateList()
        {
            //Arrange
            CustomListClass<string> list = new CustomListClass<string>() {"Friday", "Saturday", "Sunday"};
            int target = 3;
            string result;
            //Act
            result = IEnumerator list.GetEnumerator();

            //Assert
            Assert.AreEqual(target, result);

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
