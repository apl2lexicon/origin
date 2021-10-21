using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Kenkata_Adm_Products.Models;
using System.Linq;

namespace ProductsDB
{
    class GetProductById
    {
        [FunctionName("GetProductById")]
        public static async Task<IActionResult> Run(
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "GetProductById/{id}")] HttpRequest req,
        [CosmosDB(
            databaseName:"ProductDB",
            collectionName:"Products",
            ConnectionStringSetting = "CosmocDB",
                SqlQuery = "select * FROM c WHERE c.id = {id}"
            )] IEnumerable<ProductModel> products,
                ILogger log)
        {

            return new OkObjectResult(products);
        }
    }
}
