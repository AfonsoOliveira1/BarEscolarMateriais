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
using BarEscolarMateriais.Services;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BarEscolarMateriais
{
    public partial class LogIn : Form
    {
        dbEscolaAferContext _context;
        Authentication _authentication;
        //private readonly Authentication _authentication;
        public LogIn()
        {
            InitializeComponent();
            _authentication = new Authentication();
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
            string EmailorUsername = txtEmailorUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            var authenticated = _authentication.Login(EmailorUsername, password);
            var user = _authentication.CurrentUser();

            if (!authenticated || user == null || user.Role != 2)//admin role = 2
            {
                txtPassword.Clear();
                MessageBox.Show("Credenciais inválidas ou não é um Admin. Tente novamente.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Home home = new Home(_authentication);
                home.Show();
                this.Hide();
            }
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
