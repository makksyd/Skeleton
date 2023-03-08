using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstSupplier
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSuppliers ASupplier = new clsSuppliers();
            Assert.IsNotNull(ASupplier);
        }
    }
}
