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
        [TestMethod]
        public void item_availablePropertyOK()
        {
            clsStocks anStocks = new clsStocks();
            Boolean TestData = true;
            anStocks.item_available = TestData;
            Assert.AreEqual(anStocks.item_available, TestData);
        }
        [TestMethod]
        public void restock_datePropertyOK()
        {
            clsStocks anStocks = new clsStocks();
            DateTime TestData = DateTime.Now.Date;
            anStocks.restock_date = TestData;
            Assert.AreEqual(anStocks.restock_date, TestData);
        }
        [TestMethod]
        public void quantity_availablePropertyOK()
        {
            clsStocks anStocks = new clsStocks();
            int TestData = 1;
            anStocks.quantity_available = TestData;
            Assert.AreEqual(anStocks.quantity_available, TestData);
        }
        [TestMethod]
        public void item_namePropertyOK()
        {
            clsStocks anStocks = new clsStocks();
            string TestData = "CD";
            anStocks.item_name = TestData;
            Assert.AreEqual(anStocks.item_name, TestData);
        }
        [TestMethod]
        public void item_descriptionPropertyOK()
        {
            clsStocks anStocks = new clsStocks();
            string TestData = "Album";
            anStocks.item_description = TestData;
            Assert.AreEqual(anStocks.item_description, TestData);
        }
    }
}
