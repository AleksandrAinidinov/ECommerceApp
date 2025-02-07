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
        /// Test that uses a valid within range value  for prodId
        /// </summary>
        [Test]
        public void ProdId_ShouldAssignCorrectly_WhenWithinRange()
        {
            // Arrange values
            Random rnd = new Random();
            int prodId = rnd.Next(5, 5000);

            string prodName = "ValidTestProduct";
            decimal itemPrice = 10.10m;
            int stockAmount = 0;

            // Act - create a Product instance
            Product newProduct = new Product(prodId,  prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ProdID, Is.EqualTo(prodId));
        }

        /// <summary>
        /// Test that uses the maximum allowed prodID value - "50000"
        /// </summary>
        [Test]
        public void ProdId_ShouldAssignEdgeMaxValue_WhenMaxValue()
        {
            // Arrange values
            int prodId = 50000;
            string prodName = "MaxTestProduct";
            decimal itemPrice = 10.10m;
            int stockAmount = 0;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ProdID, Is.EqualTo(prodId));
        }

        /// <summary>
        /// Test that uses less than minimum allowed prodID value - "less than 5"
        /// </summary>
        [Test]
        public void ProdId_ShouldNotAssignLessThanMinValue_WhenLessThanMinValue()
        {
            // Arrange values
            int prodId = 4;
            string prodName = "LessThanMinTestProduct";
            decimal itemPrice = 10.10m;
            int stockAmount = 0;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ProdID, Is.LessThanOrEqualTo(5));
        }





        /// <summary>
        /// Test that uses a valid within range value for itemPrice
        /// </summary>
        [Test]
        public void ItemPrice_ShouldAssignCorrectly_WhenWithinRange()
        {
            // Arrange values
            Random rnd = new Random();
            decimal itemPrice = rnd.Next(6, 5000);

            int prodId = 52;
            string prodName = "ValidTestProduct";
            int stockAmount = 0;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ItemPrice, Is.EqualTo(itemPrice));
        }

        /// <summary>
        /// Test that uses the minimum allowed itemPrice value - "5.00m"
        /// </summary>
        [Test]
        public void ItemPrice_ShouldAssignEdgeMinValue_WhenMinValue()
        {
            // Arrange values
            int prodId = 52;
            string prodName = "MinTestProduct";
            decimal itemPrice = 5.00m;
            int stockAmount = 0;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ItemPrice, Is.EqualTo(itemPrice));
        }

        /// <summary>
        /// Test that uses greater than maximum allowed itemPrice value - "greater than 5000.00m"
        /// </summary>
        [Test]
        public void ItemPrice_ShouldNotAssignGreaterThanMaxValue_WhenGreaterThanMaxValue()
        {
            // Arrange values
            int prodId = 52;
            string prodName = "GreaterThanMaxTestProduct";
            decimal itemPrice = 5001.00m;
            int stockAmount = 0;

            // Act - create a Product instance
            Product newProduct = new Product(prodId, prodName, itemPrice, stockAmount);

            // Assert - check the result
            Assert.That(newProduct.ItemPrice, Is.GreaterThanOrEqualTo(5000.00m));
        }
    }
}
