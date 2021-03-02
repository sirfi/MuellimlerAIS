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
using MuellimlerAIS.VerilenlerStrukturlari;

namespace MuellimlerAIS
{
    public partial class FormDiller : Form
    {
        Dil seciliDil;

        public FormDiller()
        {
            InitializeComponent();
        }

        private void FormDiller_Load(object sender, EventArgs e)
        {
            seciliDil = null;
            buttonSaxla.Enabled = false;
            buttonSil.Enabled = false;
            dilleriGetir();
        }

        private void comboBoxDiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliDil = comboBoxDiller.SelectedItem as Dil;
            if (seciliDil != null)
            {
                textBoxAd.Text = seciliDil.Ad;
                buttonSaxla.Enabled = true;
                buttonSil.Enabled = true;
            }
            else
            {
                textBoxAd.Text = "";
                buttonSaxla.Enabled = false;
                buttonSil.Enabled = false;
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            seciliDil = new Dil();
            comboBoxDiller.SelectedIndex = -1;
            buttonSaxla.Enabled = true;
            buttonSil.Enabled = false;
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (seciliDil == null) return;
            if (string.IsNullOrWhiteSpace(textBoxAd.Text))
            {
                MessageBox.Show("Ad olmalıdır.");
                return;
            }
            seciliDil.Ad = textBoxAd.Text;
            Program.VBE.Store(seciliDil);
            dilleriGetir();
            comboBoxDiller.SelectedItem = seciliDil;
            MessageBox.Show("Dil qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Program.VBE.Delete(seciliDil);
            dilleriGetir();
            comboBoxDiller.SelectedIndex = -1;
            MessageBox.Show("Dil silindi.");
        }

        void dilleriGetir()
        {
            var diller = from Dil d in Program.VBE
                         orderby d.Ad ascending
                         select d;
            comboBoxDiller.DataSource = diller.ToList();
            comboBoxDiller.DisplayMember = "Ad";
            comboBoxDiller.SelectedIndex = -1;
        }
    }
}
