using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.data;

public class AppdbContext : DbContext
{
    public AppdbContext(DbContextOptions<AppdbContext> options) : base(options) { }

    public DbSet<Todoitem> Todos => Set<Todoitem>();
}
