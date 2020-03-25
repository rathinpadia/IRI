using IRI.Mappings;
using IRI.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyCsvParser;
using IRI.Code;

namespace IRI
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadandShowOutPut();
            Console.ReadLine();
        }


        public static void ReadandShowOutPut()
        {
            string folderPath = Path.Combine(System.IO.Path.GetFullPath("..\\..\\"), "Data");
            CsvParserOptions csvParserOptions = new CsvParserOptions(true, ',');
            var csvProductParser = new CsvParser<Product>(csvParserOptions, new TextProductMapping());
            var recordsProducts = csvProductParser.ReadFromFile(Path.Combine(folderPath, "IRIProducts.txt"), Encoding.UTF8);
            List<Product> productList = recordsProducts.Select(x => x.Result).ToList();

            var csvRProductParser = new CsvParser<RetailerProduct>(csvParserOptions, new TextRetailerProductMapping());
            var recordsRProducts = csvRProductParser.ReadFromFile(Path.Combine(folderPath, "RetailerProducts.txt"), Encoding.UTF8);
            List<RetailerProduct> retailerProductList = recordsRProducts.Select(x => x.Result).ToList();

            var result = ProcessData.GetData(productList, retailerProductList);

            foreach (var item in result)
            {
                Console.WriteLine(item.bn.ProductId + "," + item.bn.ProductName + "," + item.cr.RetailerProductCodeType + "," + item.cr.RetailerProductCode);
            }

        }
    }
}
