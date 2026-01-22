using BarEscolarMateriais.Models;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BarEscolarMateriais.Historico
{
    public partial class HistoryAdicionar : Form
    {
        dbEscolaAferContext _context;
        public HistoryAdicionar()
        {
            InitializeComponent();
            _context = new dbEscolaAferContext();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if (cbbMaterial.SelectedIndex != -1 && cbbUser.SelectedIndex != -1)
            {
                int idMaterial = (int)cbbMaterial.SelectedValue;
                Material mat = _context.Materials.FirstOrDefault(m => m.Id == idMaterial);
                string idUser = cbbUser.SelectedValue.ToString();
                User user = _context.Users.FirstOrDefault(u => u.Id == idUser);

                if(nudqtd.Value > mat.Stock)
                {
                    MessageBox.Show("Quantidade em stock insuficiente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                var historico = new Models.Historico
                {
                    Id = _context.Historicos.Count() + 1,
                    Materialid = mat.Id,
                    Userid = user.Id,
                    Categoryid = mat.Categoryid,
                    Name = mat.Name,
                    StockQuantidade = (int)nudqtd.Value,
                    Price = mat.Price,
                    Description = mat.Description,
                };
                mat.Stock -= (int)nudqtd.Value;
                _context.Historicos.Add(historico);
                _context.SaveChanges();
                this.Close();
            }
            else
            {
                MessageBox.Show("Dados Invalidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbUser_Click(object sender, EventArgs e)
        {
            try
            {
                cbbUser.DataSource = _context.Users.ToList();
                cbbUser.DisplayMember = "UserName";
                cbbUser.ValueMember = "Id";
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbbMaterial_Click(object sender, EventArgs e)
        {
            try
            {
                cbbMaterial.DataSource = _context.Materials.ToList();
                cbbMaterial.DisplayMember = "Name";
                cbbMaterial.ValueMember = "Id";
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
