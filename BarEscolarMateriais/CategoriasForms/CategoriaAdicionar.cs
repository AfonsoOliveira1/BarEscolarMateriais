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

namespace BarEscolarMateriais.CategoriasForms
{
    public partial class CategoriaAdicionar : Form
    {
        public dbEscolaAferContext _context;
        public CategoriaAdicionar()
        {
            InitializeComponent();
            _context = new dbEscolaAferContext();
        }

        private void CategoriaAdicionar_Load(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                var newcat = new MaterialCategory
                {
                    Id = _context.MaterialCategories.Count() + 1,
                    Name = txtName.Text,
                    Description = txtDescription.Text
                };
                _context.MaterialCategories.Add(newcat);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Dados Invalidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
