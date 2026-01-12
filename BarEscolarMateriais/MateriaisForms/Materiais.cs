using BarEscolarMateriais.CategoriasForms;
using BarEscolarMateriais.MateriaisForms;
using BarEscolarMateriais.Models;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace BarEscolarMateriais
{
    public partial class Materiais : Form
    {
        public dbEscolaAferContext _context;
        public Materiais()
        {
            InitializeComponent();
            _context = new dbEscolaAferContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvMateriais.DataSource = _context.Materials.ToList();
            dgvCategoria.DataSource = _context.MaterialCategories.ToList();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MateriaisAdicionar form = new MateriaisAdicionar();
            form.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvMateriais.SelectedRows[0].Cells[0]);
                MateriaisEdits form = new MateriaisEdits(id);
                form.Show();
            }
            catch
            {
                MessageBox.Show("Selecione uma coluna de um material!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionarC_Click(object sender, EventArgs e)
        {
            CategoriaAdicionar form = new CategoriaAdicionar();
            form.Show();
        }

        private void btnEditC_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0]);
                CategoriaEditar form = new CategoriaEditar(id);
                form.Show();
            }
            catch
            {
                MessageBox.Show("Selecione uma coluna de uma categoria!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvMateriais.SelectedRows[0].Cells[0]);
                var mat = _context.Materials.FirstOrDefault(c => c.Id == id);
                _context.Materials.Remove(mat);
                _context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Selecione uma coluna de um material!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgvCategoria.SelectedRows[0].Cells[0]);
                var cat = _context.MaterialCategories.FirstOrDefault(c => c.Id == id);
                _context.MaterialCategories.Remove(cat);
                _context.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Selecione uma coluna de uma categoria!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
