namespace BarEscolarMateriais.MateriaisForms
{
    partial class MateriaisAdicionar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            txtName = new TextBox();
            lblCategory = new Label();
            cbbCategory = new ComboBox();
            lblPreco = new Label();
            nudPrice = new NumericUpDown();
            txtDescription = new TextBox();
            lblDescricao = new Label();
            btnVoltar = new Button();
            btnInserir = new Button();
            lblStock = new Label();
            txtStock = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Nome";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 27);
            txtName.TabIndex = 1;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 68);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(74, 20);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Categoria";
            // 
            // cbbCategory
            // 
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(12, 91);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(174, 28);
            cbbCategory.TabIndex = 3;
            cbbCategory.SelectedIndexChanged += cbbCategory_SelectedIndexChanged;
            cbbCategory.Click += cbbCategory_Click;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(190, 68);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço";
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(192, 91);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(150, 27);
            nudPrice.TabIndex = 5;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 155);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(330, 105);
            txtDescription.TabIndex = 6;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 132);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 7;
            lblDescricao.Text = "Descrição";
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 268);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(155, 34);
            btnVoltar.TabIndex = 8;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(187, 268);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(155, 34);
            btnInserir.TabIndex = 9;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(190, 9);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 22;
            lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(190, 32);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(152, 27);
            txtStock.TabIndex = 23;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // MateriaisAdicionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(354, 314);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(btnInserir);
            Controls.Add(btnVoltar);
            Controls.Add(lblDescricao);
            Controls.Add(txtDescription);
            Controls.Add(nudPrice);
            Controls.Add(lblPreco);
            Controls.Add(cbbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MateriaisAdicionar";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Material";
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblCategory;
        private ComboBox cbbCategory;
        private Label lblPreco;
        private NumericUpDown nudPrice;
        private TextBox txtDescription;
        private Label lblDescricao;
        private Button btnVoltar;
        private Button btnInserir;
        private Label lblStock;
        private TextBox txtStock;
    }
}