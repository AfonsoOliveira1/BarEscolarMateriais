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
            label1 = new Label();
            txtPassword = new MaterialSkin.Controls.MaterialMaskedTextBox();
            txtEmailorUsername = new MaterialSkin.Controls.MaterialTextBox();
            btnInserir = new Button();
            lblpassword = new Label();
            lblemail = new Label();
            lblLogin = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmailorUsername);
            panel1.Controls.Add(btnInserir);
            panel1.Controls.Add(lblpassword);
            panel1.Controls.Add(lblemail);
            panel1.Controls.Add(lblLogin);
            panel1.Location = new Point(285, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 570);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(37, 128);
            label1.Name = "label1";
            label1.Size = new Size(300, 28);
            label1.TabIndex = 4;
            label1.Text = "Gestão de Materiais para Admins";
            // 
            // txtPassword
            // 
            txtPassword.AllowPromptAsInput = true;
            txtPassword.AnimateReadOnly = false;
            txtPassword.AsciiOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.BeepOnError = false;
            txtPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HidePromptOnLeave = false;
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Enter Password";
            txtPassword.InsertKeyMode = InsertKeyMode.Default;
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(14, 357);
            txtPassword.Mask = "";
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = MaterialSkin.MouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PrefixSuffixText = null;
            txtPassword.PromptChar = '_';
            txtPassword.ReadOnly = false;
            txtPassword.RejectInputOnFirstFailure = false;
            txtPassword.ResetOnPrompt = true;
            txtPassword.ResetOnSpace = true;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(348, 48);
            txtPassword.SkipLiterals = true;
            txtPassword.TabIndex = 2;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.ValidatingType = null;
            // 
            // txtEmailorUsername
            // 
            txtEmailorUsername.AnimateReadOnly = false;
            txtEmailorUsername.BorderStyle = BorderStyle.None;
            txtEmailorUsername.Depth = 0;
            txtEmailorUsername.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmailorUsername.ForeColor = SystemColors.Window;
            txtEmailorUsername.Hint = "Enter Email or Username";
            txtEmailorUsername.LeadingIcon = null;
            txtEmailorUsername.Location = new Point(14, 264);
            txtEmailorUsername.MaxLength = 50;
            txtEmailorUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtEmailorUsername.Multiline = false;
            txtEmailorUsername.Name = "txtEmailorUsername";
            txtEmailorUsername.Size = new Size(348, 50);
            txtEmailorUsername.TabIndex = 1;
            txtEmailorUsername.Text = "";
            txtEmailorUsername.TrailingIcon = null;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = Color.Black;
            btnInserir.FlatAppearance.BorderSize = 0;
            btnInserir.FlatStyle = FlatStyle.Flat;
            btnInserir.Font = new Font("Segoe UI", 14F);
            btnInserir.ForeColor = Color.Gainsboro;
            btnInserir.ImageAlign = ContentAlignment.MiddleLeft;
            btnInserir.Location = new Point(14, 462);
            btnInserir.Margin = new Padding(3, 2, 3, 2);
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(10, 0, 0, 0);
            btnInserir.Size = new Size(348, 47);
            btnInserir.TabIndex = 3;
            btnInserir.Text = "Inserir";
            btnInserir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // lblpassword
            // 
            lblpassword.AutoSize = true;
            lblpassword.Font = new Font("Segoe UI", 20F);
            lblpassword.ForeColor = SystemColors.ActiveCaptionText;
            lblpassword.Location = new Point(6, 317);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(128, 37);
            lblpassword.TabIndex = 2;
            lblpassword.Text = "Password";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 20F);
            lblemail.ForeColor = SystemColors.ActiveCaptionText;
            lblemail.Location = new Point(6, 224);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(212, 37);
            lblemail.TabIndex = 1;
            lblemail.Text = "Email/Username";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 50F, FontStyle.Bold);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(85, 12);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(208, 89);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(948, 562);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblemail;
        private Label lblLogin;
        private Label lblpassword;
        private Button btnInserir;
        private MaterialSkin.Controls.MaterialTextBox txtEmailorUsername;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtPassword;
        private Label label1;
    }
}