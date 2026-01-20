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

namespace BarEscolarMateriais
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl.GetType() == childForm.GetType())
                {
                    ctrl.BringToFront();
                    return;
                }
            }
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.Controls.Add(childForm);
            this.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
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
            LogIn from = new LogIn();
            from.Show();
            this.Hide();
        }
    }
}
