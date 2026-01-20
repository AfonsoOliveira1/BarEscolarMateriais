namespace BarEscolarMateriais.CategoriasForms
{
    partial class Categorias
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
            groupBox2 = new GroupBox();
            btnEliminarC = new Button();
            btnEditC = new Button();
            btnAdicionarC = new Button();
            mlvCategoria = new MaterialSkin.Controls.MaterialListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mlvCategoria);
            groupBox2.Controls.Add(btnEliminarC);
            groupBox2.Controls.Add(btnEditC);
            groupBox2.Controls.Add(btnAdicionarC);
            groupBox2.Location = new Point(7, 5);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(587, 365);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Categorias Ações";
            // 
            // btnEliminarC
            // 
            btnEliminarC.Location = new Point(390, 23);
            btnEliminarC.Margin = new Padding(3, 2, 3, 2);
            btnEliminarC.Name = "btnEliminarC";
            btnEliminarC.Size = new Size(185, 34);
            btnEliminarC.TabIndex = 2;
            btnEliminarC.Text = "Eliminar";
            btnEliminarC.UseVisualStyleBackColor = true;
            btnEliminarC.Click += btnEliminarC_Click;
            // 
            // btnEditC
            // 
            btnEditC.Location = new Point(199, 23);
            btnEditC.Margin = new Padding(3, 2, 3, 2);
            btnEditC.Name = "btnEditC";
            btnEditC.Size = new Size(185, 34);
            btnEditC.TabIndex = 1;
            btnEditC.Text = "Edit";
            btnEditC.UseVisualStyleBackColor = true;
            btnEditC.Click += btnEditC_Click;
            // 
            // btnAdicionarC
            // 
            btnAdicionarC.Location = new Point(8, 23);
            btnAdicionarC.Margin = new Padding(3, 2, 3, 2);
            btnAdicionarC.Name = "btnAdicionarC";
            btnAdicionarC.Size = new Size(185, 34);
            btnAdicionarC.TabIndex = 0;
            btnAdicionarC.Text = "Adicionar";
            btnAdicionarC.UseVisualStyleBackColor = true;
            btnAdicionarC.Click += btnAdicionarC_Click;
            // 
            // mlvCategoria
            // 
            mlvCategoria.AutoSizeTable = false;
            mlvCategoria.BackColor = Color.FromArgb(255, 255, 255);
            mlvCategoria.BorderStyle = BorderStyle.None;
            mlvCategoria.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader9 });
            mlvCategoria.Depth = 0;
            mlvCategoria.FullRowSelect = true;
            mlvCategoria.Location = new Point(8, 62);
            mlvCategoria.MinimumSize = new Size(200, 100);
            mlvCategoria.MouseLocation = new Point(-1, -1);
            mlvCategoria.MouseState = MaterialSkin.MouseState.OUT;
            mlvCategoria.Name = "mlvCategoria";
            mlvCategoria.OwnerDraw = true;
            mlvCategoria.Size = new Size(567, 293);
            mlvCategoria.TabIndex = 7;
            mlvCategoria.UseCompatibleStateImageBehavior = false;
            mlvCategoria.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 200;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Description";
            columnHeader9.Width = 200;
            // 
            // Categorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 374);
            Controls.Add(groupBox2);
            Name = "Categorias";
            Text = "Categorias";
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnEliminarC;
        private Button btnEditC;
        private Button btnAdicionarC;
        private MaterialSkin.Controls.MaterialListView mlvCategoria;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader9;
    }
}