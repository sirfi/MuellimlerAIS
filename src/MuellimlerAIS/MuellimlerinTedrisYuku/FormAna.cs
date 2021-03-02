using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MuellimlerinTedrisYuku
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            if (Program.SecilmisUniversitet == null) this.Close();
            this.Text = Program.SecilmisUniversitet.Ad + " - Müəllimlərin Tədris Yükü";
        }

        private void FormAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonManualDuzelis_Click(object sender, EventArgs e)
        {
            var form = new FormManualDuzelis();
            form.ShowDialog();
        }

        private void buttonAvtomatikDuzelis_Click(object sender, EventArgs e)
        {
            var form = new FormAvtomatikDuzelis();
            form.ShowDialog();
        }

        private void buttonBaxVeCapEt_Click(object sender, EventArgs e)
        {
            var form = new FormBaxVeCapEt();
            form.ShowDialog();
        }
    }
}
