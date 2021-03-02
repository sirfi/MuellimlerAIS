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
    public partial class FormMuellimKitablari : Form
    {
        public FormMuellimKitablari()
        {
            InitializeComponent();
        }

        public Muellim Muellim { get; set; }
        MuellimKitabi secilmisMuellimKitabi;

        private void FormMuellimKitablari_Load(object sender, EventArgs e)
        {
            if (Muellim == null) this.Close();
            secilmisMuellimKitabi = null;
            MuelliminKitablariniGetir();
            buttonSil.Enabled = false;
            buttonSaxla.Enabled = false;
            numericUpDownCapIli.Maximum = DateTime.Today.Year;
        }

        private void comboBoxMuelliminKitablari_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilmisMuellimKitabi = comboBoxMuelliminKitablari.SelectedItem as MuellimKitabi;
            if (secilmisMuellimKitabi != null)
            {
                buttonSil.Enabled = true;
                buttonSaxla.Enabled = true;
                textBoxAd.Text = secilmisMuellimKitabi.Ad;
                textBoxMovzu.Text = secilmisMuellimKitabi.Movzu;
                numericUpDownCapIli.Value = secilmisMuellimKitabi.CapIli;
            }
            else
            {
                buttonSil.Enabled = false;
                buttonSaxla.Enabled = false;
                textBoxAd.Text = "";
                textBoxMovzu.Text = "";
                numericUpDownCapIli.Value = numericUpDownCapIli.Minimum;
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            buttonSil.Enabled = false;
            buttonSaxla.Enabled = true;
            comboBoxMuelliminKitablari.SelectedItem = null;
            secilmisMuellimKitabi = new MuellimKitabi();
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (secilmisMuellimKitabi == null) return;
            if (string.IsNullOrWhiteSpace(textBoxAd.Text))
            {
                MessageBox.Show("Ad olmalıdır.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxMovzu.Text))
            {
                MessageBox.Show("Mövzu olmalıdır.");
                return;
            }

            secilmisMuellimKitabi.Ad = textBoxAd.Text;
            secilmisMuellimKitabi.Movzu = textBoxMovzu.Text;
            secilmisMuellimKitabi.CapIli = numericUpDownCapIli.IntValue();
            Program.VBE.Store(secilmisMuellimKitabi);
            MuelliminKitablariniGetir(secilmisMuellimKitabi);
            MessageBox.Show("Müəllim Kitabı qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (secilmisMuellimKitabi == null) return;
            Program.VBE.Delete(secilmisMuellimKitabi);
            MuelliminKitablariniGetir();
            MessageBox.Show("Müəllim Kitabı silindi.");
        }

        void MuelliminKitablariniGetir(MuellimKitabi smk = null)
        {
            var muellimKitablari = (from MuellimKitabi mk in Program.VBE
                                    orderby mk.Ad ascending
                                    where mk.Muellim == this.Muellim
                                    select mk).ToList();
            comboBoxMuelliminKitablari.DataSource = muellimKitablari;
            comboBoxMuelliminKitablari.DisplayMember = "Ad";
            comboBoxMuelliminKitablari.SelectedItem = smk;
        }
    }
}
