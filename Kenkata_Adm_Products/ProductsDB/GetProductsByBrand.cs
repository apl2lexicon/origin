using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using Kenkata_Adm_Products.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsDB
{
    class GetProductsByBrand
    {
        [FunctionName("GetProductsByBrand")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "GetProductsByBrand/{Brand}")] HttpRequest req,
            [CosmosDB(
                databaseName: "ProductDB",
                collectionName: "Products",
                CreateIfNotExists = true,
                ConnectionStringSetting = "CosmocDB",
                SqlQuery = "SELECT * FROM products p WHERE p.Brand = {Brand}"
            )] IEnumerable<ProductModel> products,
            ILogger log)
        {
            Console.WriteLine("Number of records found: " + products.Count());

            return new OkObjectResult(products);
        }
    }
}
