var builder = WebApplication.CreateBuilder(args);

//SWAGGER
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();

app.MapGet("/", () => "Hello World!");

app.UseSwaggerUI();

app.Run();

public record Cliente(string Nome, string Email);