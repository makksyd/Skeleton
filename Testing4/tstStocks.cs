using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing4
{
    [TestClass]
    public class tstStocks
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStocks anStocks = new clsStocks();
            Assert.IsNotNull(anStocks);
       
        }
    }
}
