using Microsoft.EntityFrameworkCore;
using twtodos.Models;

namespace twtodos.Contexts;

public class TWTodosContext : DbContext
{
    public DbSet<Todo> Todos => Set<Todo>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todos.sqlite3");
    }
}