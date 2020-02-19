using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RestaurantModelLib.model;

namespace RestaurantUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        private Dish dish;

        [TestInitialize]
        public void BeforeEachTest()
        {
            dish = new Dish("TestDish","Starter", 0.0);
        }

        /*
         * Test    Price to be above or equal zero
         */

        // just price equal zero
        [TestMethod]
        public void TestPrice1()
        {
            // arrange - Dish is created 
            double expectedPrice = 0;

            // act
            dish.Price = 0;
            double actualPrice = dish.Price;

            // assert
            Assert.AreEqual(expectedPrice, actualPrice);
        }

        // price below zero
        [TestMethod]
        public void TestPrice2()
        {
            // arrange - Dish is created 
            // not relevant here

            // act
            // not relevant here

            // assert
            Assert.ThrowsException<ArgumentException>(() => dish.Price = -0.0001);
        }

        // price below zero in constructor
        [TestMethod]
        public void TestPrice3()
        {
            // arrange - Dish is created 
            // not relevant here

            // act
            // not relevant here

            // assert
            Assert.ThrowsException<ArgumentException>(() => new Dish("testname","starter", -0.00001));
        }


        /*
         * Test    name to be between 3 and 60
         */

        // name length 2
        [TestMethod]
        public void TestName1()
        {
            // arrange - Dish is created 
            // not relevant here

            // act
            // not relevant here

            // assert
            Assert.ThrowsException<ArgumentException>(() => dish.Name="FF");
        }

        // name length 3
        [TestMethod]
        public void TestName2()
        {
            // arrange - Dish is created 
            string expectedName = "FFF";

            // act
            dish.Name = "FFF";
            string actualName = dish.Name;

            // assert
            Assert.AreEqual(expectedName, actualName);
        }

        // name length 60
        [TestMethod]
        public void TestName3()
        {
            // arrange - Dish is created 
            string expectedName = GetString(60, 'F');
            

            // act
            dish.Name = GetString(60, 'F'); 
            string actualName = dish.Name;

            // assert
            Assert.AreEqual(expectedName, actualName);
        }


        // name length 61
        [TestMethod]
        public void TestName4()
        {
            // arrange - Dish is created 
            // not relevant here

            // act
            // not relevant here

            // assert
            Assert.ThrowsException<ArgumentException>(() => dish.Name = GetString(61, 'J'));
        }


        // name null
        [TestMethod]
        public void TestName5()
        {
            // arrange - Dish is created 
            // not relevant here

            // act
            // not relevant here

            // assert
            Assert.ThrowsException<ArgumentException>(() => dish.Name = null);
        }

        
        /*
         * Helping method
         */
        private String GetString(int count, char letter)
        {
            String s = "";
            for (int i = 0; i < count; i++)
            {
                s = s + letter;
            }

            return s;
        }
    }
}
