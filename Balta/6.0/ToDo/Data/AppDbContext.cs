using Microsoft.EntityFrameworkCore;
using Todo.Models;

namespace ToDo.Data;

public class AppDbContext : DbContext
{
    public DbSet<TodoModels> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("DataSource=app.db;Cache=shared");
}