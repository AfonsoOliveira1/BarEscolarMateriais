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
            dgvMateriais = new DataGridView();
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnEdit = new Button();
            btnAdicionar = new Button();
            panel1 = new Panel();
            dgvCategoria = new DataGridView();
            panel2 = new Panel();
            groupBox2 = new GroupBox();
            btnEliminarC = new Button();
            btnEditC = new Button();
            btnAdicionarC = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMateriais).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).BeginInit();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvMateriais
            // 
            dgvMateriais.AllowUserToAddRows = false;
            dgvMateriais.AllowUserToDeleteRows = false;
            dgvMateriais.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMateriais.Dock = DockStyle.Fill;
            dgvMateriais.Location = new Point(0, 0);
            dgvMateriais.Name = "dgvMateriais";
            dgvMateriais.ReadOnly = true;
            dgvMateriais.RowHeadersWidth = 51;
            dgvMateriais.Size = new Size(404, 209);
            dgvMateriais.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnAdicionar);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 188);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Materiais Ações";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(6, 127);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(236, 45);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(6, 76);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(236, 45);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(6, 26);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(236, 45);
            btnAdicionar.TabIndex = 0;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvCategoria);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(266, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 398);
            panel1.TabIndex = 2;
            // 
            // dgvCategoria
            // 
            dgvCategoria.AllowUserToAddRows = false;
            dgvCategoria.AllowUserToDeleteRows = false;
            dgvCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoria.Dock = DockStyle.Fill;
            dgvCategoria.Location = new Point(0, 209);
            dgvCategoria.Name = "dgvCategoria";
            dgvCategoria.ReadOnly = true;
            dgvCategoria.RowHeadersWidth = 51;
            dgvCategoria.Size = new Size(404, 189);
            dgvCategoria.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvMateriais);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 209);
            panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnEliminarC);
            groupBox2.Controls.Add(btnEditC);
            groupBox2.Controls.Add(btnAdicionarC);
            groupBox2.Location = new Point(6, 206);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 188);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Categorias Ações";
            // 
            // btnEliminarC
            // 
            btnEliminarC.Location = new Point(6, 127);
            btnEliminarC.Name = "btnEliminarC";
            btnEliminarC.Size = new Size(236, 45);
            btnEliminarC.TabIndex = 2;
            btnEliminarC.Text = "Eliminar";
            btnEliminarC.UseVisualStyleBackColor = true;
            btnEliminarC.Click += btnEliminarC_Click;
            // 
            // btnEditC
            // 
            btnEditC.Location = new Point(6, 76);
            btnEditC.Name = "btnEditC";
            btnEditC.Size = new Size(236, 45);
            btnEditC.TabIndex = 1;
            btnEditC.Text = "Edit";
            btnEditC.UseVisualStyleBackColor = true;
            btnEditC.Click += btnEditC_Click;
            // 
            // btnAdicionarC
            // 
            btnAdicionarC.Location = new Point(6, 26);
            btnAdicionarC.Name = "btnAdicionarC";
            btnAdicionarC.Size = new Size(236, 45);
            btnAdicionarC.TabIndex = 0;
            btnAdicionarC.Text = "Adicionar";
            btnAdicionarC.UseVisualStyleBackColor = true;
            btnAdicionarC.Click += btnAdicionarC_Click;
            // 
            // Materiais
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 398);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Materiais";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Materiais";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMateriais).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategoria).EndInit();
            panel2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMateriais;
        private GroupBox groupBox1;
        private Panel panel1;
        private Button btnEliminar;
        private Button btnEdit;
        private Button btnAdicionar;
        private DataGridView dgvCategoria;
        private Panel panel2;
        private GroupBox groupBox2;
        private Button btnEliminarC;
        private Button btnEditC;
        private Button btnAdicionarC;
    }
}
