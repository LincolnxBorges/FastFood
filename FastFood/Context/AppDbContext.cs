using FastFood.Models;
using Microsoft.EntityFrameworkCore;

namespace FastFood.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    //Mapear as Tabelas com base nas classes 
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Lanche> Lanches { get; set; }
}