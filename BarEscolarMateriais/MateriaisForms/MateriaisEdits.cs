using BarEscolarMateriais.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class MateriaisEdits : Form
    {
        public int id;
        private dbEscolaAferContext _context;

        public MateriaisEdits(int ID)
        {
            InitializeComponent();
            id = ID;
            _context = new dbEscolaAferContext();
            var material = _context.Materials.FirstOrDefault(m => m.Id == id);
            var cat = _context.MaterialCategories.FirstOrDefault(c => c.Id == material.Categoryid);
            additens();
            foreach(MaterialCategory item in cbbCategory.Items)
                if (item.Id == cat.Id) cbbCategory.SelectedItem = item;
            txtName.Text = material.Name;
            txtDescription.Text = material.Description;
            nudPrice.Value = material.Price;
            txtStock.Text = material.Stock.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var material = _context.Materials.FirstOrDefault(m => m.Id == id);
            if (txtName.Text != "" && cbbCategory.SelectedIndex != -1 && nudPrice.Value >= 0)
            {
                int idCategory = (int)cbbCategory.SelectedValue;
                MaterialCategory cat = _context.MaterialCategories.FirstOrDefault(c => c.Id == idCategory);

                material.Name = txtName.Text;
                material.Description = txtDescription.Text;
                material.Price = nudPrice.Value;
                material.Stock = Convert.ToInt32(txtStock.Text);
                material.Categoryid = cat.Id;
                material.Category = cat;
                _context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dados Invalidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public void additens()
        {
            try
            {
                cbbCategory.DataSource = _context.MaterialCategories.ToList();
                cbbCategory.DisplayMember = "Name";
                cbbCategory.ValueMember = "Id";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbCategory_Click(object sender, EventArgs e)
        {
            additens();
        }
    }
}
