using System;

namespace ClassLibrary
{
    public class clsStocks
    {
        public int quantity_available;
        public string item_name;
        public string item_description;

        public bool item_id { get; set; }
        public DateTime restock_date { get; set; }
        public bool item_available { get; set; }
    }
}