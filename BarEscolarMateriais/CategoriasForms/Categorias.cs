using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarEscolarMateriais.Models;
using Microsoft.EntityFrameworkCore;

namespace BarEscolarMateriais.CategoriasForms
{
    public partial class Categorias : Form
    {
        public dbEscolaAferContext _context;
        public Categorias()
        {
            InitializeComponent();
            _context = new dbEscolaAferContext();
            ListViewLoad();
        }

        public void ListViewLoad()
        {
            try
            {
                _context.Dispose();
                _context = new dbEscolaAferContext();
                //categorias
                lvCategoria.Items.Clear();
                _context.Dispose(); //apaga o objecto em memoria (no cache) para atualizar os edits
                _context = new dbEscolaAferContext();
                for (int i = 0; i < _context.MaterialCategories.Count(); i++)
                {
                    var cat = _context.MaterialCategories.ToList()[i];
                    ListViewItem item = new ListViewItem(cat.Id.ToString());
                    item.Tag = cat.Id;
                    item.SubItems.Add(cat.Name);
                    item.SubItems.Add(cat.Description);
                    lvCategoria.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAdicionarC_Click(object sender, EventArgs e)
        {
            CategoriaAdicionar form = new CategoriaAdicionar();
            form.ShowDialog();
            ListViewLoad();
        }

        private void btnEditC_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lvCategoria.SelectedItems[0].Tag);
                CategoriaEditar form = new CategoriaEditar(id);
                form.ShowDialog();
                ListViewLoad();
            }
            catch
            {
                MessageBox.Show("Selecione uma coluna de uma categoria!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarC_Click(object sender, EventArgs e)
        {
            var question = MessageBox.Show("Eliminar uma categoria irá eliminar todos os materiais associados a ela.", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == question)
            {
                try
                {
                    foreach (ListViewItem item in lvCategoria.SelectedItems)
                    {
                        int id = (int)item.Tag;
                        var cat = _context.MaterialCategories.FirstOrDefault(c => c.Id == id);
                        var removemat = _context.Materials.Where(m => m.Categoryid == id).ToList();
                        foreach (var mat in removemat)
                        {
                            _context.Materials.Remove(mat);
                        }
                        _context.MaterialCategories.Remove(cat);
                        _context.SaveChanges();
                    }
                    ListViewLoad();
                }
                catch
                {
                    MessageBox.Show("Selecione uma categoria!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
