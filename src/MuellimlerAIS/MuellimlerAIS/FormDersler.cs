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
    public partial class FormDersler : Form
    {
        public Kafedra Kafedra { get; set; }
        private Ders secilmisDers;
        public FormDersler()
        {
            InitializeComponent();
        }

        private void FormDersler_Load(object sender, EventArgs e)
        {
            if (Kafedra == null) this.Close();
            this.Text = this.Kafedra.Ad + " Kafedrası Dərsləri";
            secilmisDers = null;
            buttonSaxla.Enabled = false;
            buttonSil.Enabled = false;
            dersleriGetir();
        }

        private void comboBoxDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilmisDers = comboBoxDersler.SelectedItem as Ders;
            if (secilmisDers!=null)
            {
                textBoxAd.Text = secilmisDers.Ad;
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
            comboBoxDersler.SelectedItem = null;
            secilmisDers = new Ders();
            secilmisDers.Kafedra = this.Kafedra;
            buttonSaxla.Enabled = true;
            buttonSil.Enabled = false;
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (secilmisDers == null) return;
            if (string.IsNullOrWhiteSpace(textBoxAd.Text))
            {
                MessageBox.Show("Ad olmalıdır.");
                return;
            }
            secilmisDers.Ad = textBoxAd.Text;
            Program.VBE.Store(secilmisDers);
            dersleriGetir();
            comboBoxDersler.SelectedItem = secilmisDers;
            MessageBox.Show("Dərs qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Program.VBE.Delete(secilmisDers);
            dersleriGetir();
            comboBoxDersler.SelectedIndex = -1;
            MessageBox.Show("Dərs silindi.");
        }

        void dersleriGetir()
        {
            var dersler = from Ders d in Program.VBE
                          orderby d.Ad ascending
                          where d.Kafedra==this.Kafedra
                          select d;
            comboBoxDersler.DataSource = dersler.ToList();
            comboBoxDersler.DisplayMember = "Ad";
            comboBoxDersler.SelectedItem = null;
        }
    }
}
