using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastFood.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
            {
                migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome, CategoriaDescricao) VALUES ('Normal', 'Lanches normais')");
                migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome, CategoriaDescricao) VALUES ('Natural', 'Lanches naturais')");
                migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome, CategoriaDescricao) VALUES ('Vegano', 'Lanches veganos')");
                migrationBuilder.Sql("INSERT INTO Categorias (CategoriaNome, CategoriaDescricao) VALUES ('Vegetariano', 'Lanches vegetarianos')");
            }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
