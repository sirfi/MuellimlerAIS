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

namespace MuellimlerAIS
{
    public partial class FormIxtisasQruplari : Form
    {
        public FormIxtisasQruplari()
        {
            InitializeComponent();
        }

        public Ixtisas Ixtisas { get; set; }
        private IxtisasQrubu secilmisQrup;

        private void FormIxtisasQruplari_Load(object sender, EventArgs e)
        {
            if (Ixtisas == null) { this.Close(); return; }

            this.Text = Ixtisas.Ad + " İxtisası Qrupları";

            numericUpDownBaslamaIli.Minimum = DateTime.Today.Year - 10;
            numericUpDownBaslamaIli.Maximum = DateTime.Today.Year + 10;

            buttonSaxla.Enabled = false;
            buttonSil.Enabled = false;

            ixtisasQrublariniGetir();
        }

        private void comboBoxIxtisasQruplari_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilmisQrup = comboBoxIxtisasQruplari.SelectedItem as IxtisasQrubu;
            if (secilmisQrup != null)
            {
                buttonSaxla.Enabled = true;
                buttonSil.Enabled = true;
                textBoxAd.Text = secilmisQrup.Ad;
                numericUpDownBaslamaIli.Value = secilmisQrup.BaslamaIli;
                numericUpDownTelebeSayi.Value = secilmisQrup.TelebeSayi;
            }
            else
            {
                buttonSaxla.Enabled = false;
                buttonSil.Enabled = false;
                textBoxAd.Text = "";
                numericUpDownBaslamaIli.Value = numericUpDownBaslamaIli.Minimum;
                numericUpDownTelebeSayi.Value = numericUpDownTelebeSayi.Minimum;
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            comboBoxIxtisasQruplari.SelectedItem = null;
            secilmisQrup = new IxtisasQrubu();
            secilmisQrup.Ixtisas = this.Ixtisas;
            buttonSaxla.Enabled = true;
            buttonSil.Enabled = false;
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (secilmisQrup == null) return;
            if (string.IsNullOrWhiteSpace(textBoxAd.Text))
            {
                MessageBox.Show("Ad olmalıdır.");
                return;
            }

            secilmisQrup.Ad = textBoxAd.Text;
            secilmisQrup.BaslamaIli = numericUpDownBaslamaIli.IntValue();
            secilmisQrup.TelebeSayi = numericUpDownTelebeSayi.IntValue();

            Program.VBE.Store(secilmisQrup);
            ixtisasQrublariniGetir();
            comboBoxIxtisasQruplari.SelectedItem = secilmisQrup;
            MessageBox.Show("İxtisas qrubu qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (secilmisQrup == null) return;
            Program.VBE.Delete(secilmisQrup);
            MessageBox.Show("İxtisas qrubu silindi.");
        }

        void ixtisasQrublariniGetir()
        {
            var ixtisasQruplari = from IxtisasQrubu iq in Program.VBE
                                  orderby iq.Ad ascending
                                  where iq.Ixtisas == this.Ixtisas
                                  select iq;
            comboBoxIxtisasQruplari.DataSource = ixtisasQruplari.ToList();
            comboBoxIxtisasQruplari.DisplayMember = "Ad";
            comboBoxIxtisasQruplari.SelectedItem = null;
        }
    }
}
