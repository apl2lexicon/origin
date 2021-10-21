using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;
using ProductsDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsDB
{
    class GetProductsBySize
    {
        [FunctionName("GetProductsBySize")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "GetProductsBySize/{Size}")] HttpRequest req,
            [CosmosDB(
                databaseName: "ProductDB",
                collectionName: "Products",
                CreateIfNotExists = true,
                ConnectionStringSetting = "CosmocDB",
                SqlQuery = "SELECT * FROM products p WHERE p.Size = {Size}"
            )] IEnumerable<ProductModel> products,
            ILogger log)
        {
            Console.WriteLine("Number of records found: " + products.Count());

            return new OkObjectResult(products);
        }
    }
}
