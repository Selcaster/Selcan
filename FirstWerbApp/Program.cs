namespace FirstWebApp 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            app.MapGet("/", () => "Hello World!");
            app.MapGet("/AzTU", () => "Salam, AB101");
            app.MapGet("/ping", () => "pong");
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"); 
            app.Run();
        }
    }
}
