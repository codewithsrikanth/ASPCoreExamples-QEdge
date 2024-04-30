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


            ConfigurationManager config = builder.Configuration;

            string key1 = config.GetValue<string>("MyCustomKey");
            string key = config.GetConnectionString("OracleCon");


            app.MapGet("/", () => $"Welcome to ASP.Net Core 8.0 - {key}");

            //3. Run
            app.Run();
        }
    }
}
