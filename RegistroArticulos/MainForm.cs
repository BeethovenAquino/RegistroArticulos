using RegistroArticulos.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegistroArticulos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroDeArticuulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDeArticulos a = new RegistroDeArticulos();
            a.Show();
        }
    }
}
