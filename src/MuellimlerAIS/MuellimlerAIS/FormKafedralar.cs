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
    public partial class FormKafedralar : Form
    {
        Kafedra seciliKafedra;

        public FormKafedralar()
        {
            InitializeComponent();
        }

        private void FormKafedralar_Load(object sender, EventArgs e)
        {
            if (this.Fakulte == null)
            {
                this.Close();
                return;
            }
            this.Text = this.Fakulte.Ad + " Fakultəsi Kafedraları";
            seciliKafedra = null;
            buttonKafedraDersleri.Enabled = false;
            buttonKafedraIxtisaslari.Enabled = false; 
            buttonSil.Enabled = false;
            buttonSaxla.Enabled = false;

            kafedralariGetir();
        }

        private void comboBoxKafedralar_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliKafedra = comboBoxKafedralar.SelectedItem as Kafedra;
            if (seciliKafedra != null)
            {
                var muellimler = (from Muellim m in Program.VBE
                                  orderby m.TamAdi ascending
                                  where m.VezifeliOlduguYer == seciliKafedra
                                  select m).ToList();
                comboBoxMudir.DataSource = muellimler;
                comboBoxMudir.DisplayMember = "TamAdi";
                comboBoxMudir.SelectedIndex = -1;

                comboBoxMudirMuavini.DataSource = muellimler;
                comboBoxMudirMuavini.DisplayMember = "TamAdi";
                comboBoxMudirMuavini.SelectedIndex = -1;

                textBoxAd.Text = seciliKafedra.Ad;
                comboBoxMudir.SelectedItem = seciliKafedra.Mudir;
                comboBoxMudirMuavini.SelectedItem = seciliKafedra.MudirMuavini;
                buttonKafedraDersleri.Enabled = true;
                buttonKafedraIxtisaslari.Enabled = true;
                buttonSil.Enabled = true;
                buttonSaxla.Enabled = true;
            }
            else
            {
                textBoxAd.Text = "";
                comboBoxMudir.DataSource = null;
                comboBoxMudirMuavini.DataSource = null;
                buttonKafedraDersleri.Enabled = false;
                buttonKafedraIxtisaslari.Enabled = false;
                buttonSil.Enabled = false;
                buttonSaxla.Enabled = false;
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            comboBoxKafedralar.SelectedIndex = -1;
            seciliKafedra = new Kafedra();
            seciliKafedra.Fakulte = this.Fakulte;
            buttonKafedraDersleri.Enabled = true;
            buttonKafedraIxtisaslari.Enabled = true;
            buttonSil.Enabled = true;
            buttonSaxla.Enabled = true;
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (seciliKafedra == null) return;
            if (string.IsNullOrWhiteSpace(textBoxAd.Text))
            {
                MessageBox.Show("Ad olmalıdır.");
                return;
            }
            seciliKafedra.Ad = textBoxAd.Text;
            seciliKafedra.Mudir = comboBoxMudir.SelectedItem as Muellim;
            seciliKafedra.MudirMuavini = comboBoxMudirMuavini.SelectedItem as Muellim;
            Program.VBE.Store(seciliKafedra);
            kafedralariGetir();
            comboBoxKafedralar.SelectedItem = seciliKafedra;
            MessageBox.Show("Kafedra qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Program.VBE.Delete(seciliKafedra);
            kafedralariGetir();
            comboBoxKafedralar.SelectedIndex = -1;
            MessageBox.Show("Kafedra silindi.");
        }

        void kafedralariGetir()
        {
            var kafedralar = from Kafedra k in Program.VBE
                             orderby k.Ad ascending
                             where k.Fakulte == this.Fakulte
                             select k;
            comboBoxKafedralar.DataSource = kafedralar.ToList();
            comboBoxKafedralar.DisplayMember = "Ad";
            comboBoxKafedralar.SelectedIndex = -1;
        }

        public Fakulte Fakulte { get; set; }

        private void buttonKafedraDersleri_Click(object sender, EventArgs e)
        {
            var form = new FormDersler();
            form.Kafedra = this.seciliKafedra;
            form.MdiParent = Program.FormAna;
            form.Show();
        }

        private void buttonKafedraIxtisaslari_Click(object sender, EventArgs e)
        {
            var form = new FormIxtisaslar();
            form.Kafedra = this.seciliKafedra;
            form.MdiParent = Program.FormAna;
            form.Show();
        }
    }
}
