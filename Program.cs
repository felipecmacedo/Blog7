using Blog.Data;

var builder = WebApplication.CreateBuilder(args);

builder
    .Services
    .AddControllers()
    .ConfigureApiBehaviorOptions(options =>
{
    options.SuppressModelStateInvalidFilter = true;
});

builder.Services.AddDbContext<BlogDataContext>();
builder.Services.AddTransient();
builder.Services.AddScoped();
builder.Services.AddSingleton();

var app = builder.Build();

app.MapControllers();

app.Run();