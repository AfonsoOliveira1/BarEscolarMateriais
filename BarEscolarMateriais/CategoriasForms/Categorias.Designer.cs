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
            lvCategoria = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            btnEliminarC = new Button();
            btnEditC = new Button();
            btnAdicionarC = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lvCategoria);
            groupBox2.Controls.Add(btnEliminarC);
            groupBox2.Controls.Add(btnEditC);
            groupBox2.Controls.Add(btnAdicionarC);
            groupBox2.Location = new Point(4, 5);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(587, 358);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Categorias Ações";
            // 
            // lvCategoria
            // 
            lvCategoria.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader8, columnHeader13 });
            lvCategoria.Location = new Point(8, 61);
            lvCategoria.Margin = new Padding(3, 2, 3, 2);
            lvCategoria.Name = "lvCategoria";
            lvCategoria.Size = new Size(567, 279);
            lvCategoria.TabIndex = 6;
            lvCategoria.UseCompatibleStateImageBehavior = false;
            lvCategoria.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "ID";
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Name";
            columnHeader8.Width = 130;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Description";
            columnHeader13.Width = 200;
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
        private ListView lvCategoria;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader13;
    }
}