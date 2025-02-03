using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment02_Grp_06
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void Product_ProdId_ShouldBeMinimumValid()
        {
            // Test case 1: minimum valid ProdId
            // Arrange
            Product product1 = new Product(8, "Product1", 1000, 50);

            // Act
            int expected = 8;

            // Assert
            Assert.That(expected, Is.EqualTo(product1.ProdId));

        }

        [Test]
        public void Product_ProdId_ShouldBeMaximumValid()
        {
            // Test case 2: maximum valid ProdId
            // Arrange
            Product product2 = new Product(80000, "Product2", 1000, 50);

            // Act
            int expected = 80000;

            // Assert
            Assert.That(expected, Is.EqualTo(product2.ProdId));
        }

        [Test]
        public void Product_ProdId_ShouldBeInRange()
        {
            // Test case 3: ProdId should be in the range

            // Arrange
            Product product3 = new Product(40000, "Product3", 1000, 50);

            // Act
            int expected = 40000;

            // Assert
            Assert.That(expected, Is.EqualTo(product3.ProdId));
        }

        [Test]
        public void Product_ItemPrice_ShouldBeMinimumValid()
        {
            // Test case 4: ItemPrice should be minimum valid
            // Arrange
            Product product4 = new Product(100, "Product4", 8, 50);

            // Act
            int expected = 8;

            // Assert
            Assert.That(expected, Is.EqualTo(product4.ItemPrice));
        }

        [Test]
        public void Product_ItemPrice_ShouldBeMaximumValid()
        {
            // Test case 5: ItemPrice should be maximum valid
            // Arrange
            Product product5 = new Product(100, "Product5", 8000, 50);

            // Act
            int expected = 8000;

            // Assert
            Assert.That(expected, Is.EqualTo(product5.ItemPrice));
        }

        [Test]
        public void Product_ItemPrice_ShouldBeInRange()
        {
            //Test case 6: ItemPrice should be in the range
            // Arrange
            Product product6 = new Product(100, "Product6", 4000, 50);

            // Act
            int expected = 4000;

            // Assert
            Assert.That(expected, Is.EqualTo(product6.ItemPrice));
        }

        
    }
}
