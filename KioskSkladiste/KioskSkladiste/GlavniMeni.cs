using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioskSkladiste
{
    public partial class GlavniMeni : Form
    {
        private int childFormNumber = 0;

        public GlavniMeni()
        {
            InitializeComponent();
        }

        private void GlavniMeni_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void proziToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proizvodi pro = new Proizvodi();
            pro.MdiParent = this;
            pro.Show(); 
        }
    }
}
