namespace BarEscolarMateriais.Historico
{
    partial class HistoryAdicionar
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
            cbbUser = new ComboBox();
            lbluser = new Label();
            lblMateriais = new Label();
            cbbMaterial = new ComboBox();
            btnInserir = new Button();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // cbbUser
            // 
            cbbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbUser.FormattingEnabled = true;
            cbbUser.Location = new Point(12, 32);
            cbbUser.Name = "cbbUser";
            cbbUser.Size = new Size(167, 28);
            cbbUser.TabIndex = 0;
            cbbUser.Click += cbbUser_Click;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(12, 9);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(38, 20);
            lbluser.TabIndex = 1;
            lbluser.Text = "User";
            // 
            // lblMateriais
            // 
            lblMateriais.AutoSize = true;
            lblMateriais.Location = new Point(202, 9);
            lblMateriais.Name = "lblMateriais";
            lblMateriais.Size = new Size(64, 20);
            lblMateriais.TabIndex = 2;
            lblMateriais.Text = "Material";
            // 
            // cbbMaterial
            // 
            cbbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaterial.FormattingEnabled = true;
            cbbMaterial.Location = new Point(202, 32);
            cbbMaterial.Name = "cbbMaterial";
            cbbMaterial.Size = new Size(167, 28);
            cbbMaterial.TabIndex = 3;
            cbbMaterial.Click += cbbMaterial_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(202, 81);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(167, 42);
            btnInserir.TabIndex = 11;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 81);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(167, 42);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // HistoryAdicionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 135);
            Controls.Add(btnInserir);
            Controls.Add(btnVoltar);
            Controls.Add(cbbMaterial);
            Controls.Add(lblMateriais);
            Controls.Add(lbluser);
            Controls.Add(cbbUser);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "HistoryAdicionar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Venda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbUser;
        private Label lbluser;
        private Label lblMateriais;
        private ComboBox cbbMaterial;
        private Button btnInserir;
        private Button btnVoltar;
    }
}