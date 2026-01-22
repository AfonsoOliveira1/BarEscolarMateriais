using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarEscolarMateriais.CategoriasForms;
using BarEscolarMateriais.Models;
using BarEscolarMateriais.Services;
using Microsoft.AspNetCore.Http.Features.Authentication;

namespace BarEscolarMateriais
{
    public partial class Home : Form
    {
        private readonly Authentication _authentication;
        private Form activateform = null;
        private dbEscolaAferContext _context = new dbEscolaAferContext();
        public Home(Authentication auth)
        {
            InitializeComponent();
            _authentication = auth;
            updatecards();
        }
        public void updatecards()
        {
            lbluser.Text = _authentication.CurrentUser().UserName;
            lblTotalCat.Text = _context.MaterialCategories.Count().ToString();
            lblTotalMat.Text = _context.Materials.Count().ToString();
            lblStockTotalValue.Text = _context.Materials.Sum(m => m.Price * m.Stock).ToString() + "€";
            lblTotalVendas.Text = _context.Historicos.Count().ToString();
            lblmateriaissemstock.Text = _context.Materials.Where(m => m.Stock == 0).Count().ToString();
        }
        private void OpenChildForm(Form childForm)
        {
            this.SuspendLayout();
            if (activateform != null)
            {
                activateform.Close();
            }
            activateform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            this.ResumeLayout();
        }

        private void btnMateriais_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Materiais());
            lblEcra.Text = "Materiais";
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Categorias());
            lblEcra.Text = "Categorias";
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            OpenChildForm(new History());
            lblEcra.Text = "Historico";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            _authentication.Logout();
            LogIn from = new LogIn();
            from.Show();
            this.Hide();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void lblhome_Click(object sender, EventArgs e)
        {
            if(activateform != null)
                activateform.Close();
            lblEcra.Text = "HOME";
            updatecards();
        }
    }
}
