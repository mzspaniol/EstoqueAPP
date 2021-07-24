
namespace EstoqueAPP
{
    partial class FormCategoriaProduto
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoriaProduto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.btnAddCategoria = new System.Windows.Forms.Button();
            this.imgListIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnEditCategoria = new System.Windows.Forms.Button();
            this.lblGridProdutos = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnDeleteCategoria = new System.Windows.Forms.Button();
            this.btnDeleteProduto = new System.Windows.Forms.Button();
            this.btnEditProduto = new System.Windows.Forms.Button();
            this.btnAddProduto = new System.Windows.Forms.Button();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPreco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // btnAddCategoria
            // 
            this.btnAddCategoria.ImageIndex = 0;
            this.btnAddCategoria.ImageList = this.imgListIcons;
            this.btnAddCategoria.Location = new System.Drawing.Point(139, 27);
            this.btnAddCategoria.Name = "btnAddCategoria";
            this.btnAddCategoria.Size = new System.Drawing.Size(24, 24);
            this.btnAddCategoria.TabIndex = 2;
            this.btnAddCategoria.UseVisualStyleBackColor = true;
            this.btnAddCategoria.Click += new System.EventHandler(this.btnAddCategoria_Click);
            // 
            // imgListIcons
            // 
            this.imgListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListIcons.ImageStream")));
            this.imgListIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListIcons.Images.SetKeyName(0, "Add.png");
            this.imgListIcons.Images.SetKeyName(1, "Delete.png");
            this.imgListIcons.Images.SetKeyName(2, "Edit.png");
            // 
            // btnEditCategoria
            // 
            this.btnEditCategoria.ImageIndex = 2;
            this.btnEditCategoria.ImageList = this.imgListIcons;
            this.btnEditCategoria.Location = new System.Drawing.Point(169, 27);
            this.btnEditCategoria.Name = "btnEditCategoria";
            this.btnEditCategoria.Size = new System.Drawing.Size(24, 24);
            this.btnEditCategoria.TabIndex = 4;
            this.btnEditCategoria.UseVisualStyleBackColor = true;
            this.btnEditCategoria.Click += new System.EventHandler(this.btnEditCategoria_Click);
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
            this.dgvProdutos.AllowUserToAddRows = false;
            this.dgvProdutos.AllowUserToDeleteRows = false;
            this.dgvProdutos.AllowUserToResizeColumns = false;
            this.dgvProdutos.AllowUserToResizeRows = false;
            this.dgvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProdutos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNome,
            this.clmPreco,
            this.clmEstoque});
            this.dgvProdutos.Location = new System.Drawing.Point(12, 85);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.ReadOnly = true;
            this.dgvProdutos.RowHeadersVisible = false;
            this.dgvProdutos.RowTemplate.Height = 25;
            this.dgvProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProdutos.Size = new System.Drawing.Size(363, 323);
            this.dgvProdutos.TabIndex = 6;
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // btnDeleteCategoria
            // 
            this.btnDeleteCategoria.ImageIndex = 1;
            this.btnDeleteCategoria.ImageList = this.imgListIcons;
            this.btnDeleteCategoria.Location = new System.Drawing.Point(199, 27);
            this.btnDeleteCategoria.Name = "btnDeleteCategoria";
            this.btnDeleteCategoria.Size = new System.Drawing.Size(24, 24);
            this.btnDeleteCategoria.TabIndex = 7;
            this.btnDeleteCategoria.UseVisualStyleBackColor = true;
            this.btnDeleteCategoria.Click += new System.EventHandler(this.btnDeleteCategoria_Click);
            // 
            // btnDeleteProduto
            // 
            this.btnDeleteProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProduto.ImageIndex = 1;
            this.btnDeleteProduto.ImageList = this.imgListIcons;
            this.btnDeleteProduto.Location = new System.Drawing.Point(350, 55);
            this.btnDeleteProduto.Name = "btnDeleteProduto";
            this.btnDeleteProduto.Size = new System.Drawing.Size(24, 24);
            this.btnDeleteProduto.TabIndex = 10;
            this.btnDeleteProduto.UseVisualStyleBackColor = true;
            // 
            // btnEditProduto
            // 
            this.btnEditProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditProduto.ImageIndex = 2;
            this.btnEditProduto.ImageList = this.imgListIcons;
            this.btnEditProduto.Location = new System.Drawing.Point(320, 55);
            this.btnEditProduto.Name = "btnEditProduto";
            this.btnEditProduto.Size = new System.Drawing.Size(24, 24);
            this.btnEditProduto.TabIndex = 9;
            this.btnEditProduto.UseVisualStyleBackColor = true;
            this.btnEditProduto.Click += new System.EventHandler(this.btnEditProduto_Click);
            // 
            // btnAddProduto
            // 
            this.btnAddProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddProduto.ImageKey = "Add.png";
            this.btnAddProduto.ImageList = this.imgListIcons;
            this.btnAddProduto.Location = new System.Drawing.Point(290, 55);
            this.btnAddProduto.Name = "btnAddProduto";
            this.btnAddProduto.Size = new System.Drawing.Size(24, 24);
            this.btnAddProduto.TabIndex = 8;
            this.btnAddProduto.UseVisualStyleBackColor = true;
            this.btnAddProduto.Click += new System.EventHandler(this.btnAddProduto_Click);
            // 
            // clmCodigo
            // 
            this.clmCodigo.DataPropertyName = "IdProduto";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Format = "D4";
            this.clmCodigo.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmCodigo.HeaderText = "Código";
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.ReadOnly = true;
            this.clmCodigo.Width = 70;
            // 
            // clmNome
            // 
            this.clmNome.DataPropertyName = "Nome";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.clmNome.DefaultCellStyle = dataGridViewCellStyle3;
            this.clmNome.HeaderText = "Nome do produto";
            this.clmNome.Name = "clmNome";
            this.clmNome.ReadOnly = true;
            this.clmNome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmNome.Width = 150;
            // 
            // clmPreco
            // 
            this.clmPreco.DataPropertyName = "Preco";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            this.clmPreco.DefaultCellStyle = dataGridViewCellStyle4;
            this.clmPreco.FillWeight = 70F;
            this.clmPreco.HeaderText = "Preço";
            this.clmPreco.Name = "clmPreco";
            this.clmPreco.ReadOnly = true;
            this.clmPreco.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmPreco.Width = 70;
            // 
            // clmEstoque
            // 
            this.clmEstoque.DataPropertyName = "Estoque";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "D4";
            this.clmEstoque.DefaultCellStyle = dataGridViewCellStyle5;
            this.clmEstoque.HeaderText = "Estoque";
            this.clmEstoque.Name = "clmEstoque";
            this.clmEstoque.ReadOnly = true;
            this.clmEstoque.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clmEstoque.Width = 70;
            // 
            // FormCategoriaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 420);
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
            this.Name = "FormCategoriaProduto";
            this.Text = "Controle de estoque com Entity Framework";
            this.Load += new System.EventHandler(this.FormCategoriaProduto_Load);
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
        private System.Windows.Forms.ImageList imgListIcons;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPreco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmEstoque;
    }
}

