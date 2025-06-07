using ClassLibContainingEndpoint;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var baseRoute = app.MapGroup("").WithTags("Api");
baseRoute.MapEndpoints();


/* Compared to */ _=nameof(Endpoints.MapEndpoints);// , This will build the openapi document without a rebuild when altering the endpoint path
baseRoute.MapGet("MyDirectEndpoint1", () => "Hello, World!").WithName("MyDirectEndpoint");

await app.RunAsync();
