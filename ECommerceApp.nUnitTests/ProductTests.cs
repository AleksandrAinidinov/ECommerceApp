using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ECommerceApp;

namespace ECommerceApp.nUnitTests
{
    [TestFixture]
    public class ProductTests
    {
        /// <summary>
        /// Test that uses a valid within range value for ProdID
        /// </summary>
        [Test]
        public void ProdId_ShouldAssignCorrectly_WhenWithinRange()
        {
            // Arrange values
            Random rnd = new Random();
            int prodId = rnd.Next(6, 5000);

            string prodName = "ValidTestProduct";
            decimal itemPrice = 10.10m;
            int stockAmount = 10;

            // Act - create a Product instance
            Product newProduct = new Product(prodId,  prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ProdID, Is.EqualTo(prodId));;
            Assert.That(newProduct.ProdID, Is.LessThanOrEqualTo(4999));
            Assert.That(newProduct.ProdID, Is.GreaterThanOrEqualTo(6));
        }

        /// <summary>
        /// Test that uses the maximum allowed ProdID value - "50000"
        /// </summary>
        [Test]
        public void ProdId_ShouldAssignEdgeMaxValue_WhenMaxValue()
        {
            // Arrange values
            int prodId = 50000;
            string prodName = "MaxTestProduct";
            decimal itemPrice = 10.10m;
            int stockAmount = 10;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ProdID, Is.EqualTo(prodId));
        }

        /// <summary>
        /// Test that uses less than minimum allowed ProdID value - "less than 5"
        /// </summary>
        [Test]
        public void ProdId_ShouldNotAssignLessThanMinValue_WhenLessThanMinValue()
        {
            // Arrange values
            int prodId = 4;
            string prodName = "LessThanMinTestProduct";
            decimal itemPrice = 10.10m;
            int stockAmount = 10;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ProdID, Is.LessThanOrEqualTo(5));
        }




        /// <summary>
        /// Test that uses a valid within range value for ItemPrice
        /// </summary>
        [Test]
        public void ItemPrice_ShouldAssignCorrectly_WhenWithinRange()
        {
            // Arrange values
            Random rnd = new Random();
            decimal itemPrice = rnd.Next(6, 5000);

            int prodId = 52;
            string prodName = "ValidTestProduct";
            int stockAmount = 10;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ItemPrice, Is.EqualTo(itemPrice));
            Assert.That(newProduct.ItemPrice, Is.LessThanOrEqualTo(4999.00m));
            Assert.That(newProduct.ItemPrice, Is.GreaterThanOrEqualTo(6.00m));
        }

        /// <summary>
        /// Test that uses the minimum allowed ItemPrice value - "5.00m"
        /// </summary>
        [Test]
        public void ItemPrice_ShouldAssignEdgeMinValue_WhenMinValue()
        {
            // Arrange values
            int prodId = 52;
            string prodName = "MinTestProduct";
            decimal itemPrice = 5.00m;
            int stockAmount = 10;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ItemPrice, Is.EqualTo(itemPrice));
        }

        /// <summary>
        /// Test that uses greater than maximum allowed ItemPrice value - "greater than 5000.00m"
        /// </summary>
        [Test]
        public void ItemPrice_ShouldNotAssignGreaterThanMaxValue_WhenGreaterThanMaxValue()
        {
            // Arrange values
            int prodId = 52;
            string prodName = "GreaterThanMaxTestProduct";
            decimal itemPrice = 5001.00m;
            int stockAmount = 10;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ItemPrice, Is.GreaterThanOrEqualTo(5000.00m));
        }




        /// <summary>
        /// Test that uses a valid within range value for StockAmount
        /// </summary>
        [Test]
        public void StockAmount_ShouldAssignCorrectly_WhenWithinRange()
        {
            // Arrange values
            Random rnd = new Random();
            int stockAmount = rnd.Next(6, 500000);

            int prodId = 52;
            string prodName = "ValidTestProduct";
            decimal itemPrice = 10.10m;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.StockAmount, Is.EqualTo(stockAmount));
            Assert.That(newProduct.StockAmount, Is.LessThanOrEqualTo(499999));
            Assert.That(newProduct.StockAmount, Is.GreaterThanOrEqualTo(6));
        }

        /// <summary>
        /// Test that uses the maximum allowed StockAmount value - "500000"
        /// </summary>
        [Test]
        public void StockAmount_ShouldAssignEdgeMaxValue_WhenMaxValue()
        {
            // Arrange values
            int prodId = 52;
            string prodName = "MaxTestProduct";
            decimal itemPrice = 10.10m;
            int stockAmount = 500000;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.StockAmount, Is.EqualTo(stockAmount));
        }

        /// <summary>
        /// Test that uses less than minimum allowed StockAmount value - "less than 5"
        /// </summary>
        [Test]
        public void StockAmount_ShouldNotAssignLessThanMinValue_WhenLessThanMinValue()
        {
            // Arrange values
            int prodId = 52;
            string prodName = "LessThanMinTestProduct";
            decimal itemPrice = 10.10m;
            int stockAmount = 4;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.StockAmount, Is.LessThanOrEqualTo(5));
        }




        /// <summary>
        /// Test that uses a valid within range value for ProdName
        /// </summary>
        [Test]
        public void ProdName_ShouldAssignCorrectly_WhenWithinRange()
        {
            // Arrange values
            int prodId = 52;
            string prodName = "ValidTestProduct";
            decimal itemPrice = 10.10m;
            int stockAmount = 10;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ProdName, Is.EqualTo(prodName));
        }

        /// <summary>
        /// Test that uses the minimum allowed ProdName value length - "1 symbol"
        /// </summary>
        [Test]
        public void ProdName_ShouldAssignEdgeMinValue_WhenMinLength()
        {
            // Arrange values
            int prodId = 52;
            string prodName = "f";
            decimal itemPrice = 10.10m;
            int stockAmount = 10;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ProdName, Is.EqualTo(prodName));
        }

        /// <summary>
        /// Test that uses empty ProdName value and expects an error to be thrown
        /// </summary>
        [Test]
        public void ProdName_ShouldThrowErrorIfEmptyValue_WhenEmptyValue()
        {
            // Arrange values
            int prodId = 52;
            string prodName = string.Empty;
            decimal itemPrice = 10.10m;
            int stockAmount = 10;

            // Act - try to create a Product instance and check if the exception is thrown
            ArgumentException ex = null;
            try
            {
                new Product(prodId, prodName, itemPrice, stockAmount);
            }
            catch (ArgumentException e)
            {
                ex = e;
            }

            // Assert - check the result exception message
            Assert.That(ex.Message, Does.Contain("Product name can't be NULL or EMPTY!"));
        }

    }
}
