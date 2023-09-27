using FastFood.Context;
using FastFood.Models;
using FastFood.Repository.Interface;

namespace FastFood.Repository;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly AppDbContext _context;
    
    public CategoriaRepository(AppDbContext context)
    {
        _context = context;
    }
    
    public IEnumerable<Categoria> Categorias => _context.Categorias;
}