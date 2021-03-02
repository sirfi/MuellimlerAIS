using MuellimlerAIS.VerilenlerStrukturlari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using MuellimlerAIS.Libs;

namespace MuellimlerinTedrisYuku
{
    public partial class FormGiris : Form
    {
        IList<Universitet> universitetler;

        public FormGiris()
        {
            InitializeComponent();
        }

        void UniversitetleriGetir()
        {
            universitetler = (from Universitet u in Program.VBE select u).ToList();
            comboBoxUniversitet.DataSource = universitetler;
            comboBoxUniversitet.DisplayMember = "Ad";
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            this.Height = 270;
            buttonGir.Enabled = false;
            UniversitetleriGetir();
            comboBoxUniversitet.SelectedItem = universitetler.SingleOrDefault(x => x.Secili != null && x.Secili.HasValue && x.Secili.Value);
        }

        private void buttonGir_Click(object sender, EventArgs e)
        {
            universitetler.Where(x => x.Secili != null && x.Secili.HasValue && x.Secili.Value).ToList().ForEach(x =>
            {
                if (x == Program.SecilmisUniversitet)
                {
                    x.Secili = true;
                }
                else
                {
                    x.Secili = false;
                }
                Program.VBE.Store(x);
            });
            this.Hide();
            Program.FormAna.Show();
        }

        private void buttonDuzelt_Click(object sender, EventArgs e)
        {
            if (this.Height == 270)
            {
                this.Height = 300;
            }
            else
            {
                this.Height = 270;
            }
        }

        private void comboBoxUniversitet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SecilmisUniversitet = comboBoxUniversitet.SelectedItem as Universitet;
            if (Program.SecilmisUniversitet != null)
            {
                buttonGir.Enabled = true;
                pictureBoxLogo.Image = ImageLib.ByteArrayToImage(Program.SecilmisUniversitet.Logo);
            }
            else
            {
                buttonGir.Enabled = false;
                pictureBoxLogo.Image = null;
            }
        }
    }
}
