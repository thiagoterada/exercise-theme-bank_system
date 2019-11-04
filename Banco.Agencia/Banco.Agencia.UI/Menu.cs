using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Agencia.UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadAge form = new cadAge();
            form.MdiParent = this;
            form.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadCli form = new cadCli();
            form.MdiParent = this;
            form.Show();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadFunc form = new cadFunc();
            form.MdiParent = this;
            form.Show();
        }

        private void contaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cadConta form = new cadConta();
            form.MdiParent = this;
            form.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Today.ToShortDateString() + " - " + DateTime.Now.ToShortTimeString();
        }
    }
}
