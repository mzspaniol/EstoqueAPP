using Microsoft.EntityFrameworkCore;

namespace EstoqueAPP.Model
{
    class EstoqueAPPContext: DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=estoque.db");
        }
    }
}
