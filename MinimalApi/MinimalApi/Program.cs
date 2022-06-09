using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options => options.UseInMemoryDatabase("Clientes"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseSwagger();

app.MapGet("/Clientes",
    async(AppDbContext dbContext) => await dbContext.Clientes.ToListAsync());

app.MapPost("/clientes", async (Cliente cliente, AppDbContext dbContext) =>
{
    dbContext.Clientes.Add(cliente);
    await dbContext.SaveChangesAsync();
});

app.MapGet("/clientes/{id}",
    async (int id, AppDbContext dbContext) => await dbContext.Clientes.FirstOrDefaultAsync(a => a.Id == id));


app.MapPut("/clientes/{id}", async (int id, Cliente cliente, AppDbContext dbContext) =>
{
    dbContext.Entry(cliente).State = EntityState.Modified;
    await dbContext.SaveChangesAsync();
    return cliente;
});

app.MapDelete("/clientes/{id}", async (int id, AppDbContext dbContext) =>
{
    var cliente = await dbContext.Clientes.FirstOrDefaultAsync(a => a.Id == id);

    if (cliente is not null)
    {
        dbContext.Clientes.Remove(cliente);
        await dbContext.SaveChangesAsync();
    }
    return;
});

app.UseSwaggerUI();

app.Run();

public class Cliente
{
    public int Id { get; set; }
    public string? Nome { get; set; }
}

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Cliente>Clientes { get; set; }
}