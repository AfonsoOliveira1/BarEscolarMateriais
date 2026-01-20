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
            panel1.Location = new Point(38, 33);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 597);
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
            btnInserir.Location = new Point(16, 507);
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(11, 0, 0, 0);
            btnInserir.Size = new Size(398, 63);
            btnInserir.TabIndex = 5;
            btnInserir.Text = "Inserir";
            btnInserir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 20F);
            txtPassword.Location = new Point(16, 389);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Escreva a sua Password";
            txtPassword.Size = new Size(398, 55);
            txtPassword.TabIndex = 4;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 20F);
            txtEmail.Location = new Point(16, 232);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email ou Username";
            txtEmail.Size = new Size(398, 52);
            txtEmail.TabIndex = 3;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Segoe UI", 20F);
            lblpassword.ForeColor = Color.Gainsboro;
            lblpassword.Location = new Point(3, 339);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(160, 46);
            lblpassword.TabIndex = 2;
            lblpassword.Text = "Password";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 20F);
            lblemail.ForeColor = Color.Gainsboro;
            lblemail.Location = new Point(3, 182);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(262, 46);
            lblemail.TabIndex = 1;
            lblemail.Text = "Email/Username";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 50F, FontStyle.Bold);
            lblLogin.ForeColor = Color.Gainsboro;
            lblLogin.Location = new Point(80, 17);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(260, 112);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 51, 76);
            ClientSize = new Size(504, 665);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
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