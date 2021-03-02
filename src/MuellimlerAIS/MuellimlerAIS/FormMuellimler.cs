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
using MuellimlerAIS.Libs;

namespace MuellimlerAIS
{
    public partial class FormMuellimler : Form
    {
        Muellim secilmisMuellim;

        public FormMuellimler()
        {
            InitializeComponent();
        }

        private void FormMuellimler_Load(object sender, EventArgs e)
        {
            secilmisMuellim = null;
            comboBoxVezifeliOlduguKafedra.Enabled = false;
            butonlarAktifPasif(false);
            MuellimleriVeElmiDereceVeVezifeleriGetir();
            numericUpDownBaslamaIli.Maximum = DateTime.Today.Year;

            var fakulteler = (from Fakulte f in Program.VBE
                              orderby f.Ad ascending
                              where f.Universitet == Program.SecilmisUniversitet
                              select f).ToList();

            comboBoxVezifeliOlduguFakulte.DataSource = fakulteler;
            comboBoxVezifeliOlduguFakulte.DisplayMember = "Ad";

        }

        private void comboBoxMuellimler_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilmisMuellim = comboBoxMuellimler.SelectedItem as Muellim;
            if (secilmisMuellim != null)
            {
                textBoxAd.Text = secilmisMuellim.Ad;
                textBoxFamilya.Text = secilmisMuellim.Familya;
                textBoxAtaAdi.Text = secilmisMuellim.AtaAdi;
                comboBoxCinsiyyet.SelectedItem = secilmisMuellim.Cinsiyyet ? "Kişi" : "Qadın";
                maskedTextBoxDogulduguTarix.Text = secilmisMuellim.DogulduguTarix.ToString("dd.MM.yyyy");
                textBoxDogulduguYer.Text = secilmisMuellim.DogulduguYer;
                textBoxMilliyet.Text = secilmisMuellim.Milliyet;
                textBoxVetendasliq.Text = secilmisMuellim.Vetendaslik;
                maskedTextBoxEvTelefonNomresi.Text = secilmisMuellim.EvTelefonuNomresi;
                maskedTextBoxMobilTelefonNomresi.Text = secilmisMuellim.MobilTelefonNomresi;
                textBoxEvUnvani.Text = secilmisMuellim.EvUnvani;
                comboBoxElmiDerece.SelectedItem = secilmisMuellim.ElmiDerece;
                numericUpDownBaslamaIli.Value = secilmisMuellim.BaslamaIli < 1900 || DateTime.Today.Year < secilmisMuellim.BaslamaIli ? 1900 : secilmisMuellim.BaslamaIli;
                comboBoxVezife.SelectedItem = secilmisMuellim.Vezife;
                comboBoxVezifeliOlduguFakulte.SelectedItem = secilmisMuellim.VezifeliOlduguYer.Fakulte;
                comboBoxVezifeliOlduguKafedra.SelectedItem = secilmisMuellim.VezifeliOlduguYer;
                pictureBoxSekil.Image = ImageLib.ByteArrayToImage(secilmisMuellim.Sekil);
                butonlarAktifPasif(true);
            }
            else
            {
                textBoxAd.Text = "";
                textBoxFamilya.Text = "";
                textBoxAtaAdi.Text = "";
                comboBoxCinsiyyet.SelectedItem = null;
                maskedTextBoxDogulduguTarix.Text = "";
                textBoxDogulduguYer.Text = "";
                textBoxMilliyet.Text = "";
                textBoxVetendasliq.Text = "";
                maskedTextBoxEvTelefonNomresi.Text = "";
                maskedTextBoxMobilTelefonNomresi.Text = "";
                textBoxEvUnvani.Text = "";
                comboBoxElmiDerece.SelectedItem = null;
                numericUpDownBaslamaIli.Value = 1900m;
                comboBoxVezife.SelectedItem = null;
                comboBoxVezifeliOlduguFakulte.SelectedItem = null;
                comboBoxVezifeliOlduguKafedra.SelectedItem = null;
                pictureBoxSekil.Image = null;
                comboBoxVezifeliOlduguKafedra.Enabled = false;
                butonlarAktifPasif(false);
            }
        }

        private void comboBoxVezifeliOlduguFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilmisFakulte = comboBoxVezifeliOlduguFakulte.SelectedItem as Fakulte;
            if (secilmisFakulte != null)
            {
                var kafedralar = (from Kafedra k in Program.VBE
                                  orderby k.Ad ascending
                                  where k.Fakulte == secilmisFakulte
                                  select k).ToList();

                comboBoxVezifeliOlduguKafedra.DataSource = kafedralar;
                comboBoxVezifeliOlduguKafedra.DisplayMember = "Ad";
                if (secilmisMuellim != null)
                    comboBoxVezifeliOlduguKafedra.SelectedItem = secilmisMuellim.VezifeliOlduguYer;
                comboBoxVezifeliOlduguKafedra.Enabled = true;
            }
            else
            {
                comboBoxVezifeliOlduguKafedra.DataSource = null;
                comboBoxVezifeliOlduguKafedra.Enabled = false;
            }
        }

        private void buttonSekilDeyisdir_Click(object sender, EventArgs e)
        {
            if (secilmisMuellim == null) return;
            if (openFileDialogSekil.ShowDialog() == DialogResult.OK)
            {
                var sekil = Image.FromFile(openFileDialogSekil.FileName);
                pictureBoxSekil.Image = ImageLib.ResizeImage(sekil, new Size(160, 200));
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            secilmisMuellim = new Muellim();
            comboBoxMuellimler.SelectedItem = null;
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (secilmisMuellim == null) return;
            if (string.IsNullOrWhiteSpace(textBoxAd.Text))
            {
                MessageBox.Show("Ad olmalıdır");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxFamilya.Text))
            {
                MessageBox.Show("Familya olmalıdır");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxAtaAdi.Text))
            {
                MessageBox.Show("Ata Adı olmalıdır");
                return;
            }
            if (comboBoxCinsiyyet.SelectedItem == null)
            {
                MessageBox.Show("Cinsiyyət seçilməlidir");
                return;
            }
            DateTime dogulduguTarix;
            if (string.IsNullOrWhiteSpace(maskedTextBoxDogulduguTarix.Text) || !DateTime.TryParse(maskedTextBoxDogulduguTarix.Text, out dogulduguTarix) || dogulduguTarix.Year > DateTime.Today.Year)
            {
                MessageBox.Show("Doğulduğu tarix etibarlı tarix olmalıdır");
                return;
            }
            if (comboBoxElmiDerece.SelectedItem == null && string.IsNullOrWhiteSpace(comboBoxElmiDerece.Text))
            {
                MessageBox.Show("Elmi Dərəcə seçilməlidir və ya yazılmalıdır");
                return;
            }
            if (comboBoxVezife.SelectedItem == null && string.IsNullOrWhiteSpace(comboBoxVezife.Text))
            {
                MessageBox.Show("Elmi Vəzifə seçilməlidir və ya yazılmalıdır");
                return;
            }
            if (comboBoxVezifeliOlduguKafedra.SelectedItem == null)
            {
                MessageBox.Show("Vəzifəli Olduğu Yer seçilməlidir");
                return;
            }
            secilmisMuellim.Ad = textBoxAd.Text;
            secilmisMuellim.Familya = textBoxFamilya.Text;
            secilmisMuellim.AtaAdi = textBoxAtaAdi.Text;
            secilmisMuellim.Cinsiyyet = comboBoxCinsiyyet.SelectedItem.ToString() == "Kişi" ? true : false;
            secilmisMuellim.DogulduguTarix = dogulduguTarix;
            secilmisMuellim.DogulduguYer = textBoxDogulduguYer.Text;
            secilmisMuellim.Milliyet = textBoxMilliyet.Text;
            secilmisMuellim.Vetendaslik = textBoxVetendasliq.Text;
            secilmisMuellim.EvTelefonuNomresi = maskedTextBoxEvTelefonNomresi.Text;
            secilmisMuellim.MobilTelefonNomresi = maskedTextBoxMobilTelefonNomresi.Text;
            secilmisMuellim.EvUnvani = textBoxEvUnvani.Text;
            secilmisMuellim.BaslamaIli = numericUpDownBaslamaIli.IntValue();
            if (comboBoxElmiDerece.SelectedItem is ElmiDerece)
            {
                secilmisMuellim.ElmiDerece = comboBoxElmiDerece.SelectedItem as ElmiDerece;
            }
            else
            {
                secilmisMuellim.ElmiDerece = new ElmiDerece() { Ad = comboBoxElmiDerece.Text };
            }
            if (comboBoxVezife.SelectedItem is Vezife)
            {
                secilmisMuellim.Vezife = comboBoxVezife.SelectedItem as Vezife;
            }
            else
            {
                secilmisMuellim.Vezife = new Vezife() { Ad = comboBoxVezife.Text };
            }
            secilmisMuellim.VezifeliOlduguYer = comboBoxVezifeliOlduguKafedra.SelectedItem as Kafedra;
            secilmisMuellim.Sekil = ImageLib.ImageToByteArray(pictureBoxSekil.Image);
            Program.VBE.Store(secilmisMuellim);
            MuellimleriVeElmiDereceVeVezifeleriGetir(); comboBoxMuellimler.SelectedItem = secilmisMuellim;
            MessageBox.Show("Müəllim qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (secilmisMuellim == null) return;
            Program.VBE.Delete(secilmisMuellim);
            MuellimleriVeElmiDereceVeVezifeleriGetir();
            comboBoxMuellimler.SelectedIndex = -1;
            MessageBox.Show("Müəllim silindi.");
        }

        private void buttonBildiyiDiller_Click(object sender, EventArgs e)
        {
            if (secilmisMuellim == null) return;
            FormMuelliminBildiyiDiller form = new FormMuelliminBildiyiDiller();
            form.Muellim = secilmisMuellim;
            form.MdiParent = Program.FormAna;
            form.Show();
        }

        private void buttonDeyeBildiyiDersler_Click(object sender, EventArgs e)
        {
            if (secilmisMuellim == null) return;
            var form = new FormMuelliminDeyeBildiyiDersler();
            form.Muellim = secilmisMuellim;
            form.MdiParent = Program.FormAna;
            form.Show();
        }

        void MuellimleriVeElmiDereceVeVezifeleriGetir()
        {
            var muellimler = (from Muellim m in Program.VBE
                              orderby m.Familya, m.Ad, m.AtaAdi ascending
                              where m.VezifeliOlduguYer.Fakulte.Universitet == Program.SecilmisUniversitet
                              select m).ToList();
            comboBoxMuellimler.DataSource = muellimler;
            comboBoxMuellimler.DisplayMember = "TamAdi";
            comboBoxMuellimler.SelectedIndex = -1;

            var elmiDereceler = (from ElmiDerece ed in Program.VBE
                                 orderby ed.Ad
                                 select ed).ToList();
            comboBoxElmiDerece.DataSource = elmiDereceler;
            comboBoxElmiDerece.DisplayMember = "Ad";

            var elmiVezifeler = (from Vezife ev in Program.VBE
                                 orderby ev.Ad
                                 select ev).ToList();
            comboBoxVezife.DataSource = elmiVezifeler;
            comboBoxVezife.DisplayMember = "Ad";
        }

        private void buttonElmiDereceSil_Click(object sender, EventArgs e)
        {
            if (comboBoxElmiDerece.SelectedItem != null && comboBoxElmiDerece.SelectedItem is ElmiDerece)
            {
                Program.VBE.Delete(comboBoxElmiDerece.SelectedItem as ElmiDerece);

                var elmiDereceler = (from ElmiDerece ed in Program.VBE
                                     orderby ed.Ad
                                     select ed).ToList();
                comboBoxElmiDerece.DataSource = elmiDereceler;
                comboBoxElmiDerece.DisplayMember = "Ad";
            }
        }

        private void buttonElmiVezifeSil_Click(object sender, EventArgs e)
        {
            if (comboBoxVezife.SelectedItem != null && comboBoxVezife.SelectedItem is Vezife)
            {
                Program.VBE.Delete(comboBoxVezife.SelectedItem as Vezife);

                var elmiVezifeler = (from Vezife ev in Program.VBE
                                     orderby ev.Ad
                                     select ev).ToList();
                comboBoxVezife.DataSource = elmiVezifeler;
                comboBoxVezife.DisplayMember = "Ad";
            }
        }

        private void buttonTehsilleri_Click(object sender, EventArgs e)
        {
            var form = new FormMuellimTehsili();
            form.Muellim = secilmisMuellim;
            form.MdiParent = Program.FormAna;
            form.Show();
        }

        private void buttonMeqaleleri_Click(object sender, EventArgs e)
        {
            var form = new FormMuellimMeqaleleri();
            form.Muellim = secilmisMuellim;
            form.MdiParent = Program.FormAna;
            form.Show();
        }

        private void buttonKitablari_Click(object sender, EventArgs e)
        {
            var form = new FormMuellimKitablari();
            form.Muellim = secilmisMuellim;
            form.MdiParent = Program.FormAna;
            form.Show();
        }

        void butonlarAktifPasif(bool durum)
        {
            this.Controls.OfType<Button>().ToList().ForEach(x =>
            {
                if (x.Text != "Yeni")
                {
                    x.Enabled = durum;
                }
            });
        }
    }
}
