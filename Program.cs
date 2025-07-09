var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/hello", () => "Hello, EDP!");
app.MapGet("/api/readiness", () => "readiness-ok");
app.MapGet("/api/liveness", () => "liveness-ok");

app.Run();
