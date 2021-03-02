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
    public partial class FormFakulteler : Form
    {
        Fakulte seciliFakulte;

        public FormFakulteler()
        {
            InitializeComponent();
        }

        public Universitet Universitet { get { return Program.SecilmisUniversitet; } }

        private void FormFakulteler_Load(object sender, EventArgs e)
        {
            if (this.Universitet == null)
            {
                this.Close();
                return;
            }
            this.Text = Universitet.Ad + " Fakültələri";
            seciliFakulte = null;
            buttonFakulteKafedralari.Enabled = false;
            buttonSaxla.Enabled = false;
            buttonSil.Enabled = false;

            FakulteleriGetir();
        }

        private void comboBoxFakulteler_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliFakulte = comboBoxFakulteler.SelectedItem as Fakulte;
            if (seciliFakulte != null)
            {
                var muellimler = (from Muellim m in Program.VBE
                                  orderby m.TamAdi ascending
                                  where m.VezifeliOlduguYer.Fakulte == seciliFakulte
                                  select m).ToList();

                comboBoxDekan.DataSource = muellimler;
                comboBoxDekan.DisplayMember = "TamAdi";
                comboBoxDekan.SelectedIndex = -1;

                comboBoxDekanMuavini.DataSource = muellimler;
                comboBoxDekanMuavini.DisplayMember = "TamAdi";
                comboBoxDekanMuavini.SelectedIndex = -1;

                textBoxAd.Text = seciliFakulte.Ad;
                comboBoxDekan.SelectedItem = seciliFakulte.Dekan;
                comboBoxDekanMuavini.SelectedItem = seciliFakulte.DekanMuavini;
                buttonFakulteKafedralari.Enabled = true;
                buttonSaxla.Enabled = true;
                buttonSil.Enabled = true;
            }
            else
            {
                textBoxAd.Text = "";
                comboBoxDekan.DataSource = null;
                comboBoxDekanMuavini.DataSource = null;
                buttonFakulteKafedralari.Enabled = false;
                buttonSaxla.Enabled = false;
                buttonSil.Enabled = false;
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            comboBoxFakulteler.SelectedIndex = -1;
            seciliFakulte = new Fakulte();
            seciliFakulte.Universitet = this.Universitet;
            buttonFakulteKafedralari.Enabled = true;
            buttonSaxla.Enabled = true;
            buttonSil.Enabled = true;
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (seciliFakulte == null)
            {
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxAd.Text))
            {
                MessageBox.Show("Ad olmalıdır.");
                return;
            }
            seciliFakulte.Ad = textBoxAd.Text;
            seciliFakulte.Dekan = comboBoxDekan.SelectedItem as Muellim;
            seciliFakulte.DekanMuavini = comboBoxDekanMuavini.SelectedItem as Muellim;
            Program.VBE.Store(seciliFakulte);
            FakulteleriGetir();
            comboBoxFakulteler.SelectedItem = seciliFakulte;
            MessageBox.Show("Fakültə qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Program.VBE.Delete(seciliFakulte);
            FakulteleriGetir();
            comboBoxFakulteler.SelectedIndex = -1;
            MessageBox.Show("Fakültə silindi.");
        }

        void FakulteleriGetir()
        {
            var fakulteler = from Fakulte f in Program.VBE
                             orderby f.Ad ascending
                             where f.Universitet == this.Universitet
                             select f;
            comboBoxFakulteler.DataSource = fakulteler.ToList();
            comboBoxFakulteler.DisplayMember = "Ad";
            comboBoxFakulteler.SelectedIndex = -1;
        }

        private void buttonFakulteKafedralari_Click(object sender, EventArgs e)
        {
            FormKafedralar formk = new FormKafedralar();
            formk.Fakulte = seciliFakulte;
            formk.MdiParent = Program.FormAna;
            formk.Show();
        }
    }
}
