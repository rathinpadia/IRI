using IRI.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using TinyCsvParser.Mapping;

namespace IRI.Mappings
{
    public class TextProductMapping : CsvMapping<Product>
    {
        public TextProductMapping() : base()
        {
            MapProperty(0, x => x.ProductId);
            MapProperty(1, x => x.ProductName);
        }
    }
}
