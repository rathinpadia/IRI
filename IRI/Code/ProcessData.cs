using IRI.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser;

namespace IRI.Code
{
    public class ProcessData
    {
        public static dynamic GetData(List<Product> products, List<RetailerProduct> retailerProducts)
        {
            var result = retailerProducts
            .Join(products, cr => cr.ProductId, bn => bn.ProductId, (cr, bn) => new { cr, bn })
            .GroupBy(s => new { s.cr.RetailerProductCodeType, s.cr.ProductId })
                .Select(g => g.OrderByDescending(gx => gx.cr.DateReceived).First())
                .ToList();

            return result;

        }

        public static int GetCountOfData(List<Product> products, List<RetailerProduct> retailerProducts)
        {
            var result = GetData(products, retailerProducts);

           return Enumerable.Count(result);

        }
    }
}
