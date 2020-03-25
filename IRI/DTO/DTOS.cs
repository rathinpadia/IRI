using System;
using System.Collections.Generic;
using System.Text;

namespace IRI.DTO
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
      

    }

    public class RetailerProduct
    {
        public int ProductId { get; set; }
        public string RetailerName { get; set; }
        public string RetailerProductCode { get; set; }
        public string RetailerProductCodeType { get; set; }
        public DateTime DateReceived { get; set; }
    }

    public enum ProductCodeType
    {
        Barcode,
        WoolworthRef
    }
}
