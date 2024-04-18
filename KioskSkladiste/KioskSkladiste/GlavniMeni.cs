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
        
        public GlavniMeni()
        {
            InitializeComponent();
        }

        private void GlavniMeni_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void stanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stk = new Stock();
            stk.MdiParent = this;
            stk.StartPosition = FormStartPosition.CenterScreen;
            stk.Show();
        }
    }
}
