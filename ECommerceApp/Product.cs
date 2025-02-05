using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApp
{
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public decimal ItemPrice { get; set; }
        public int StockAmount { get; set; }

        // Constructor
        public Product(int prodID, string prodName, decimal itemPrice, int stockAmount)
        {
            ProdID = prodID;
            ProdName = prodName;
            ItemPrice = itemPrice;
            StockAmount = stockAmount;
        }

        // Method to Increase stock
        public void IncreaseStock(int amount)
        {
            if (amount > 0)
                StockAmount += amount;
        }

        // Method to Decrease stock
        public void DecreaseStock(int amount)
        {
            if (amount > 0 && StockAmount - amount >= 0)
                StockAmount -= amount;
        }
    }
}
