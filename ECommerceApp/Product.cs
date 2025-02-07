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
        

        // Error is thrown if the product name is null or empty
        private string _prodName;
        public string ProdName {
            get { return _prodName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name can't be NULL or EMPTY!");
                }
                _prodName = value;
            }
        }
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
