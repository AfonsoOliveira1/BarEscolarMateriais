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
            cbbUser.Location = new Point(12, 89);
            cbbUser.Name = "cbbUser";
            cbbUser.Size = new Size(167, 28);
            cbbUser.TabIndex = 0;
            cbbUser.Click += cbbUser_Click;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Location = new Point(12, 66);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(38, 20);
            lbluser.TabIndex = 1;
            lbluser.Text = "User";
            // 
            // lblMateriais
            // 
            lblMateriais.AutoSize = true;
            lblMateriais.Location = new Point(12, 12);
            lblMateriais.Name = "lblMateriais";
            lblMateriais.Size = new Size(64, 20);
            lblMateriais.TabIndex = 2;
            lblMateriais.Text = "Material";
            // 
            // cbbMaterial
            // 
            cbbMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaterial.FormattingEnabled = true;
            cbbMaterial.Location = new Point(12, 35);
            cbbMaterial.Name = "cbbMaterial";
            cbbMaterial.Size = new Size(167, 28);
            cbbMaterial.TabIndex = 3;
            cbbMaterial.Click += cbbMaterial_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(202, 134);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(167, 42);
            btnInserir.TabIndex = 11;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 134);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(167, 42);
            btnVoltar.TabIndex = 10;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(202, 12);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 12;
            label1.Text = "Quantidade";
            // 
            // nudqtd
            // 
            nudqtd.Location = new Point(202, 36);
            nudqtd.Name = "nudqtd";
            nudqtd.Size = new Size(167, 27);
            nudqtd.TabIndex = 13;
            // 
            // HistoryAdicionar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 189);
            Controls.Add(nudqtd);
            Controls.Add(label1);
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