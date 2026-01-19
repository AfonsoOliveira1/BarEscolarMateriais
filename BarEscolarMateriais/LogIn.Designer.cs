namespace BarEscolarMateriais
{
    partial class LogIn
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
            panel1 = new Panel();
            btnInserir = new Button();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lblpassword = new Label();
            lblemail = new Label();
            lblLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 39, 59);
            panel1.Controls.Add(btnInserir);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(lblpassword);
            panel1.Controls.Add(lblemail);
            panel1.Controls.Add(lblLogin);
            panel1.Location = new Point(33, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(347, 448);
            panel1.TabIndex = 0;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.FromArgb(51, 51, 76);
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Segoe UI", 14F);
            btnInserir.ForeColor = Color.Gainsboro;
            btnInserir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInserir.Location = new Point(14, 380);
            btnInserir.Margin = new Padding(3, 2, 3, 2);
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(10, 0, 0, 0);
            btnInserir.Size = new Size(309, 47);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "Inserir";
            btnInserir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 20F);
            txtPassword.Location = new Point(14, 292);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Escreva a sua Password";
            txtPassword.Size = new Size(309, 42);
            txtPassword.TabIndex = 4;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 20F);
            txtEmail.Location = new Point(14, 184);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Escreva o seu Email";
            txtEmail.Size = new Size(309, 40);
            txtEmail.TabIndex = 3;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Segoe UI", 30F);
            lblpassword.ForeColor = Color.Gainsboro;
            lblpassword.Location = new Point(3, 235);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(188, 54);
            lblpassword.TabIndex = 2;
            lblpassword.Text = "Password";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 30F);
            lblemail.ForeColor = Color.Gainsboro;
            lblemail.Location = new Point(3, 127);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(117, 54);
            lblemail.TabIndex = 1;
            lblemail.Text = "Email";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 50F, FontStyle.Bold);
            lblLogin.ForeColor = Color.Gainsboro;
            lblLogin.Location = new Point(70, 13);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(208, 89);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(423, 499);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblemail;
        private Label lblLogin;
        private TextBox txtEmail;
        private Label lblpassword;
        private TextBox txtPassword;
        private Button btnInserir;
    }
}