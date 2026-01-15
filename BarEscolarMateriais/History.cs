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
    public partial class History : Form
    {
        dbEscolaAferContext _context;
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            _context = new dbEscolaAferContext();
            dgvHistorico.DataSource = _context.Historicos.ToList();
        }
    }
}
