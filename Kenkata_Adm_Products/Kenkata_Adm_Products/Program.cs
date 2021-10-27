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
            using var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password=LexApl2_21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

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


        public static void RegisterCustomer(CustomerModel customer)
        {
            using var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password=LexApl2_21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
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


        public static void UpdateCustomer(CustomerModel customer)
        {
            using var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password=LexApl2_21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
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


        public static void DeleteCustomer(int id)
        {
            using var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password=LexApl2_21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            conn.Open();

            var model = new CustomerModel();

            using var cmd = new SqlCommand("DELETE FROM Customer c WHERE c.Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Customer " + id + " is deleted");
            }
        }


        public static object GetOrderById(int id)
        {
            using var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password=LexApl2_21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            conn.Open();

            using var cmd = new SqlCommand("SELECT * FROM Order o WHERE o.Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            var result = cmd.ExecuteReader();
            var order = new OrderModel();

            while (result.Read())
            {
                order.Id = (int)result.GetValue(0);
                order.CustomerId = (int)result.GetValue(1);
                order.OrderDate = (DateTime)result.GetValue(2);
                order.Total = (decimal)result.GetValue(3);
                order.PayMethod = (int)result.GetValue(4);
                order.Payed = (bool)result.GetValue(5);
                order.Canceled = (DateTime)result.GetValue(6);
                order.Basket = (bool)result.GetValue(7);
                order.Created = (DateTime)result.GetValue(8);
            }

            return order;
        }

        public static void RegisterOrder(OrderModel order)
        {
            using var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password=LexApl2_21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            conn.Open();

            string sqlString = "INSERT INTO Order (CustomerId, OrderDate, Total, PayMethod, Payed, Canceled, Basket, Created) VALUES (@CustomerId, @OrderDate, @Total, @PayMethod, @Payed, @Canceled, @Basket, @Created)";

            using var cmd = new SqlCommand(sqlString, conn);
            cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId);
            cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
            cmd.Parameters.AddWithValue("@Total", order.Total);
            cmd.Parameters.AddWithValue("@PayMethod", order.PayMethod);
            cmd.Parameters.AddWithValue("@Payed", order.Payed);
            cmd.Parameters.AddWithValue("@Canceled", order.Canceled);
            cmd.Parameters.AddWithValue("@Basket", order.Basket);
            cmd.Parameters.AddWithValue("@Created", order.Created);

            var id = (int)cmd.ExecuteScalar();

            Console.WriteLine("ID: " + id);
            Console.WriteLine("Customer Created");
        }

        public static void DeleteOrder(int id)
        {
            using var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password=LexApl2_21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            conn.Open();

            using var cmd = new SqlCommand("DELETE FROM Order o WHERE o.Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Order + " + id + " is deleted.");
            }
        }


        public static object GetOrderLinesById(int id)
        {
            using var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password=LexApl2_21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            conn.Open();

            var model = new OrderLineModel();

            using var cmd = new SqlCommand("SELECT * FROM OrderLine o WHERE o.OrderId = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);

            var result = cmd.ExecuteReader();
            var orderLine = new OrderLineModel();

            if (result.HasRows)
            {
                while (result.Read())
                {
                    orderLine.OrderLineNr = (int)result.GetValue(0);
                    orderLine.OrderId = (int)result.GetValue(1);
                    orderLine.ProdId = (int)result.GetValue(2);
                    orderLine.Quantity = (int)result.GetValue(3);
                    orderLine.APrice = (int)result.GetValue(4);
                    orderLine.Created = (DateTime)result.GetValue(5);
                }

                Console.WriteLine("Order lines found");
            }
            else
            {
                Console.WriteLine("No Order lines found");
            }

            return orderLine;
        }


        public static object GetOrderLineByLineNo(int id, int lineNumber)
        {
            using var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password=LexApl2_21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            conn.Open();

            using var cmd = new SqlCommand("SELECT * FROM OrderLine o WHERE o.OrderLineNr = @LineNo AND o.OrderId = @Id", conn);
            cmd.Parameters.AddWithValue("@LineNo", lineNumber);
            cmd.Parameters.AddWithValue("@Id", id);

            var result = cmd.ExecuteReader();
            var orderLine = new OrderLineModel();

            if(result.HasRows)
            {
                while (result.Read())
                {
                    orderLine.OrderLineNr = (int)result.GetValue(0);
                    orderLine.OrderId = (int)result.GetValue(1);
                    orderLine.ProdId = (int)result.GetValue(2);
                    orderLine.Quantity = (int)result.GetValue(3);
                    orderLine.APrice = (int)result.GetValue(4);
                    orderLine.Created = (DateTime)result.GetValue(5);
                }

                Console.WriteLine("Order lines found");
            }
            else
            {
                Console.WriteLine("No Order lines found");
            }

            return orderLine;
        }


        public static void RegisterOrderLine(OrderLineModel orderLine)
        {
            using var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password=LexApl2_21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            
            conn.Open();

            var model = new OrderLineModel();

            using var cmd = new SqlCommand("INSERT INTE OrderLine (OrderLineNr, OrderId, ProdId, Quantity, APrice, Created) VALUES (@OrderLineNr, @OrderId, @ProdId, @Quantity, @APrice, @Created)", conn);
            cmd.Parameters.AddWithValue("@OrderLineNr", orderLine.OrderLineNr);
            cmd.Parameters.AddWithValue("@OrderId", orderLine.OrderId);
            cmd.Parameters.AddWithValue("@ProdId", orderLine.ProdId);
            cmd.Parameters.AddWithValue("@Quantity", orderLine.Quantity);
            cmd.Parameters.AddWithValue("@APrice", orderLine.APrice);
            cmd.Parameters.AddWithValue("@Created", orderLine.Created);
        }


        public static void DeleteOrderLine(int orderLineNo)
        {
            using var conn = new SqlConnection(@"Server=tcp:apl2sql.database.windows.net,1433;Initial Catalog=apl2sql;Persist Security Info=False;User ID=apl2sql;Password=LexApl2_21;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            conn.Open();

            using var cmd = new SqlCommand("DELETE FROM OrderLine o WHERE o.OrderLineNr = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", orderLineNo);

            int rowsAffected = cmd.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                Console.WriteLine("Order line + " + orderLineNo + " is deleted.");
            }
        }
    }
}
