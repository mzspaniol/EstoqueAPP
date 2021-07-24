using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EstoqueAPP.Model
{
     class Categoria
    {
        [Key]
        public int IdCategoria { get; set; }
        [Required, MaxLength(100)]
        public string Nome { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
