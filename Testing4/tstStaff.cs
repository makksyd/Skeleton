using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            //Create an instance of the class we want to create
            clsStaff AStaff = new clsStaff();
            //Test to see if that exists
            Assert.IsNotNull(AStaff);
        }
    }
}
