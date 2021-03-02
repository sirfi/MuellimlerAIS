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

namespace MuellimlerAIS
{
    public partial class FormIxtisaslar : Form
    {
        public FormIxtisaslar()
        {
            InitializeComponent();
        }

        public Kafedra Kafedra { get; set; }
        private Ixtisas secilmisIxtisas;
        private List<EnumListItem<IxtisasTuru>> turler;

        private void FormIxtisaslar_Load(object sender, EventArgs e)
        {
            if (Kafedra == null) this.Close();
            this.Text = this.Kafedra.Ad + " Kafedrası İxtisasları";
            secilmisIxtisas = null;
            buttonIxtisasDersleri.Enabled = false;
            buttonIxtisasQruplari.Enabled = false;
            buttonSaxla.Enabled = false;
            buttonSil.Enabled = false;

            turler = EnumLib.GetEnumList<IxtisasTuru>();
            comboBoxTur.DataSource = turler;
            comboBoxTur.DisplayMember = "Name";
            comboBoxTur.ValueMember = "Value";

            ixtisaslariGetir();
        }

        private void comboBoxIxtisaslar_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilmisIxtisas = comboBoxIxtisaslar.SelectedItem as Ixtisas;
            if (secilmisIxtisas != null)
            {
                textBoxAd.Text = secilmisIxtisas.Ad;
                comboBoxTur.SelectedValue = secilmisIxtisas.Tur;
                buttonIxtisasDersleri.Enabled = true;
                buttonIxtisasQruplari.Enabled = true;
                buttonSaxla.Enabled = true;
                buttonSil.Enabled = true;
            }
            else
            {
                textBoxAd.Text = "";
                comboBoxTur.SelectedIndex = -1;
                buttonIxtisasDersleri.Enabled = false;
                buttonIxtisasQruplari.Enabled = false;
                buttonSaxla.Enabled = false;
                buttonSil.Enabled = false;
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            comboBoxIxtisaslar.SelectedItem = null;
            secilmisIxtisas = new Ixtisas();
            secilmisIxtisas.Kafedra = this.Kafedra;
            buttonIxtisasDersleri.Enabled = false;
            buttonIxtisasQruplari.Enabled = false;
            buttonSaxla.Enabled = true;
            buttonSil.Enabled = false;
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (secilmisIxtisas == null) return;
            if (string.IsNullOrWhiteSpace(textBoxAd.Text))
            {
                MessageBox.Show("Ad olmalıdır.");
                return;
            }
            if (comboBoxTur.SelectedIndex < 0)
            {
                MessageBox.Show("Tür olmalıdır.");
                return;
            }
            secilmisIxtisas.Ad = textBoxAd.Text;
            secilmisIxtisas.Tur = (IxtisasTuru)comboBoxTur.SelectedValue;
            Program.VBE.Store(secilmisIxtisas);
            ixtisaslariGetir();
            comboBoxIxtisaslar.SelectedItem = secilmisIxtisas;
            MessageBox.Show("İxtisas qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Program.VBE.Delete(secilmisIxtisas);
            ixtisaslariGetir();
            comboBoxIxtisaslar.SelectedIndex = -1;
            MessageBox.Show("Dərs silindi.");
        }

        void ixtisaslariGetir()
        {
            var ixtisaslar = from Ixtisas i in Program.VBE
                             orderby i.Ad ascending
                             where i.Kafedra == this.Kafedra
                             select i;
            comboBoxIxtisaslar.DataSource = ixtisaslar.ToList();
            comboBoxIxtisaslar.DisplayMember = "Ad";
            comboBoxIxtisaslar.SelectedItem = null;
        }

        private void buttonIxtisasDersleri_Click(object sender, EventArgs e)
        {
            var form = new FormIxtisasDersleri();
            form.Ixtisas = secilmisIxtisas;
            form.MdiParent = Program.FormAna;
            form.Show();
        }

        private void buttonIxtisasQruplari_Click(object sender, EventArgs e)
        {
            var form = new FormIxtisasQruplari();
            form.Ixtisas = secilmisIxtisas;
            form.MdiParent = Program.FormAna;
            form.Show();
        }

    }
}
