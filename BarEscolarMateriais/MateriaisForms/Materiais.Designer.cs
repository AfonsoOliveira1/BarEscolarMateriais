namespace BarEscolarMateriais
{
    partial class Materiais
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            mlvMateriais = new MaterialSkin.Controls.MaterialListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            btnAdicionar = new Button();
            btnEdit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(mlvMateriais);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Location = new Point(7, 4);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(578, 356);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Materiais Ações";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(388, 19);
            btnEliminar.Margin = new Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(185, 34);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // mlvMateriais
            // 
            mlvMateriais.AutoSizeTable = false;
            mlvMateriais.BackColor = Color.FromArgb(255, 255, 255);
            mlvMateriais.BorderStyle = BorderStyle.None;
            mlvMateriais.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12 });
            mlvMateriais.Depth = 0;
            mlvMateriais.FullRowSelect = true;
            mlvMateriais.Location = new Point(6, 58);
            mlvMateriais.MinimumSize = new Size(200, 100);
            mlvMateriais.MouseLocation = new Point(-1, -1);
            mlvMateriais.MouseState = MaterialSkin.MouseState.OUT;
            mlvMateriais.Name = "mlvMateriais";
            mlvMateriais.OwnerDraw = true;
            mlvMateriais.Size = new Size(566, 293);
            mlvMateriais.TabIndex = 2;
            mlvMateriais.UseCompatibleStateImageBehavior = false;
            mlvMateriais.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ID";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Name";
            columnHeader8.Width = 150;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Category";
            columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Price";
            columnHeader10.Width = 70;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Stock";
            columnHeader11.Width = 70;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Description";
            columnHeader12.Width = 110;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(6, 19);
            btnAdicionar.Margin = new Padding(3, 2, 3, 2);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(185, 34);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(197, 19);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(185, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // Materiais
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 367);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "Materiais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Materiais";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Button btnEliminar;
        private Button btnEdit;
        private Button btnAdicionar;
        private MaterialSkin.Controls.MaterialListView mlvMateriais;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
    }
}
