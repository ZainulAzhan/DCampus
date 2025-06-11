using dcampus.Persistence;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddPersistenceServices(builder.Configuration);

var app = builder.Build();
// Configure the HTTP request pipeline.

app.Run();
