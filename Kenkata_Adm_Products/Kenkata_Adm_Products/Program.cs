using Kenkata_Adm_Products.Models;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kenkata_Adm_Products
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            await builder.Build().RunAsync();
        }


        public static object GetCustomerById(int id)
        {
            using (var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();
                var model = new CustomerModel();

                using var cmd = new SqlCommand("SELECT * FROM Customer c WHERE c.Id = @Id", conn);
                cmd.Parameters.AddWithValue("@Id", id);

                var result = cmd.ExecuteReader();
                var customer = new CustomerModel();

                while (result.Read())
                {
                    customer.Id = (int)result.GetValue(0);
                    customer.FirstName = (string)result.GetValue(1);
                    customer.LastName = (string)result.GetValue(2);
                    customer.Address = (string)result.GetValue(3);
                    customer.Address2 = (string)result.GetValue(4);
                    customer.AreaCode = (int)result.GetValue(5);
                    customer.City = (string)result.GetValue(6);
                    customer.Email = (string)result.GetValue(7);
                    customer.ContactInfo = (string)result.GetValue(8);
                    customer.Created = (DateTime)result.GetValue(9);
                }

                return customer;
            }
        }


        public static void CreateCustomer(CustomerModel customer)
        {
            using (var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();
                var model = new CustomerModel();

                //model.Id = customer.Id;
                model.FirstName = customer.FirstName;
                model.LastName = customer.LastName;
                model.Address = customer.Address;
                model.Address2 = customer.Address2;
                model.AreaCode = customer.AreaCode;
                model.City = customer.City;
                model.Email = customer.Email;
                model.ContactInfo = customer.ContactInfo;
                model.Created = customer.Created;

                using var cmd = new SqlCommand("INSERT INTO Customer (FirstName, LastName, Address, Address2, AreaCode, City, Email, ContactInfo, Created) OUTPUT Inserted.Id VALUES (@FirstName, @LastName, @Address, @Address2, @AreaCode, @City, @Email, @ContactInfo, @Created", conn);
                cmd.Parameters.AddWithValue("@FirstName", model.FirstName);
                cmd.Parameters.AddWithValue("@LastName", model.LastName);
                cmd.Parameters.AddWithValue("@Address", model.Address);
                cmd.Parameters.AddWithValue("@Address2", model.Address2;
                cmd.Parameters.AddWithValue("@AreaCode", model.AreaCode);
                cmd.Parameters.AddWithValue("@City", model.City);
                cmd.Parameters.AddWithValue("@Email", model.Email);
                cmd.Parameters.AddWithValue("@ContactInfo", model.ContactInfo);
                cmd.Parameters.AddWithValue("@Created", model.Created);


            }
        }
    }
}
