using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FastFood.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches (LancheNome, LancheDescricaoCurta, LancheDescricaoDetalhada, LanchePreco, LancheImagemUrl, LanchePreferido, LancheEmEstoque, CategoriaId) VALUES ('X-Bacon', 'Delicioso lanche com bacon', '...', 20.00, 'https://www.receitasnestle.com.br/images/default-source/recipes/x-bacon.jpg', 1, 0, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches (LancheNome, LancheDescricaoCurta, LancheDescricaoDetalhada, LanchePreco, LancheImagemUrl, LanchePreferido, LancheEmEstoque, CategoriaId) VALUES ('X-Burger', 'Delicioso lanche com hamburguer', '...', 15.00, 'https://www.receitasnestle.com.br/images/default-source/recipes/x-burger.jpg', 0, 0, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches (LancheNome, LancheDescricaoCurta, LancheDescricaoDetalhada, LanchePreco, LancheImagemUrl, LanchePreferido, LancheEmEstoque, CategoriaId) VALUES ('X-Egg', 'Delicioso lanche com ovo', '...', 18.00, 'https://www.receitasnestle.com.br/images/default-source/recipes/x-egg.jpg', 0, 0, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches (LancheNome, LancheDescricaoCurta, LancheDescricaoDetalhada, LanchePreco, LancheImagemUrl, LanchePreferido, LancheEmEstoque, CategoriaId) VALUES ('X-Frango', 'Delicioso lanche com frango', '...', 17.00, 'https://www.receitasnestle.com.br/images/default-source/recipes/x-frango.jpg', 0, 0, 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
