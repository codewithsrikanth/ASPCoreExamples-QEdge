namespace MVCCoreBasic
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();
            var app = builder.Build();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapDefaultControllerRoute();

                endpoints.MapControllerRoute(
                    name:"default",
                    pattern: "myapp/{controller=Home}/{action=Index}/{id?}"
                    );
            });

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
