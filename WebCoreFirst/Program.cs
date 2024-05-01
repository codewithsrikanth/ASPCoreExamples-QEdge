using System.Diagnostics;

namespace WebCoreFirst
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Create
            var builder = WebApplication.CreateBuilder(args);

            //2. Build
            var app = builder.Build();

            //Middleware
            app.UseRouting();
            app.UseEndpoints(endpoint =>
            {
                //url
                endpoint.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("welcome to Middleware");
                });

                endpoint.MapGet("/api", async context =>
                {
                    await context.Response.WriteAsync("This is an API Endppoint");
                });

                endpoint.MapGet("/home", async context =>
                {
                    await context.Response.WriteAsync("This is an Home Endppoint");
                });
            });
            
            //ConfigurationManager config = builder.Configuration;
            //string key1 = config.GetValue<string>("MyCustomKey");
            //string key = config.GetConnectionString("OracleCon");
            //app.MapGet("/", () => $"Welcome to ASP.Net Core 8.0 - {key}");

            //3. Run
            app.Run();
        }
    }
}
