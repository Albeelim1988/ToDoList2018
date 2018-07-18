﻿using System;
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
            ToDo test = new ToDo(1, "Go to sleep");

            int expectedID = 1;
            string expectedDes = "Go to sleep";
            DateTime expectedDate = DateTime.Now;

            test.DueDate = DateTime.Now;

            Assert.AreEqual(expectedID, test.TaskID);
            Assert.AreEqual(expectedDes, test.TaskDescription);
            Assert.AreEqual(expectedDate, test.CreatedDate);
            Assert.AreEqual(expectedDate, test.DueDate);
        }
    }
}
