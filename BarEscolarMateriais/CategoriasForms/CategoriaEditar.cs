using BarEscolarMateriais.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarEscolarMateriais.CategoriasForms
{
    public partial class CategoriaEditar : Form
    {
        public dbEscolaAferContext _context;
        public int id;
        public CategoriaEditar(int ID)
        {
            InitializeComponent();
            id = ID;
            _context = new dbEscolaAferContext();
            var cat = _context.MaterialCategories.FirstOrDefault(c => c.Id == id);
            txtName.Text = cat.Name;
            txtDescription.Text = cat.Description;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                var cat = _context.MaterialCategories.FirstOrDefault(c => c.Id == id);
                cat.Name = txtName.Text;
                cat.Description = txtDescription.Text;
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Dados Invalidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
