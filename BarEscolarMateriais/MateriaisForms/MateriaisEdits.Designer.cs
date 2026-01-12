namespace BarEscolarMateriais.MateriaisForms
{
    partial class MateriaisEdits
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
            btnEditar = new Button();
            btnVoltar = new Button();
            lblDescricao = new Label();
            txtDescription = new TextBox();
            nudPrice = new NumericUpDown();
            lblPreco = new Label();
            cbbCategory = new ComboBox();
            lblCategory = new Label();
            txtName = new TextBox();
            lblName = new Label();
            lblStock = new Label();
            txtStock = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudPrice).BeginInit();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(187, 268);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(155, 34);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 268);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(155, 34);
            btnVoltar.TabIndex = 18;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 132);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 17;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 155);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(330, 105);
            txtDescription.TabIndex = 16;
            // 
            // nudPrice
            // 
            nudPrice.Location = new Point(192, 91);
            nudPrice.Name = "nudPrice";
            nudPrice.Size = new Size(150, 27);
            nudPrice.TabIndex = 15;
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(190, 68);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(46, 20);
            lblPreco.TabIndex = 14;
            lblPreco.Text = "Preço";
            // 
            // cbbCategory
            // 
            cbbCategory.FormattingEnabled = true;
            cbbCategory.Location = new Point(12, 91);
            cbbCategory.Name = "cbbCategory";
            cbbCategory.Size = new Size(174, 28);
            cbbCategory.TabIndex = 13;
            cbbCategory.Click += cbbCategory_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(12, 68);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(74, 20);
            lblCategory.TabIndex = 12;
            lblCategory.Text = "Categoria";
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(174, 27);
            txtName.TabIndex = 11;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 10;
            lblName.Text = "Nome";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(192, 9);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(45, 20);
            lblStock.TabIndex = 20;
            lblStock.Text = "Stock";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(192, 32);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(150, 27);
            txtStock.TabIndex = 24;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // MateriaisEdits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 318);
            Controls.Add(txtStock);
            Controls.Add(lblStock);
            Controls.Add(btnEditar);
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
            Name = "MateriaisEdits";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Material";
            ((System.ComponentModel.ISupportInitialize)nudPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditar;
        private Button btnVoltar;
        private Label lblDescricao;
        private TextBox txtDescription;
        private NumericUpDown nudPrice;
        private Label lblPreco;
        private ComboBox cbbCategory;
        private Label lblCategory;
        private TextBox txtName;
        private Label lblName;
        private Label lblStock;
        private TextBox txtStock;
    }
}