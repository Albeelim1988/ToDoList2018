using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList2018;

namespace TestToDo
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ToDo test = new ToDo("1", "Go to sleep");

            string expectedID = "1";
            string expectedDes = "Go to sleep";
            DateTime expectedDate = DateTime.Now;

            test.ExpiryDate = DateTime.Now;

            Assert.AreEqual(expectedID, test.TaskID);
            Assert.AreEqual(expectedDes, test.TaskDescription);
        }
    }
}
