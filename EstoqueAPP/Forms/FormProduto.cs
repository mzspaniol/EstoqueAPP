using EstoqueAPP.Model;
using MessageUtils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EstoqueAPP
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

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            using (var form = new FormCategoria())
            {
                form.Text = "Cadastro de categoria";
                if(form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new EstoqueAPPContext())
                    {
                        Categoria categoria = new Categoria();
                        categoria.Nome = form.txtNome.Text;
                        db.Categorias.Add(categoria);
                        db.SaveChanges();
                        AtualizarCBCategoria(db);
                        SimpleMessage.Inform("Categoria adicionada com sucesso", "Informação");
                    }
                }
                else
                {

                }
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
