using BarEscolarMateriais.Models;
using BarEscolarMateriais.Historico;
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

namespace BarEscolarMateriais
{
    public partial class History : Form
    {
        dbEscolaAferContext _context;
        public History()
        {
            InitializeComponent();
            _context = new dbEscolaAferContext();
            ListViewLoad();
        }
        public void ListViewLoad()
        {
            //historicos
            try
            {
                lvHistorico.Items.Clear();
                _context.Dispose();
                _context = new dbEscolaAferContext();
                for (int i = 0; i < _context.Historicos.Count(); i++)
                {
                    var historico = _context.Historicos.ToList()[i];
                    var user = _context.Users.FirstOrDefault(c => c.Id == historico.Userid);
                    var mat = _context.Materials.FirstOrDefault(c => c.Id == historico.Materialid);
                    var cat = _context.MaterialCategories.FirstOrDefault(c => c.Id == mat.Categoryid);
                    ListViewItem item = new ListViewItem(historico.Id.ToString());
                    item.Tag = historico.Id;
                    item.SubItems.Add(user.FullName);
                    item.SubItems.Add(mat.Name);
                    item.SubItems.Add(cat.Name);
                    item.SubItems.Add(mat.Price.ToString() + "€");
                    item.SubItems.Add(mat.Stock.ToString());
                    item.SubItems.Add(mat.Description);
                    lvHistorico.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            HistoryAdicionar form = new HistoryAdicionar();
            form.ShowDialog();
            ListViewLoad();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in lvHistorico.SelectedItems)
                {
                    int id = (int)item.Tag;
                    var historico = _context.Historicos.FirstOrDefault(c => c.Id == id);
                    _context.Historicos.Remove(historico);
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
