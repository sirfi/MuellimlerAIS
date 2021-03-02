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
    public partial class FormGiris : Form
    {
        IList<Universitet> universitetler;

        public FormGiris()
        {
            InitializeComponent();
        }

        void UniversitetleriGetir()
        {
            universitetler = (from Universitet u in Program.VBE select u).ToList();
            comboBoxUniversitet.DataSource = universitetler;
            comboBoxUniversitet.DisplayMember = "Ad";
        }

        private void FormGiris_Load(object sender, EventArgs e)
        {
            this.Height = 270;
            buttonGir.Enabled = false;
            UniversitetleriGetir();
            comboBoxUniversitet.SelectedItem = universitetler.SingleOrDefault(x => x.Secili != null && x.Secili.HasValue && x.Secili.Value);
        }

        private void buttonGir_Click(object sender, EventArgs e)
        {
            universitetler.Where(x => x.Secili != null && x.Secili.HasValue && x.Secili.Value).ToList().ForEach(x =>
            {
                if (x == Program.SecilmisUniversitet)
                {
                    x.Secili = true;
                }
                else
                {
                    x.Secili = false;
                }
                Program.VBE.Store(x);
            });
            this.Hide();
            Program.FormAna.Show();
        }

        private void buttonDuzelt_Click(object sender, EventArgs e)
        {
            if (this.Height == 270)
            {
                this.Height = 300;
            }
            else
            {
                this.Height = 270;
            }
        }

        private void comboBoxUniversitet_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.SecilmisUniversitet = comboBoxUniversitet.SelectedItem as Universitet;
            if (Program.SecilmisUniversitet != null)
            {
                buttonGir.Enabled = true;
                textBoxAd.Text = Program.SecilmisUniversitet.Ad;
                pictureBoxLogo.Image = ImageLib.ByteArrayToImage(Program.SecilmisUniversitet.Logo);
            }
            else
            {
                buttonGir.Enabled = false;
                textBoxAd.Text = "";
                pictureBoxLogo.Image = null;
            }
        }

        private void buttonLogoDeyisdir_Click(object sender, EventArgs e)
        {
            if (openFileDialogLogo.ShowDialog() == DialogResult.OK)
            {
                var logo = Image.FromFile(openFileDialogLogo.FileName);
                pictureBoxLogo.Image = ImageLib.ResizeImage(logo, new Size(200, 200));
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            comboBoxUniversitet.SelectedIndex = -1;
            Program.SecilmisUniversitet = new Universitet();
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (Program.SecilmisUniversitet == null) return;
            if (string.IsNullOrWhiteSpace(textBoxAd.Text))
            {
                MessageBox.Show("Universitetin adı olmalıdır.");
                return;
            }
            Program.SecilmisUniversitet.Ad = textBoxAd.Text;
            Program.SecilmisUniversitet.Logo = ImageLib.ImageToByteArray(pictureBoxLogo.Image);
            Program.VBE.Store(Program.SecilmisUniversitet);
            UniversitetleriGetir();
            comboBoxUniversitet.SelectedItem = Program.SecilmisUniversitet;
            MessageBox.Show("Universitet qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            Program.VBE.Delete(Program.SecilmisUniversitet);
            UniversitetleriGetir();
            comboBoxUniversitet.SelectedIndex = -1;
            MessageBox.Show("Universitet silindi.");
        }
    }
}
