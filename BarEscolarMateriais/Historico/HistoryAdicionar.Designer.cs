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
            label1 = new Label();
            nudqtd = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudqtd).BeginInit();
            SuspendLayout();
            // 
            // cbbUser
            // 
            cbbUser.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbUser.FormattingEnabled = true;
            cbbUser.Location = new Point(10, 67);
            cbbUser.Margin = new Padding(3, 2, 3, 2);
            cbbUser.Name = "cbbUser";
            cbbUser.Size = new Size(147, 23);
            cbbUser.TabIndex = 0;
            cbbUser.Click += cbbUser_Click;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(10, 50);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(30, 15);
            lbluser.TabIndex = 1;
            lbluser.Text = "User";
            // 
            // lblMateriais
            // 
            lblMateriais.AutoSize = true;
            lblMateriais.Location = new Point(10, 9);
            lblMateriais.Name = "lblMateriais";
            lblMateriais.Size = new Size(50, 15);
            lblMateriais.TabIndex = 2;
            lblMateriais.Text = "Material";
            // 
            // cbbMaterial
            // 
            cbbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaterial.FormattingEnabled = true;
            cbbMaterial.Location = new Point(10, 26);
            cbbMaterial.Margin = new Padding(3, 2, 3, 2);
            cbbMaterial.Name = "cbbMaterial";
            cbbMaterial.Size = new Size(147, 23);
            cbbMaterial.TabIndex = 3;
            cbbMaterial.Click += cbbMaterial_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(177, 100);
            btnInserir.Margin = new Padding(3, 2, 3, 2);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(146, 32);
            btnInserir.TabIndex = 11;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(10, 100);
            btnVoltar.Margin = new Padding(3, 2, 3, 2);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(146, 32);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 12;
            label1.Text = "Quantidade";
            // 
            // nudqtd
            // 
            nudqtd.Location = new Point(177, 27);
            nudqtd.Margin = new Padding(3, 2, 3, 2);
            nudqtd.Name = "nudqtd";
            nudqtd.Size = new Size(146, 23);
            nudqtd.TabIndex = 13;
            nudqtd.KeyPress += nudqtd_KeyPress;
            // 
            // HistoryAdicionar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 142);
            Controls.Add(nudqtd);
            Controls.Add(label1);
            Controls.Add(btnInserir);
            Controls.Add(btnVoltar);
            Controls.Add(cbbMaterial);
            Controls.Add(lblMateriais);
            Controls.Add(lbluser);
            Controls.Add(cbbUser);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "HistoryAdicionar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Venda";
            ((System.ComponentModel.ISupportInitialize)nudqtd).EndInit();
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
        private Label label1;
        private NumericUpDown nudqtd;
    }
}