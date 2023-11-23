using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddConcern_ShouldIncreaseSubordinatesCount()
        {
         
            var enterprise = new Enterprise();
            var concern = new Concern { Name = "Test Concern" };

            
            enterprise.Subordinates.Add(concern);

            Assert.AreEqual(1, enterprise.Subordinates.Count);
            Assert.AreEqual("Test Concern", enterprise.Subordinates.First().Name);
        }

        [TestMethod]

        public void AddDepartment_ShouldIncreaseSubordinatesCount()
        {
            
               
            var concern = new Concern();
            var department = new Department { Name = "Test Department" };

         
            concern.Subordinates.Add(department);

           
            Assert.AreEqual(1, concern.Subordinates.Count);
            Assert.AreEqual("Test Department", concern.Subordinates.First().Name);
        }

        [TestMethod]
        public void AddWorkshop_ShouldIncreaseSubordinatesCount()
        {
            
            var department = new Department();
            var workshop = new Workshop { Name = "Test Workshop" };

  
            department.Subordinates.Add(workshop);

         
            Assert.AreEqual(1, department.Subordinates.Count);
            Assert.AreEqual("Test Workshop", department.Subordinates.First().Name);
        }
        [TestMethod]
        public void AddProduct_ShouldIncreaseProductsCount()
        {
          
            var enterprise = new Enterprise();

          
            enterprise.Products.Add("Test Product");

         
            Assert.AreEqual(1, enterprise.Products.Count);
            Assert.AreEqual("Test Product", enterprise.Products.First());
        }
    }
}
