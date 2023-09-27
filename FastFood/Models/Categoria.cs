using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FastFood.Models;

    [Table("Categorias")]
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100, ErrorMessage = "O nome da categoria precisa ter no máximo 100 caracteres")]
        [Required(ErrorMessage = "O nome da categoria é obrigatório")]
        [Display(Name = "Nome")]
        public string CategoriaNome { get; set; }
        
        [StringLength(100, ErrorMessage = "A descrição precisa ter no máximo 100 caracteres")]
        [Required(ErrorMessage = "A descrição é obrigatório")]
        [Display(Name = "Descrição")]
        public string CategoriaDescricao { get; set; }
    
        public List<Lanche> Lanches { get; set; }
    }