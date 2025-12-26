var builder = WebApplication.CreateBuilder(args);
// add services to the container
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();

app.MapGet("/", () =>
{
    return Results.Redirect("/api/books");
});

app.Run();
