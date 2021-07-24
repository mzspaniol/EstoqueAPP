
namespace EstoqueAPP
{
    partial class FormProduto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.btnEditCategoria = new System.Windows.Forms.Button();
            this.lblGridProdutos = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnDeleteCategoria = new System.Windows.Forms.Button();
            this.btnDeleteProduto = new System.Windows.Forms.Button();
            this.btnEditProduto = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(12, 9);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(58, 15);
            this.lblCategoria.TabIndex = 0;
            this.lblCategoria.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(12, 27);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(121, 23);
            this.cbCategoria.Sorted = true;
            this.cbCategoria.TabIndex = 1;
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.Location = new System.Drawing.Point(139, 27);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(48, 24);
            this.btnAddCategoria.TabIndex = 2;
            this.btnAddCategoria.Text = "Add";
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // btnEditCategoria
            // 
            this.btnEditCategoria.Location = new System.Drawing.Point(193, 27);
            this.btnEditCategoria.Name = "btnEditCategoria";
            this.btnEditCategoria.Size = new System.Drawing.Size(48, 24);
            this.btnEditCategoria.TabIndex = 4;
            this.btnEditCategoria.Text = "Edit";
            this.btnEditCategoria.UseVisualStyleBackColor = true;
            // 
            // lblGridProdutos
            // 
            this.lblGridProdutos.AutoSize = true;
            this.lblGridProdutos.Location = new System.Drawing.Point(12, 67);
            this.lblGridProdutos.Name = "lblGridProdutos";
            this.lblGridProdutos.Size = new System.Drawing.Size(188, 15);
            this.lblGridProdutos.TabIndex = 5;
            this.lblGridProdutos.Text = "Produtos da categoria selecionada";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(12, 85);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.Size = new System.Drawing.Size(793, 323);
            this.dgvProdutos.TabIndex = 6;
            // 
            // btnDeleteCategoria
            // 
            this.btnDeleteCategoria.Location = new System.Drawing.Point(247, 27);
            this.btnDeleteCategoria.Name = "btnDeleteCategoria";
            this.btnDeleteCategoria.Size = new System.Drawing.Size(48, 24);
            this.btnDeleteCategoria.TabIndex = 7;
            this.btnDeleteCategoria.Text = "Delete";
            this.btnDeleteCategoria.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduto
            // 
            this.btnDeleteProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduto.Location = new System.Drawing.Point(753, 55);
            this.btnDeleteProduto.Name = "btnDeleteProduto";
            this.btnDeleteProduto.Size = new System.Drawing.Size(48, 24);
            this.btnDeleteProduto.TabIndex = 10;
            this.btnDeleteProduto.Text = "Delete";
            this.btnDeleteProduto.UseVisualStyleBackColor = true;
            // 
            // btnEditProduto
            // 
            this.btnEditProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProduto.Location = new System.Drawing.Point(699, 55);
            this.btnEditProduto.Name = "btnEditProduto";
            this.btnEditProduto.Size = new System.Drawing.Size(48, 24);
            this.btnEditProduto.TabIndex = 9;
            this.btnEditProduto.Text = "Edit";
            this.btnEditProduto.UseVisualStyleBackColor = true;
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduto.Location = new System.Drawing.Point(642, 55);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(48, 24);
            this.btnAddProduto.TabIndex = 8;
            this.btnAddProduto.Text = "Add";
            this.btnAddProduto.UseVisualStyleBackColor = true;
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 420);
            this.Controls.Add(this.btnDeleteProduto);
            this.Controls.Add(this.btnEditProduto);
            this.Controls.Add(this.btnAddProduto);
            this.Controls.Add(this.btnDeleteCategoria);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.lblGridProdutos);
            this.Controls.Add(this.btnEditCategoria);
            this.Controls.Add(this.btnAddCategoria);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Name = "FormProduto";
            this.Text = "Controle de estoque com Entity Framework";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnAddCategoria;
        private System.Windows.Forms.Button btnEditCategoria;
        private System.Windows.Forms.Label lblGridProdutos;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnDeleteCategoria;
        private System.Windows.Forms.Button btnDeleteProduto;
        private System.Windows.Forms.Button btnEditProduto;
        private System.Windows.Forms.Button btnAddProduto;
    }
}

