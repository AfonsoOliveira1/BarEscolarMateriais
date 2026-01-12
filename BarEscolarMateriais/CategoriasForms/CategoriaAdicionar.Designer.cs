namespace BarEscolarMateriais.CategoriasForms
{
    partial class CategoriaAdicionar
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
            btnAdicionar = new Button();
            btnVoltar = new Button();
            lblDescricao = new Label();
            txtDescription = new TextBox();
            txtName = new TextBox();
            lblName = new Label();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(187, 198);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(155, 34);
            btnAdicionar.TabIndex = 29;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 198);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(155, 34);
            btnVoltar.TabIndex = 28;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 62);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(74, 20);
            lblDescricao.TabIndex = 27;
            lblDescricao.Text = "Descrição";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 85);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(330, 105);
            txtDescription.TabIndex = 26;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 32);
            txtName.Name = "txtName";
            txtName.Size = new Size(330, 27);
            txtName.TabIndex = 21;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(50, 20);
            lblName.TabIndex = 20;
            lblName.Text = "Nome";
            // 
            // CategoriaAdicionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 242);
            Controls.Add(btnAdicionar);
            Controls.Add(btnVoltar);
            Controls.Add(lblDescricao);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "CategoriaAdicionar";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Categoria";
            Load += CategoriaAdicionar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdicionar;
        private Button btnVoltar;
        private Label lblDescricao;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label lblName;
    }
}