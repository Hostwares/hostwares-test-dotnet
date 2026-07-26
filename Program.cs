var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () =>
{
    var appName = Environment.GetEnvironmentVariable("APP_NAME") ?? "Hostwares Test .NET";
    var dbConn = Environment.GetEnvironmentVariable("CONNECTION_STRING") != null ? "✅ Connected" : "❌ Not configured";
    var apiKey = Environment.GetEnvironmentVariable("API_SECRET") != null ? "✅ Set" : "❌ Not set";
    var aspEnv = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Production";

    return Results.Ok(new
    {
        status = "🚀 Running on Hostwares!",
        app_name = appName,
        framework = ".NET 8 Minimal API",
        environment = new
        {
            ASPNETCORE_ENVIRONMENT = aspEnv,
            CONNECTION_STRING = dbConn,
            API_SECRET = apiKey,
        },
        deployed_at = DateTime.UtcNow.ToString("o")
    });
});

app.MapGet("/health", () => Results.Ok(new { status = "healthy" }));

app.Run();
