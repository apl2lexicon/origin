using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Threading.Tasks;

namespace ProductsDB
{
    class Product
    {
        [FunctionName("apl2Products")]
        public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
        [CosmosDB(
            databaseName:"ProductDB",
            collectionName:"Products",
            ConnectionStringSetting = "CosmocDB",
                SqlQuery = "SELECT * FROM c"
            )] IEnumerable<Product> products,
                ILogger log)
        {
            log.LogInformation("Data fetched from KenkataProductDB");
            return new OkObjectResult(products);
        }
    }
}
