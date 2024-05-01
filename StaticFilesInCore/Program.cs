namespace StaticFilesInCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            //app.UseDefaultFiles();
            DefaultFilesOptions filesOptions = new DefaultFilesOptions();
            filesOptions.DefaultFileNames.Clear();
            filesOptions.DefaultFileNames.Add("MyCustomPage.html");
            app.UseDefaultFiles(filesOptions);



            app.UseStaticFiles();
            //app.MapGet("/", () => "Hello World!");

            app.Run(
                async context =>
                {
                    await context.Response.WriteAsync("Request Handled and Response generated");
                });
            
            app.Run();
        }
    }
}
