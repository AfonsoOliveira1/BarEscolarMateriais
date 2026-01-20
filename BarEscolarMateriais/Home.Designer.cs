namespace BarEscolarMateriais
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panelmenu = new Panel();
            btnLog = new Button();
            btnHistorico = new Button();
            btnCategory = new Button();
            btnMateriais = new Button();
            panellogo = new Panel();
            lblhome = new Label();
            panel1 = new Panel();
            lblEcra = new Label();
            panelmenu.SuspendLayout();
            panellogo.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelmenu
            // 
            panelmenu.BackColor = Color.FromArgb(51, 51, 76);
            panelmenu.Controls.Add(btnLog);
            panelmenu.Controls.Add(btnHistorico);
            panelmenu.Controls.Add(btnCategory);
            panelmenu.Controls.Add(btnMateriais);
            panelmenu.Controls.Add(panellogo);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(200, 450);
            panelmenu.TabIndex = 5;
            // 
            // btnLog
            // 
            btnLog.Dock = DockStyle.Bottom;
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Segoe UI", 14F);
            btnLog.ForeColor = Color.Gainsboro;
            btnLog.Image = (Image)resources.GetObject("btnLog.Image");
            btnLog.ImageAlign = ContentAlignment.MiddleLeft;
            btnLog.Location = new Point(0, 375);
            btnLog.Margin = new Padding(3, 2, 3, 2);
            btnLog.Name = "btnLog";
            btnLog.Padding = new Padding(10, 0, 0, 0);
            btnLog.Size = new Size(200, 75);
            btnLog.TabIndex = 8;
            btnLog.Text = "   Log Out";
            btnLog.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLog.UseVisualStyleBackColor = true;
            btnLog.Click += btnLog_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.Dock = DockStyle.Top;
            btnHistorico.FlatAppearance.BorderSize = 0;
            btnHistorico.FlatStyle = FlatStyle.Flat;
            btnHistorico.Font = new Font("Segoe UI", 14F);
            btnHistorico.ForeColor = Color.Gainsboro;
            btnHistorico.Image = (Image)resources.GetObject("btnHistorico.Image");
            btnHistorico.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistorico.Location = new Point(0, 228);
            btnHistorico.Margin = new Padding(3, 2, 3, 2);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Padding = new Padding(10, 0, 0, 0);
            btnHistorico.Size = new Size(200, 75);
            btnHistorico.TabIndex = 7;
            btnHistorico.Text = "   Historico";
            btnHistorico.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistorico.UseVisualStyleBackColor = true;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // btnCategory
            // 
            btnCategory.Dock = DockStyle.Top;
            btnCategory.FlatAppearance.BorderSize = 0;
            btnCategory.FlatStyle = FlatStyle.Flat;
            btnCategory.Font = new Font("Segoe UI", 14F);
            btnCategory.ForeColor = Color.Gainsboro;
            btnCategory.Image = (Image)resources.GetObject("btnCategory.Image");
            btnCategory.ImageAlign = ContentAlignment.MiddleLeft;
            btnCategory.Location = new Point(0, 153);
            btnCategory.Margin = new Padding(3, 2, 3, 2);
            btnCategory.Name = "btnCategory";
            btnCategory.Padding = new Padding(10, 0, 0, 0);
            btnCategory.Size = new Size(200, 75);
            btnCategory.TabIndex = 6;
            btnCategory.Text = "   Categories";
            btnCategory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnMateriais
            // 
            btnMateriais.Dock = DockStyle.Top;
            btnMateriais.FlatAppearance.BorderSize = 0;
            btnMateriais.FlatStyle = FlatStyle.Flat;
            btnMateriais.Font = new Font("Segoe UI", 14F);
            btnMateriais.ForeColor = Color.Gainsboro;
            btnMateriais.Image = (Image)resources.GetObject("btnMateriais.Image");
            btnMateriais.ImageAlign = ContentAlignment.MiddleLeft;
            btnMateriais.Location = new Point(0, 78);
            btnMateriais.Margin = new Padding(3, 2, 3, 2);
            btnMateriais.Name = "btnMateriais";
            btnMateriais.Padding = new Padding(10, 0, 0, 0);
            btnMateriais.Size = new Size(200, 75);
            btnMateriais.TabIndex = 3;
            btnMateriais.Text = "   Materiais";
            btnMateriais.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMateriais.UseVisualStyleBackColor = true;
            btnMateriais.Click += btnMateriais_Click;
            // 
            // panellogo
            // 
            panellogo.BackColor = Color.FromArgb(39, 39, 59);
            panellogo.Controls.Add(lblhome);
            panellogo.Dock = DockStyle.Top;
            panellogo.Location = new Point(0, 0);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(200, 78);
            panellogo.TabIndex = 5;
            // 
            // lblhome
            // 
            lblhome.AutoSize = true;
            lblhome.Font = new Font("Segoe UI", 30F);
            lblhome.ForeColor = Color.Gainsboro;
            lblhome.Location = new Point(25, 12);
            lblhome.Name = "lblhome";
            lblhome.Size = new Size(137, 54);
            lblhome.TabIndex = 7;
            lblhome.Text = "HOME";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(lblEcra);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(200, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(600, 78);
            panel1.TabIndex = 6;
            // 
            // lblEcra
            // 
            lblEcra.Anchor = AnchorStyles.None;
            lblEcra.AutoSize = true;
            lblEcra.Font = new Font("Segoe UI", 30F);
            lblEcra.ForeColor = Color.Gainsboro;
            lblEcra.Location = new Point(225, 9);
            lblEcra.Name = "lblEcra";
            lblEcra.Size = new Size(137, 54);
            lblEcra.TabIndex = 0;
            lblEcra.Text = "HOME";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelmenu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            panelmenu.ResumeLayout(false);
            panellogo.ResumeLayout(false);
            panellogo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelmenu;
        private Button btnLog;
        private Button btnHistorico;
        private Button btnCategory;
        private Button btnMateriais;
        private Panel panellogo;
        private Panel panel1;
        private Label lblEcra;
        private Label lblhome;
    }
}