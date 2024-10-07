using GraphQL;
using HotChocolate;

var builder = WebApplication.CreateBuilder(args);

// GraphQL hizmetlerini ekleyin
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

// GraphQL middleware'ini ekle
app.MapGraphQL("/graphql"); // GraphQL sorgularýný bu endpoint üzerinden çalýþtýracaðýz.


app.Run();
