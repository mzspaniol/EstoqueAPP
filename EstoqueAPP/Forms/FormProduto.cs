using EstoqueAPP.Model;
using System.Linq;
using System.Windows.Forms;

namespace EstoqueAPP.Forms
{
    public partial class FormProduto : Form
    {
        public FormProduto()
        {
            InitializeComponent();
            using (var db = new EstoqueAPPContext())
            {
                AtualizarCBCategoria(db);
            }
        }
        private void AtualizarCBCategoria(EstoqueAPPContext db)
        {
            cbCategoria.DataSource = db.Categorias.ToList();
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "IdCategoria";
        }
    }
}
