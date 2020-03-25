using System;
using System.Collections.Generic;
using IRI.Code;
using IRI.DTO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IRI.Tests
{
    [TestClass]
    public class IRITests
    {
        private readonly List<Product> products = new List<Product>();
        private readonly List<RetailerProduct> retailerProducts = new List<RetailerProduct>();
       
        public IRITests()
        {
            products.Add(new Product { ProductId = 18886, ProductName = "FISH OIL" });

            retailerProducts.Add(new RetailerProduct { ProductId = 18886, RetailerName = "DDS", RetailerProductCode = "93482745", RetailerProductCodeType = "Barcode", DateReceived = DateTime.Parse("16/05/2010") });
            retailerProducts.Add(new RetailerProduct { ProductId = 18886, RetailerName = "Woolworths", RetailerProductCode = "F8CE71964FAC90E59164FDB6AA19B10A", RetailerProductCodeType = "Woolworths Ref", DateReceived = DateTime.Parse("9/05/2017") });
            retailerProducts.Add(new RetailerProduct { ProductId = 18886, RetailerName = "Woolworths", RetailerProductCode = "017E9562042C3E9F0E1D200A8C915052", RetailerProductCodeType = "Woolworths Ref", DateReceived = DateTime.Parse("3/10/2017") });
            retailerProducts.Add(new RetailerProduct { ProductId = 18886, RetailerName = "Coles", RetailerProductCode = "93482745", RetailerProductCodeType = "Barcode", DateReceived = DateTime.Parse("23/04/2006") });
        }
        [TestMethod]
        public void TestMethod1()
        {
             int result = ProcessData.GetCountOfData(products, retailerProducts);
             Assert.AreEqual(2, result);
        }
    }
}
