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

namespace BarEscolarMateriais.MateriaisForms
{
    public partial class MateriaisAdicionar : Form
    {
        public dbEscolaAferContext _context;

        public MateriaisAdicionar()
        {
            InitializeComponent();
            _context = new dbEscolaAferContext();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && cbbCategory.SelectedItem != null && nudPrice.Value >= 0 && Convert.ToInt32(txtStock.Text) >= 0)
            {
                MaterialCategory cat = _context.MaterialCategories.FirstOrDefault(c => c.Name == cbbCategory.SelectedItem.ToString());

                var mat = new Material
                {
                    Id = _context.Materials.Count() + 1,
                    Name = txtName.Text,
                    Description = txtDescription.Text,
                    Price = nudPrice.Value,
                    Stock = Convert.ToInt32(txtStock.Text),
                    Categoryid = cat.Id,
                    Category = cat
                };
                _context.Materials.Add(mat);
                _context.SaveChanges();
                this.Close();
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
        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbbCategory_Click(object sender, EventArgs e)
        {
            cbbCategory.Items.Clear();
            var categoria = _context.MaterialCategories;
            foreach (var c in categoria)
            {
                cbbCategory.Items.Add(c.Name);
            }
        }
    }
}
