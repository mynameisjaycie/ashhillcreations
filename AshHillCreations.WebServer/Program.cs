using System.Globalization;

namespace AshHillCreations.WebServer;

public static class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddRazorPages();
        builder.Services.AddMvc();
        builder.WebHost.UseStaticWebAssets();

        var cultureInfo = new CultureInfo("en-us");
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

        var app = builder.Build();
        app.UseBlazorFrameworkFiles();
        app.UseStaticFiles();
        app.MapFallbackToFile("index.html");
        app.Run();
    }
}