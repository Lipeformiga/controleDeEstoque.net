namespace ControleEstoqueApp
{
    partial class FrmControleDeEstoque
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
            txtNome = new TextBox();
            txtQuantidade = new TextBox();
            txtID = new TextBox();
            txtPreco = new TextBox();
            lblId = new Label();
            lblNome = new Label();
            lblQuantidade = new Label();
            lblPreco = new Label();
            dtgEstoque = new DataGridView();
            label1 = new Label();
            btnSalvar = new Button();
            btnExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).BeginInit();
            SuspendLayout();
            // 
            // txtNome
            // 
            txtNome.Location = new Point(108, 149);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(221, 23);
            txtNome.TabIndex = 0;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(108, 214);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(221, 23);
            txtQuantidade.TabIndex = 1;
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(108, 92);
            txtID.Name = "txtID";
            txtID.Size = new Size(221, 23);
            txtID.TabIndex = 2;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(108, 276);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(221, 23);
            txtPreco.TabIndex = 3;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(108, 74);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 4;
            lblId.Text = "ID:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(108, 131);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(43, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome:";
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(108, 196);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(72, 15);
            lblQuantidade.TabIndex = 6;
            lblQuantidade.Text = "Quantidade:";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(108, 258);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(40, 15);
            lblPreco.TabIndex = 7;
            lblPreco.Text = "Preço:";
            // 
            // dtgEstoque
            // 
            dtgEstoque.BackgroundColor = SystemColors.ActiveCaptionText;
            dtgEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgEstoque.Location = new Point(470, 12);
            dtgEstoque.Name = "dtgEstoque";
            dtgEstoque.ReadOnly = true;
            dtgEstoque.Size = new Size(444, 353);
            dtgEstoque.TabIndex = 10;
            dtgEstoque.CellDoubleClick += dtgEstoque_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Elephant", 20.2499962F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(85, 12);
            label1.Name = "label1";
            label1.Size = new Size(297, 35);
            label1.TabIndex = 11;
            label1.Text = "Controle de estoque";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(108, 324);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 12;
            btnSalvar.Text = "SALVAR";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click_1;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(254, 324);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // FrmControleDeEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(926, 377);
            Controls.Add(btnExcluir);
            Controls.Add(btnSalvar);
            Controls.Add(label1);
            Controls.Add(dtgEstoque);
            Controls.Add(lblPreco);
            Controls.Add(lblQuantidade);
            Controls.Add(lblNome);
            Controls.Add(lblId);
            Controls.Add(txtPreco);
            Controls.Add(txtID);
            Controls.Add(txtQuantidade);
            Controls.Add(txtNome);
            Name = "FrmControleDeEstoque";
            Text = "Controle de Estoque";
            Load += FrmControleDeEstoque_Load;
            ((System.ComponentModel.ISupportInitialize)dtgEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNome;
        private TextBox txtQuantidade;
        private TextBox txtID;
        private TextBox txtPreco;
        private Label lblId;
        private Label lblNome;
        private Label lblQuantidade;
        private Label lblPreco;
        private DataGridView dtgEstoque;
        private Label label1;
        private Button btnSalvar;
        private Button btnExcluir;
    }
}
