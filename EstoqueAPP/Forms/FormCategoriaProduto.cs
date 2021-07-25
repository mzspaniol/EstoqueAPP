﻿using EstoqueAPP.Forms;
using EstoqueAPP.Model;
using MessageUtils;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EstoqueAPP
{
    public partial class FormCategoriaProduto : Form
    {
        public FormCategoriaProduto()
        {
            InitializeComponent();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {
            using (var form = new FormCategoria())
            {
                form.Text = "Cadastro de categoria";
                if (form.ShowDialog() == DialogResult.OK)
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
            }
        }

        private void AtualizarCBCategoria(EstoqueAPPContext db)
        {
            cbCategoria.DataSource = db.Categorias.ToList();
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.ValueMember = "IdCategoria";
        }

        private void CarregaProdutos(EstoqueAPPContext db)
        {
            if (cbCategoria.Items.Count > 0)
            {
                this.Cursor = Cursors.WaitCursor;
                int idCategoria = (cbCategoria.SelectedItem as Categoria).IdCategoria;
                dgvProdutos.DataSource = db.Produtos.Where
                    (x => x.IdCategoria == idCategoria).
                    Include(x => x.Categoria).ToList();
                this.Cursor = Cursors.Default;
                dgvProdutos.Columns.Remove(dgvProdutos.Columns["IdCategoria"]);
                dgvProdutos.Columns.Remove(dgvProdutos.Columns["Categoria"]);
                dgvProdutos.Columns["clmCodigo"].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvProdutos.Columns["clmPreco"].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvProdutos.Columns["clmEstoque"].HeaderCell.Style.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvProdutos.Columns["clmNome"].HeaderCell.Style.Alignment =
                   DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnEditCategoria_Click(object sender, EventArgs e)
        {
            using (var form = new FormCategoria())
            {
                form.Text = "Editando de categoria";
                form.txtNome.Text = cbCategoria.Text;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new EstoqueAPPContext())
                    {
                        Categoria categoria = (cbCategoria.SelectedItem as Categoria);
                        categoria.Nome = form.txtNome.Text;
                        db.Categorias.Attach(categoria);
                        db.Entry(categoria).State = EntityState.Modified;
                        AtualizarCBCategoria(db);
                        cbCategoria.SelectedItem = categoria;
                        db.SaveChanges();
                        AtualizarCBCategoria(db);
                        SimpleMessage.Inform("Categoria alterada com sucesso", "Informação");
                    }
                }
            }

        }

        private void btnDeleteCategoria_Click(object sender, EventArgs e)
        {
            if (SimpleMessage.Confirm("Deseja realmente excluir a categoria selecionada?", "Exclusão de categoria"))
            {
                using (var db = new EstoqueAPPContext())
                {
                    Categoria categoria = cbCategoria.SelectedItem as Categoria;
                    //Categoria cat = db.Categorias.Include(x => x.Produtos).
                    //FirstOrDefault(x => x.IdCategoria == categoria.IdCategoria);

                    int qntdeProdutos = db.Produtos.Where(x => x.IdCategoria == categoria.IdCategoria).Count();

                    //if (cat.Produtos.Count == 0)
                    if (qntdeProdutos == 0)
                    {
                        db.Attach(categoria);
                        db.Entry(categoria).State = EntityState.Deleted;
                        db.SaveChanges();
                        AtualizarCBCategoria(db);
                        SimpleMessage.Inform("Categoria excluída com sucesso", "Informação");
                    }
                    else
                    {
                        SimpleMessage.Error("Não é possível excluir uma categoria com produtos");
                    }
                };
            }
        }

        private void dgvProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormCategoriaProduto_Load(object sender, EventArgs e)
        {
            using (var db = new EstoqueAPPContext())
            {
                AtualizarCBCategoria(db);
            }
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            using (var form = new FormProduto())
            {
                form.Text = "Cadastro de produto";
                form.cbCategoria.SelectedIndex = cbCategoria.SelectedIndex;
                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new EstoqueAPPContext())
                    {
                        Produto produto = new Produto();
                        produto.Nome = form.txtNome.Text;
                        produto.Estoque = Convert.ToInt32(form.nudEstoque.Value);
                        produto.Preco = Convert.ToDouble(form.nudPreco.Value);
                        produto.IdCategoria = (form.cbCategoria.SelectedItem as Categoria).IdCategoria;
                        db.Produtos.Add(produto);
                        db.SaveChanges();
                        CarregaProdutos(db);
                        SimpleMessage.Inform("Produto cadastrado com sucesso.", "Informação");
                    }
                }
            }
        }

        private void btnEditProduto_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                linhaSelecionada = dgvProdutos.SelectedRows[0];
                Produto produto = linhaSelecionada.DataBoundItem as Produto;
                using (var form = new FormProduto())
                {
                    form.Text = "Editando produto";
                    form.txtNome.Text = produto.Nome;
                    form.nudEstoque.Value = produto.Estoque;
                    form.nudPreco.Value = Convert.ToDecimal(produto.Preco);
                    form.cbCategoria.SelectedIndex =
                        form.cbCategoria.FindString(produto.Categoria.Nome);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        using (var db = new EstoqueAPPContext())
                        {
                            produto.Nome = form.txtNome.Text;
                            produto.Estoque = Convert.ToInt32(form.nudEstoque.Value);
                            produto.Preco = Convert.ToDouble(form.nudPreco.Value);
                            produto.Categoria.IdCategoria =
                                (form.cbCategoria.SelectedItem as Categoria).IdCategoria;
                            db.Produtos.Attach(produto);
                            db.Entry(produto).State = EntityState.Modified;
                            db.SaveChanges();
                            CarregaProdutos(db);
                            SimpleMessage.Inform("Produto editado com sucesso.", "Informação");
                        }
                    }
                }
            }
        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new EstoqueAPPContext())
            {
                CarregaProdutos(db);
            }
        }

        private void dgvProdutos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnEditProduto_Click(null, null);
        }

        private void btnDeleteProduto_Click(object sender, EventArgs e)
        {
            DataGridViewRow linhaSelecionada = null;
            if (dgvProdutos.SelectedRows.Count > 0)
            {
                linhaSelecionada = dgvProdutos.SelectedRows[0];
                Produto produto = linhaSelecionada.DataBoundItem as Produto;
                if (SimpleMessage.Confirm(
                    "Deseja realmente excluir o produto selecionado?",
                    "Exclusão de produto"))
                {
                    using (var db = new EstoqueAPPContext())
                    {
                        db.Produtos.Attach(produto);
                        db.Entry(produto).State = EntityState.Deleted;
                        db.SaveChanges();
                        CarregaProdutos(db);
                        SimpleMessage.Inform("Produto excluído com sucesso", "Informação");
                    }

                }

            }
        }
    }
}
