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
    public partial class FormUniversitetRektorVeProrektorleri : Form
    {
        private UniversitetProrektoru seciliUniversitetProrektoru;
        public Universitet Universitet { get { return Program.SecilmisUniversitet; } }

        public FormUniversitetRektorVeProrektorleri()
        {
            InitializeComponent();
        }

        void MuellimleriGetir()
        {
            var muellimler = from Muellim m in Program.VBE where m.VezifeliOlduguYer.Fakulte.Universitet == this.Universitet orderby m.TamAdi ascending select m;
            
            comboBoxRektor.DataSource = muellimler.ToList();
            comboBoxRektor.DisplayMember = "TamAdi";
            
            comboBoxProrektor.DataSource = muellimler.ToList();
            comboBoxProrektor.DisplayMember = "TamAdi";
        }

        private void FormUniversitetProrektorleri_Load(object sender, EventArgs e)
        {
            if (Universitet == null)
            {
                this.Close();
                return;
            }
            this.Text = this.Universitet.Ad + " Rektor Və Prorektorləri";
            buttonSaxla.Enabled = false;
            buttonSil.Enabled = false;
            MuellimleriGetir();
            UniversitetProrektorleriniGetir();
        }

        void UniversitetProrektorleriniGetir()
        {
            var uprorektorler = from UniversitetProrektoru up in Program.VBE orderby up.Vezife ascending where up.Universitet==this.Universitet select up;
            comboBoxUniversitetProrektorleri.DataSource = uprorektorler.ToList();
            comboBoxUniversitetProrektorleri.DisplayMember = "Vezife";
        }

        private void comboBoxUniversitetProrektorleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            seciliUniversitetProrektoru = comboBoxUniversitetProrektorleri.SelectedItem as UniversitetProrektoru;
            if (seciliUniversitetProrektoru==null)
            {
                textBoxVezife.Text = "";
                comboBoxProrektor.SelectedIndex = -1;
                buttonSaxla.Enabled = true;
                buttonSil.Enabled = true;
            }
            else
            {
                textBoxVezife.Text = seciliUniversitetProrektoru.Vezife;
                comboBoxProrektor.SelectedItem = seciliUniversitetProrektoru.Prorektor;
                buttonSaxla.Enabled = false;
                buttonSil.Enabled = false;
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            comboBoxUniversitetProrektorleri.SelectedIndex = -1;
            seciliUniversitetProrektoru = new UniversitetProrektoru();
            seciliUniversitetProrektoru.Universitet = this.Universitet;
            buttonSaxla.Enabled = true;
            buttonSil.Enabled = false;
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxVezife.Text))
            {
                MessageBox.Show("Prorektorun vəzifəsi olmalıdır.");
                return;
            }
            seciliUniversitetProrektoru.Vezife = textBoxVezife.Text;
            seciliUniversitetProrektoru.Prorektor = comboBoxProrektor.SelectedItem as Muellim;
            Program.VBE.Store(seciliUniversitetProrektoru);
            UniversitetProrektorleriniGetir();
            comboBoxUniversitetProrektorleri.SelectedItem = seciliUniversitetProrektoru;
            MessageBox.Show("Prorektor qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Program.VBE.Delete(seciliUniversitetProrektoru);
            UniversitetProrektorleriniGetir();
            comboBoxUniversitetProrektorleri.SelectedIndex = -1;
            MessageBox.Show("Prorektor silindi.");
        }
    }
}
