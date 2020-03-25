using IRI.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using TinyCsvParser.Mapping;

namespace IRI.Mappings
{
    public class TextRetailerProductMapping : CsvMapping<RetailerProduct>
    {
        public TextRetailerProductMapping() : base()
        {
            MapProperty(0, x => x.ProductId);
            MapProperty(1, x => x.RetailerName);
            MapProperty(2, x => x.RetailerProductCode);
            MapProperty(3, x => x.RetailerProductCodeType);
            MapProperty(4, x => x.DateReceived);
        }
    }
}
