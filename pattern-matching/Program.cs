using pattern_matching;

var builder = WebApplication.CreateBuilder(args);
builder.Services.RegisterApplicationServices();

var app = builder.Build();

app.ConfigureMiddleware();
app.RegisterEndpoints();

app.Run();