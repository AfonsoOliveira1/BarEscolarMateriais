namespace BarEscolarMateriais
{
    partial class History
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
            btnRemover = new Button();
            groupBox1 = new GroupBox();
            mlvHistorico = new MaterialSkin.Controls.MaterialListView();
            colID = new ColumnHeader();
            colUser = new ColumnHeader();
            colName = new ColumnHeader();
            colCategory = new ColumnHeader();
            colPrice = new ColumnHeader();
            colStock = new ColumnHeader();
            colDescription = new ColumnHeader();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(6, 20);
            btnAdicionar.Margin = new Padding(3, 2, 3, 2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(272, 34);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(284, 20);
            btnRemover.Margin = new Padding(3, 2, 3, 2);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(289, 34);
            btnRemover.TabIndex = 2;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mlvHistorico);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Location = new Point(6, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(583, 356);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historico Ações";
            // 
            // mlvHistorico
            // 
            mlvHistorico.AutoSizeTable = false;
            mlvHistorico.BackColor = Color.FromArgb(255, 255, 255);
            mlvHistorico.BorderStyle = BorderStyle.None;
            mlvHistorico.Columns.AddRange(new ColumnHeader[] { colID, colUser, colName, colCategory, colPrice, colStock, colDescription });
            mlvHistorico.Depth = 0;
            mlvHistorico.FullRowSelect = true;
            mlvHistorico.Location = new Point(6, 59);
            mlvHistorico.MinimumSize = new Size(200, 100);
            mlvHistorico.MouseLocation = new Point(-1, -1);
            mlvHistorico.MouseState = MaterialSkin.MouseState.OUT;
            mlvHistorico.Name = "mlvHistorico";
            mlvHistorico.OwnerDraw = true;
            mlvHistorico.Size = new Size(567, 291);
            mlvHistorico.TabIndex = 7;
            mlvHistorico.UseCompatibleStateImageBehavior = false;
            mlvHistorico.View = View.Details;
            // 
            // ID
            // 
            colID.Text = "ID";
            // 
            // User
            // 
            colUser.Text = "User";
            colUser.Width = 100;
            // 
            // Name
            // 
            colName.Text = "Name";
            colName.Width = 100;
            // 
            // Category
            // 
            colCategory.Text = "Category";
            colCategory.Width = 100;
            // 
            // Price
            // 
            colPrice.Text = "Price";
            colPrice.Width = 70;
            // 
            // Stock
            // 
            colStock.Text = "Stock";
            colStock.Width = 70;
            // 
            // Description
            // 
            colDescription.Text = "Description";
            colDescription.Width = 120;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 370);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Historico";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnAdicionar;
        private Button btnRemover;
        private GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialListView mlvHistorico;
        private ColumnHeader colID;
        private ColumnHeader colUser;
        private ColumnHeader colName;
        private ColumnHeader colCategory;
        private ColumnHeader colPrice;
        private ColumnHeader colStock;
        private ColumnHeader colDescription;
    }
}