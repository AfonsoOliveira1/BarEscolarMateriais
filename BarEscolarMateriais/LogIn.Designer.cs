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
            panel1.Location = new Point(326, -4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 760);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(24, 171);
            label1.Name = "label1";
            label1.Size = new Size(383, 35);
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
            txtPassword.LeadingIcon = Properties.Resources.password_76;
            txtPassword.Location = new Point(16, 476);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
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
            txtPassword.Size = new Size(398, 48);
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
            txtEmailorUsername.LeadingIcon = Properties.Resources._709699;
            txtEmailorUsername.Location = new Point(16, 352);
            txtEmailorUsername.Margin = new Padding(3, 4, 3, 4);
            txtEmailorUsername.MaxLength = 50;
            txtEmailorUsername.MouseState = MaterialSkin.MouseState.OUT;
            txtEmailorUsername.Multiline = false;
            txtEmailorUsername.Name = "txtEmailorUsername";
            txtEmailorUsername.Size = new Size(398, 50);
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
            btnInserir.Location = new Point(16, 616);
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(11, 0, 0, 0);
            btnInserir.Size = new Size(398, 63);
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
            lblpassword.Location = new Point(7, 423);
            lblpassword.Name = "lblpassword";
            lblpassword.Size = new Size(160, 46);
            lblpassword.TabIndex = 2;
            lblpassword.Text = "Password";
            // 
            // lblemail
            // 
            lblemail.AutoSize = true;
            lblemail.Font = new Font("Segoe UI", 20F);
            lblemail.ForeColor = SystemColors.ActiveCaptionText;
            lblemail.Location = new Point(7, 299);
            lblemail.Name = "lblemail";
            lblemail.Size = new Size(262, 46);
            lblemail.TabIndex = 1;
            lblemail.Text = "Email/Username";
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI Semibold", 50F, FontStyle.Bold);
            lblLogin.ForeColor = SystemColors.ActiveCaptionText;
            lblLogin.Location = new Point(97, 16);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(260, 112);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1083, 749);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += LogIn_FormClosing;
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