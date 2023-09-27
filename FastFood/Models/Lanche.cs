using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastFood.Models;

[Table("Lanches")]
public class Lanche
{
    [Key]
    public int LancheId { get; set; }
    
    [StringLength(80, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
    public string LancheNome { get; set; }
    
    [Required(ErrorMessage = "A descrição do lanche é obrigatória")]
    [Display(Name = "Descrição do Lanche")]
    [MinLength(20, ErrorMessage = "Descrição do lanche deve ter no mínimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "Descrição do lanche deve ter no máximo {1} caracteres")]
    public string LancheDescricaoCurta { get; set; }
    
    [Required(ErrorMessage = "A descrição do lanche é obrigatória")]
    [Display(Name = "Descrição detalhada do Lanche")]
    [MinLength(20, ErrorMessage = "Descrição do lanche deve ter no mínimo {1} caracteres")]
    [MaxLength(200, ErrorMessage = "Descrição do lanche deve ter no máximo {1} caracteres")]
    public string LancheDescricaoDetalhada { get; set; }
    
    [Required(ErrorMessage = "O preço do lanche é obrigatório")]
    [Display(Name = "Preço do Lanche")]
    [Column(TypeName = "decimal(10,2)")]
    [Range(1,999.99, ErrorMessage = "O preço deve estar entre 1 e 999,99")]
    public decimal LanchePreco { get; set; }
    
    [Display(Name = "Imagem do Lanche")]
    [StringLength(200, ErrorMessage = "O {0} não pode passar de {1} caracteres")]
    public string LancheImagemUrl { get; set; }
    
    [Display(Name = "Imagem miniatura do Lanche")]
    [StringLength(200, ErrorMessage = "O {0} não pode passar de {1} caracteres")]
    public string LancheImagemThumbnailUrl { get; set; }
    
    [Display(Name = "Lanche do Prefirido")]
    public bool LanchePreferido { get; set; }
    
    [Display(Name = "Lanche em Estoque")]
    public bool LancheEmEstoque { get; set; }
    
    public int CategoriaId { get; set; }
    public virtual Categoria Categoria { get; set; }
}