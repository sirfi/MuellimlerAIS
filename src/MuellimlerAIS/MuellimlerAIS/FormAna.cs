using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MuellimlerAIS
{
    public partial class FormAna : Form
    {
        public FormAna()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            this.Text = Program.SecilmisUniversitet.Ad + " - Müəllimlər AİS";
        }

        private void FormAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fakultelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormFakulteler();
            form.MdiParent = this;
            form.Show();
        }

        private void rektorVeProrektorlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormUniversitetRektorVeProrektorleri();
            form.MdiParent = this;
            form.Show();
        }

        private void muellimlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMuellimler();
            form.MdiParent = this;
            form.Show();
        }

        private void dillerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormDiller();
            form.MdiParent = this;
            form.Show();
        }

        private void konfranslarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormKonferanslar();
            form.MdiParent = this;
            form.Show();
        }

        private void haqqindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormHaqqinda().ShowDialog();
        }

        private void cixisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void muellimlerSorgulamalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FormMuellimSorgulamalari();
            form.MdiParent = this;
            form.Show();
        }


    }
}
