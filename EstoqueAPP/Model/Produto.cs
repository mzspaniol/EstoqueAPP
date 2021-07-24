﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstoqueAPP.Model
{
    class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        [Required, MaxLength(100)]
        public string Nome { get; set; }

        public double Preco { get; set; }

        public int Estoque { get; set; }

        [ForeignKey("Categoria")]
        public int IdCategoria { get; set; }

        public Categoria Categoria { get; set; }
    }
}
