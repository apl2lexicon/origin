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


        public static void RegisterCustomer(CustomerModel customer)
        {
            using (var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();

                using var cmd = new SqlCommand("INSERT INTO Customer (FirstName, LastName, Address, Address2, AreaCode, City, Email, ContactInfo, Created) OUTPUT Inserted.Id VALUES (@FirstName, @LastName, @Address, @Address2, @AreaCode, @City, @Email, @ContactInfo, @Created", conn);
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.Parameters.AddWithValue("@Address2", customer.Address2);
                cmd.Parameters.AddWithValue("@AreaCode", customer.AreaCode);
                cmd.Parameters.AddWithValue("@City", customer.City);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@ContactInfo", customer.ContactInfo);
                cmd.Parameters.AddWithValue("@Created", customer.Created);

                var id = (int)cmd.ExecuteScalar();

                Console.WriteLine("ID: " + id);
                Console.WriteLine("Customer Created");
            }
        }


        public static void UpdateCustomer(CustomerModel customer)
        {
            using (var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password={your_password};MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"))
            {
                conn.Open();

                int id = customer.Id;
                string sqlString = "UPDATE customer c SET c.FirstName = @FirstName, c.LastName = @LastName, c.Address = @Address, c.Address2 = @Address2, c.AreaCode = @AreaCode, c.City = @City, c.Email = @Email, c.ContactInfo = @ContactInfo, c.Created = @Created WHERE c.Id = @Id";

                using var cmd = new SqlCommand(sqlString, conn);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@FirstName", customer.FirstName);
                cmd.Parameters.AddWithValue("@LastName", customer.LastName);
                cmd.Parameters.AddWithValue("@Address", customer.Address);
                cmd.Parameters.AddWithValue("@Address2", customer.Address2);
                cmd.Parameters.AddWithValue("@AreaCode", customer.AreaCode);
                cmd.Parameters.AddWithValue("@City", customer.City);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@ContactInfo", customer.ContactInfo);
                cmd.Parameters.AddWithValue("@Created", customer.Created);

                cmd.ExecuteNonQuery();

                Console.WriteLine("Customer " + id + " is updated");
            }
        }
    }
}
