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
    public partial class FormMuellimTehsili : Form
    {
        public FormMuellimTehsili()
        {
            InitializeComponent();
        }

        public Muellim Muellim { get; set; }
        MuellimTehsili secilmisMuehsillimTehsili;

        private void FormMuellimTehsili_Load(object sender, EventArgs e)
        {
            if (Muellim == null) this.Close();
            secilmisMuehsillimTehsili = null;
            buttonSil.Enabled = false;
            buttonSaxla.Enabled = false;

            UniversitetleriVeMuellimTehsilleriniGetir();
        }

        private void comboBoxMuellimTehsilleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilmisMuehsillimTehsili = comboBoxMuellimTehsilleri.SelectedItem as MuellimTehsili;
            if (secilmisMuehsillimTehsili != null)
            {
                comboBoxUniversitet.SelectedItem = secilmisMuehsillimTehsili.Universitet;
                textBoxIxtisas.Text = secilmisMuehsillimTehsili.Ixtisas;
                numericUpDownMezuniyyetIli.Value = secilmisMuehsillimTehsili.MezuniyyetIli;
                buttonSil.Enabled = true;
                buttonSaxla.Enabled = true;
            }
            else
            {
                comboBoxUniversitet.SelectedItem = null;
                textBoxIxtisas.Text = "";
                numericUpDownMezuniyyetIli.Value = numericUpDownMezuniyyetIli.Minimum;
                buttonSil.Enabled = false;
                buttonSaxla.Enabled = false;
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            buttonSil.Enabled = false;
            buttonSaxla.Enabled = true;
            comboBoxMuellimTehsilleri.SelectedIndex = -1;
            secilmisMuehsillimTehsili = new MuellimTehsili();
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (secilmisMuehsillimTehsili == null) return;
            if (comboBoxUniversitet.SelectedItem == null)
            {
                MessageBox.Show("Universitet olmalıdır.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxIxtisas.Text))
            {
                MessageBox.Show("İxtisas olmalıdır.");
                return;
            }
            if (comboBoxUniversitet.SelectedItem is Universitet)
                secilmisMuehsillimTehsili.Universitet = comboBoxUniversitet.SelectedItem as Universitet;
            else if (comboBoxUniversitet.SelectedItem is string)
                secilmisMuehsillimTehsili.Universitet = new Universitet { Ad = (comboBoxUniversitet.SelectedItem as string) };
            secilmisMuehsillimTehsili.Ixtisas = textBoxIxtisas.Text;
            secilmisMuehsillimTehsili.MezuniyyetIli = numericUpDownMezuniyyetIli.IntValue();
            Program.VBE.Store(secilmisMuehsillimTehsili);
            UniversitetleriVeMuellimTehsilleriniGetir();
            comboBoxMuellimTehsilleri.SelectedItem = secilmisMuehsillimTehsili;
            MessageBox.Show("Müellim Tehsili qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (secilmisMuehsillimTehsili == null) return;
            Program.VBE.Delete(secilmisMuehsillimTehsili);
            UniversitetleriVeMuellimTehsilleriniGetir();
            MessageBox.Show("Müellim Tehsili silindi.");
        }

        void UniversitetleriVeMuellimTehsilleriniGetir()
        {
            var universitetler = from Universitet u in Program.VBE
                                 select u;
            comboBoxUniversitet.DataSource = universitetler.ToList();
            comboBoxUniversitet.DisplayMember = "Ad";
            comboBoxUniversitet.SelectedIndex = -1;

            var muellimTehsilleri = from MuellimTehsili mt in Program.VBE
                                    orderby mt.Ad ascending
                                    where mt.Muellim == this.Muellim
                                    select mt;
            comboBoxMuellimTehsilleri.DataSource = muellimTehsilleri.ToList();
            comboBoxMuellimTehsilleri.DisplayMember = "Ad";
            comboBoxMuellimTehsilleri.SelectedIndex = -1;
        }
    }
}
