using MVCWebApp1.Repository;

namespace MVCWebApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddMvc();
            //builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
            //builder.Services.AddTransient<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();

            var app = builder.Build();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
