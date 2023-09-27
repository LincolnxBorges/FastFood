using FastFood.Models;

namespace FastFood.Repository.Interface;

public interface ICategoriaRepository
{
    IEnumerable<Categoria> Categorias { get; }
}