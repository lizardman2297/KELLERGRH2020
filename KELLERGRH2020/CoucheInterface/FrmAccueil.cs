using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KellerEleveWForm
{
    public partial class FrmAccueil : Form
    {
        public FrmAccueil()
        {
            InitializeComponent();
        }

        private void gestionDesCollaborateursToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmCollaborateurs frm = new FrmCollaborateurs();
            frm.Width = this.Width;
            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
