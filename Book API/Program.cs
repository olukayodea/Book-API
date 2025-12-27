var builder = WebApplication.CreateBuilder(args);
// add services to the container
builder.Services.AddControllers();
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCors", builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();
app.MapControllers();
app.UseCors("MyCors");

app.MapGet("/", () =>
{
    return Results.Redirect("/api/books");
});

app.Run();
