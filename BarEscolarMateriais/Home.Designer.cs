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
            lbluser = new Label();
            lblEcra = new Label();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            lblTotalCat = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            lblTotalMat = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            materialCard3 = new MaterialSkin.Controls.MaterialCard();
            lblTotalVendas = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            materialCard4 = new MaterialSkin.Controls.MaterialCard();
            lblStockTotalValue = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            panelMain = new Panel();
            materialCard5 = new MaterialSkin.Controls.MaterialCard();
            lblmateriaissemstock = new Label();
            label8 = new Label();
            label11 = new Label();
            pictureBox5 = new PictureBox();
            panelmenu.SuspendLayout();
            panellogo.SuspendLayout();
            panel1.SuspendLayout();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panelMain.SuspendLayout();
            materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
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
            panelmenu.Margin = new Padding(3, 4, 3, 4);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(229, 600);
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
            btnLog.Location = new Point(0, 500);
            btnLog.Name = "btnLog";
            btnLog.Padding = new Padding(11, 0, 0, 0);
            btnLog.Size = new Size(229, 100);
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
            btnHistorico.Location = new Point(0, 304);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Padding = new Padding(11, 0, 0, 0);
            btnHistorico.Size = new Size(229, 100);
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
            btnCategory.Location = new Point(0, 204);
            btnCategory.Name = "btnCategory";
            btnCategory.Padding = new Padding(11, 0, 0, 0);
            btnCategory.Size = new Size(229, 100);
            btnCategory.TabIndex = 6;
            btnCategory.Text = "   Categorias";
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
            btnMateriais.Location = new Point(0, 104);
            btnMateriais.Name = "btnMateriais";
            btnMateriais.Padding = new Padding(11, 0, 0, 0);
            btnMateriais.Size = new Size(229, 100);
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
            panellogo.Margin = new Padding(3, 4, 3, 4);
            panellogo.Name = "panellogo";
            panellogo.Size = new Size(229, 104);
            panellogo.TabIndex = 5;
            // 
            // lblhome
            // 
            lblhome.AutoSize = true;
            lblhome.Font = new Font("Segoe UI", 30F);
            lblhome.ForeColor = Color.Gainsboro;
            lblhome.Location = new Point(29, 16);
            lblhome.Name = "lblhome";
            lblhome.Size = new Size(173, 67);
            lblhome.TabIndex = 7;
            lblhome.Text = "HOME";
            lblhome.Click += lblhome_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(lbluser);
            panel1.Controls.Add(lblEcra);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(229, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(685, 104);
            panel1.TabIndex = 6;
            // 
            // lbluser
            // 
            lbluser.AutoSize = true;
            lbluser.Font = new Font("Segoe UI", 20F);
            lbluser.ForeColor = Color.Gainsboro;
            lbluser.Location = new Point(7, 29);
            lbluser.Name = "lbluser";
            lbluser.Size = new Size(87, 46);
            lbluser.TabIndex = 8;
            lbluser.Text = "User";
            // 
            // lblEcra
            // 
            lblEcra.Anchor = AnchorStyles.None;
            lblEcra.AutoSize = true;
            lblEcra.Font = new Font("Segoe UI", 30F);
            lblEcra.ForeColor = Color.Gainsboro;
            lblEcra.Location = new Point(273, 16);
            lblEcra.Name = "lblEcra";
            lblEcra.Size = new Size(173, 67);
            lblEcra.TabIndex = 0;
            lblEcra.Text = "HOME";
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(lblTotalCat);
            materialCard2.Controls.Add(label2);
            materialCard2.Controls.Add(label1);
            materialCard2.Controls.Add(pictureBox1);
            materialCard2.Depth = 0;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(345, 18);
            materialCard2.Margin = new Padding(14);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(14);
            materialCard2.Size = new Size(317, 159);
            materialCard2.TabIndex = 8;
            // 
            // lblTotalCat
            // 
            lblTotalCat.AutoSize = true;
            lblTotalCat.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            lblTotalCat.Location = new Point(20, 113);
            lblTotalCat.Name = "lblTotalCat";
            lblTotalCat.Size = new Size(28, 32);
            lblTotalCat.TabIndex = 4;
            lblTotalCat.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label2.Location = new Point(20, 64);
            label2.Name = "label2";
            label2.Size = new Size(250, 25);
            label2.TabIndex = 3;
            label2.Text = "Total de categorias existentes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            label1.Location = new Point(82, 16);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 2;
            label1.Text = "Total de Categorias";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.categ;
            pictureBox1.Location = new Point(20, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(lblTotalMat);
            materialCard1.Controls.Add(label4);
            materialCard1.Controls.Add(label5);
            materialCard1.Controls.Add(pictureBox2);
            materialCard1.Depth = 0;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(17, 18);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(317, 159);
            materialCard1.TabIndex = 9;
            // 
            // lblTotalMat
            // 
            lblTotalMat.AutoSize = true;
            lblTotalMat.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            lblTotalMat.Location = new Point(20, 113);
            lblTotalMat.Name = "lblTotalMat";
            lblTotalMat.Size = new Size(28, 32);
            lblTotalMat.TabIndex = 4;
            lblTotalMat.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label4.Location = new Point(20, 64);
            label4.Name = "label4";
            label4.Size = new Size(243, 25);
            label4.TabIndex = 3;
            label4.Text = "Total de materiais existentes";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            label5.Location = new Point(82, 16);
            label5.Name = "label5";
            label5.Size = new Size(218, 32);
            label5.TabIndex = 2;
            label5.Text = "Total de Materiais";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(20, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // materialCard3
            // 
            materialCard3.BackColor = Color.FromArgb(255, 255, 255);
            materialCard3.Controls.Add(lblTotalVendas);
            materialCard3.Controls.Add(label6);
            materialCard3.Controls.Add(label7);
            materialCard3.Controls.Add(pictureBox3);
            materialCard3.Depth = 0;
            materialCard3.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard3.Location = new Point(17, 200);
            materialCard3.Margin = new Padding(14);
            materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard3.Name = "materialCard3";
            materialCard3.Padding = new Padding(14);
            materialCard3.Size = new Size(317, 159);
            materialCard3.TabIndex = 10;
            // 
            // lblTotalVendas
            // 
            lblTotalVendas.AutoSize = true;
            lblTotalVendas.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            lblTotalVendas.Location = new Point(20, 113);
            lblTotalVendas.Name = "lblTotalVendas";
            lblTotalVendas.Size = new Size(28, 32);
            lblTotalVendas.TabIndex = 4;
            lblTotalVendas.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label6.Location = new Point(20, 64);
            label6.Name = "label6";
            label6.Size = new Size(235, 25);
            label6.TabIndex = 3;
            label6.Text = "Total de materiais vendidos\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            label7.Location = new Point(82, 16);
            label7.Name = "label7";
            label7.Size = new Size(193, 32);
            label7.TabIndex = 2;
            label7.Text = "Total de Vendas";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(20, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(63, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // materialCard4
            // 
            materialCard4.BackColor = Color.FromArgb(255, 255, 255);
            materialCard4.Controls.Add(lblStockTotalValue);
            materialCard4.Controls.Add(label9);
            materialCard4.Controls.Add(label10);
            materialCard4.Controls.Add(pictureBox4);
            materialCard4.Depth = 0;
            materialCard4.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard4.Location = new Point(343, 200);
            materialCard4.Margin = new Padding(14);
            materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard4.Name = "materialCard4";
            materialCard4.Padding = new Padding(14);
            materialCard4.Size = new Size(317, 159);
            materialCard4.TabIndex = 11;
            // 
            // lblStockTotalValue
            // 
            lblStockTotalValue.AutoSize = true;
            lblStockTotalValue.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            lblStockTotalValue.Location = new Point(20, 113);
            lblStockTotalValue.Name = "lblStockTotalValue";
            lblStockTotalValue.Size = new Size(28, 32);
            lblStockTotalValue.TabIndex = 4;
            lblStockTotalValue.Text = "0";
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label9.Location = new Point(20, 63);
            label9.Name = "label9";
            label9.Size = new Size(285, 60);
            label9.TabIndex = 3;
            label9.Text = "Valor de todos os materiais combinados";
            // 
            // label10
            // 
            label10.AutoEllipsis = true;
            label10.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            label10.Location = new Point(87, 2);
            label10.Name = "label10";
            label10.Size = new Size(218, 73);
            label10.TabIndex = 2;
            label10.Text = "Valor Total do Estoque";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(20, 9);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 48);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(materialCard5);
            panelMain.Controls.Add(materialCard1);
            panelMain.Controls.Add(materialCard4);
            panelMain.Controls.Add(materialCard2);
            panelMain.Controls.Add(materialCard3);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(229, 104);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(685, 496);
            panelMain.TabIndex = 12;
            // 
            // materialCard5
            // 
            materialCard5.BackColor = Color.FromArgb(255, 255, 255);
            materialCard5.Controls.Add(lblmateriaissemstock);
            materialCard5.Controls.Add(label8);
            materialCard5.Controls.Add(label11);
            materialCard5.Controls.Add(pictureBox5);
            materialCard5.Depth = 0;
            materialCard5.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard5.Location = new Point(17, 369);
            materialCard5.Margin = new Padding(14);
            materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard5.Name = "materialCard5";
            materialCard5.Padding = new Padding(14);
            materialCard5.Size = new Size(631, 113);
            materialCard5.TabIndex = 11;
            // 
            // lblmateriaissemstock
            // 
            lblmateriaissemstock.AutoSize = true;
            lblmateriaissemstock.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            lblmateriaissemstock.Location = new Point(20, 67);
            lblmateriaissemstock.Name = "lblmateriaissemstock";
            lblmateriaissemstock.Size = new Size(28, 32);
            lblmateriaissemstock.TabIndex = 4;
            lblmateriaissemstock.Text = "0";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Italic);
            label8.Location = new Point(326, 22);
            label8.Name = "label8";
            label8.Size = new Size(288, 77);
            label8.TabIndex = 3;
            label8.Text = "Total de materiais sem esetoque";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.2F, FontStyle.Bold);
            label11.Location = new Point(82, 16);
            label11.Name = "label11";
            label11.Size = new Size(243, 32);
            label11.TabIndex = 2;
            label11.Text = "Materiais Sem Stock";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(20, 9);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(63, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Controls.Add(panelmenu);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            FormClosing += Home_FormClosing;
            panelmenu.ResumeLayout(false);
            panellogo.ResumeLayout(false);
            panellogo.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            materialCard3.ResumeLayout(false);
            materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            materialCard4.ResumeLayout(false);
            materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panelMain.ResumeLayout(false);
            materialCard5.ResumeLayout(false);
            materialCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
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
        private Label lbluser;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label lblTotalCat;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private Label lblTotalMat;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private Label lblTotalVendas;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private Label lblStockTotalValue;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox4;
        private Panel panelMain;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private Label lblmateriaissemstock;
        private Label label8;
        private Label label11;
        private PictureBox pictureBox5;
    }
}