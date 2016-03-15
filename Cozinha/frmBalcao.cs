using System;
using System.Windows.Forms;

namespace Cozinha
{
    public partial class frmBalcao : Form
    {
        public frmBalcao()
        {
            InitializeComponent();
        }

        public void monta(string item)
        {
            lstBalcao.Items.Add(item);
        }

        private void lstBalcao_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBalcao.Items.Remove(lstBalcao.SelectedItem);
        }

        private void frmBalcao_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
