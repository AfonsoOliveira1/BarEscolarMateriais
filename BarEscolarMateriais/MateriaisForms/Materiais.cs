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
            ListViewLoad();
        }

        public void ListViewLoad()
        {
            //materiais
            try
            {
                mlvMateriais.Items.Clear();
                _context.Dispose();
                _context = new dbEscolaAferContext();
                for (int i = 0; i < _context.Materials.Count(); i++)
                {
                    var mat = _context.Materials.Include(c => c.Category).ToList()[i];
                    var cat = _context.MaterialCategories.FirstOrDefault(c => c.Id == mat.Categoryid);
                    ListViewItem item = new ListViewItem(mat.Id.ToString());
                    item.Tag = mat.Id;
                    item.SubItems.Add(mat.Name);
                    item.SubItems.Add(cat.Name);
                    item.SubItems.Add(mat.Price.ToString() + "€");
                    item.SubItems.Add(mat.Stock.ToString());
                    item.SubItems.Add(mat.Description);
                    mlvMateriais.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewLoad();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MateriaisAdicionar form = new MateriaisAdicionar();
            form.ShowDialog();
            ListViewLoad();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(mlvMateriais.SelectedItems[0].Tag);
                MateriaisEdits form = new MateriaisEdits(id);
                form.ShowDialog();
                ListViewLoad();
            }
            catch (ArgumentException es)
            {
                MessageBox.Show(es.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in mlvMateriais.SelectedItems)
                {
                    int id = (int)item.Tag;
                    var mat = _context.Materials.FirstOrDefault(c => c.Id == id);
                    _context.Materials.Remove(mat);
                    _context.SaveChanges();
                }
                ListViewLoad();
            }
            catch
            {
                MessageBox.Show("Selecione um material!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
