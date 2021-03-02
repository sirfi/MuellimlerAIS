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
    public partial class FormMuellimMeqaleleri : Form
    {
        public FormMuellimMeqaleleri()
        {
            InitializeComponent();
        }

        public Muellim Muellim { get; set; }
        MuellimMeqalesi secilmisMuellimMeqalesi;

        private void FormMuellimMeqaleleri_Load(object sender, EventArgs e)
        {
            if (Muellim == null) this.Close();
            this.Text = Muellim.TamAdi + " Müəllimin Kitabları";
            secilmisMuellimMeqalesi = null;
            buttonSil.Enabled = false;
            buttonSaxla.Enabled = false;

            MuellimMeqaleleriniGetir();
        }

        private void comboBoxMuellimMeqaleleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilmisMuellimMeqalesi = comboBoxMuellimMeqaleleri.SelectedItem as MuellimMeqalesi;
            if (secilmisMuellimMeqalesi != null)
            {
                buttonSil.Enabled = true;
                buttonSaxla.Enabled = true;
                textBoxMovzu.Text = secilmisMuellimMeqalesi.Movzu;
                maskedTextBoxNesrTarixi.Text = secilmisMuellimMeqalesi.NesrTarixi.ToString("dd.MM.yyyy");
            }
            else
            {
                buttonSil.Enabled = false;
                buttonSaxla.Enabled = false;
                textBoxMovzu.Text = "";
                maskedTextBoxNesrTarixi.Text = "";
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            buttonSil.Enabled = false;
            buttonSaxla.Enabled = true;
            comboBoxMuellimMeqaleleri.SelectedItem = null;
            secilmisMuellimMeqalesi = new MuellimMeqalesi();
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (secilmisMuellimMeqalesi == null) return;
            if (string.IsNullOrWhiteSpace(textBoxMovzu.Text))
            {
                MessageBox.Show("Mövzu olmalıdır.");
                return;
            }
            DateTime nesrTarixi;
            if (DateTime.TryParse(maskedTextBoxNesrTarixi.Text, out nesrTarixi))
            {
                MessageBox.Show("Nəşr Tarixi etibarlı tarix olmalıdır.");
                return;
            }

            secilmisMuellimMeqalesi.Movzu = textBoxMovzu.Text;
            secilmisMuellimMeqalesi.NesrTarixi = nesrTarixi;

            Program.VBE.Store(secilmisMuellimMeqalesi);
            MuellimMeqaleleriniGetir(secilmisMuellimMeqalesi);
            MessageBox.Show("Müəllim Məqaləsi qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (secilmisMuellimMeqalesi == null) return;
            Program.VBE.Delete(secilmisMuellimMeqalesi);
            MuellimMeqaleleriniGetir();
            MessageBox.Show("Müəllim Məqaləsi silindi.");
        }

        void MuellimMeqaleleriniGetir(MuellimMeqalesi smm = null)
        {
            var muellimMeqaleleri = from MuellimMeqalesi mm in Program.VBE
                                    orderby mm.Ad ascending
                                    where mm.Muellim == this.Muellim
                                    select mm;
            comboBoxMuellimMeqaleleri.DataSource = muellimMeqaleleri.ToList();
            comboBoxMuellimMeqaleleri.DisplayMember = "Ad";
            comboBoxMuellimMeqaleleri.SelectedItem = smm;
        }
    }
}
