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

namespace BarEscolarMateriais
{
    public partial class LogIn : Form
    {
        dbEscolaAferContext _context;
        //private readonly Authentication _authentication;
        public LogIn()
        {
            InitializeComponent();
            _context = new dbEscolaAferContext();
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnInserir.PerformClick();
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Passwordhash == password);
            if (1 == 1)
            {
                Home homeForm = new Home();
                homeForm.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Credenciais inválidas. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
