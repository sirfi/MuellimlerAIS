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
    public partial class FormIxtisasDersleri : Form
    {
        public FormIxtisasDersleri()
        {
            InitializeComponent();
        }

        public Ixtisas Ixtisas { get; set; }
        private IxtisasDersi secilmisIxtisasDersi;

        class Semestr
        {
            public string Ad { get; set; }
            public int No { get; set; }
        }

        private void FormIxtisasDersleri_Load(object sender, EventArgs e)
        {
            if (Ixtisas == null) { this.Close(); return; }
            this.Text = Ixtisas.Ad + " İxtisası Dərsləri";
            secilmisIxtisasDersi = null;

            buttonSaxla.Enabled = false;
            buttonSil.Enabled = false;

            var dersler = from Ders d in Program.VBE
                          orderby d.Ad ascending
                          select d;
            comboBoxDers.DataSource = dersler.ToList();
            comboBoxDers.DisplayMember = "Ad";

            var semestrlar = new List<Semestr>();
            semestrlar.Add(new Semestr { Ad = "I Semestr", No = 1 });
            semestrlar.Add(new Semestr { Ad = "II Semestr", No = 2 });
            semestrlar.Add(new Semestr { Ad = "III Semestr", No = 3 });
            semestrlar.Add(new Semestr { Ad = "IV Semestr", No = 4 });
            if (Ixtisas.Tur == IxtisasTuru.Bakalavr)
            {
                semestrlar.Add(new Semestr { Ad = "V Semestr", No = 5 });
                semestrlar.Add(new Semestr { Ad = "VI Semestr", No = 6 });
                semestrlar.Add(new Semestr { Ad = "VII Semestr", No = 7 });
                semestrlar.Add(new Semestr { Ad = "VIII Semestr", No = 8 });
            }
            comboBoxSemestr.DataSource = semestrlar;
            comboBoxSemestr.DisplayMember = "Ad";
            comboBoxSemestr.ValueMember = "No";

            ixtisasDersleriniGetir();
        }

        private void comboBoxIxtisasDersleri_SelectedIndexChanged(object sender, EventArgs e)
        {
            secilmisIxtisasDersi = comboBoxIxtisasDersleri.SelectedItem as IxtisasDersi;
            if (secilmisIxtisasDersi != null)
            {
                buttonSaxla.Enabled = true;
                buttonSil.Enabled = true;
                comboBoxDers.SelectedItem = secilmisIxtisasDersi.Ders;
                comboBoxSemestr.SelectedValue = secilmisIxtisasDersi.Semestr;
                numericUpDownBuraxilisIsineRehberlik.Value = secilmisIxtisasDersi.BirakilisIsineRehberlik;
                numericUpDownDigerDersYuku.Value = secilmisIxtisasDersi.DigerDersYuku;
                numericUpDownHQIEvTapsiriklari.Value = secilmisIxtisasDersi.HQIEvTapsiriklari;
                numericUpDownImtihan.Value = secilmisIxtisasDersi.Imtihan;
                numericUpDownKursIsi.Value = secilmisIxtisasDersi.KurIsi;
                numericUpDownLaboratoriya.Value = secilmisIxtisasDersi.Laboratoriya;
                numericUpDownMagistrDissertasiyasinaRehberlik.Value = secilmisIxtisasDersi.MagistrDissertasiyasinaRehberlik;
                numericUpDownMagistrMeslehet.Value = secilmisIxtisasDersi.MagistrMeslehet;
                numericUpDownMagistrPrograminaRehberlik.Value = secilmisIxtisasDersi.MagistrPrograminaRehberlik;
                numericUpDownMeqbul.Value = secilmisIxtisasDersi.Meqbul;
                numericUpDownMeslehet.Value = secilmisIxtisasDersi.Meslehet;
                numericUpDownMesqeleSeminar.Value = secilmisIxtisasDersi.MesqeleSeminer;
                numericUpDownMuhazire.Value = secilmisIxtisasDersi.Muhazire;
                numericUpDownReferat.Value = secilmisIxtisasDersi.Referat;
                numericUpDownTecrubeyeRehberlik.Value = secilmisIxtisasDersi.TecrubeyeRehberlik;
                buttonSaxla.Enabled = true;
                buttonSil.Enabled = true;
            }
            else
            {
                buttonSaxla.Enabled = false;
                buttonSil.Enabled = false;
                comboBoxDers.SelectedItem = null;
                comboBoxSemestr.SelectedItem = null;
                numericUpDownBuraxilisIsineRehberlik.Value = 0m;
                numericUpDownDigerDersYuku.Value = 0m;
                numericUpDownHQIEvTapsiriklari.Value = 0m;
                numericUpDownImtihan.Value = 0m;
                numericUpDownKursIsi.Value = 0m;
                numericUpDownLaboratoriya.Value = 0m;
                numericUpDownMagistrDissertasiyasinaRehberlik.Value = 0m;
                numericUpDownMagistrMeslehet.Value = 0m;
                numericUpDownMagistrPrograminaRehberlik.Value = 0m;
                numericUpDownMeqbul.Value = 0m;
                numericUpDownMeslehet.Value = 0m;
                numericUpDownMesqeleSeminar.Value = 0m;
                numericUpDownMuhazire.Value = 0m;
                numericUpDownReferat.Value = 0m;
                numericUpDownTecrubeyeRehberlik.Value = 0m;
                buttonSaxla.Enabled = false;
                buttonSil.Enabled = false;
            }
        }

        private void buttonYeni_Click(object sender, EventArgs e)
        {
            comboBoxIxtisasDersleri.SelectedItem = null;
            secilmisIxtisasDersi = new IxtisasDersi();
            secilmisIxtisasDersi.Ixtisas = this.Ixtisas;
            buttonSaxla.Enabled = true;
            buttonSil.Enabled = false;
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            if (secilmisIxtisasDersi == null) return;

            if (comboBoxDers.SelectedItem == null)
            {
                MessageBox.Show("Dərs səçilməlidir.");
                return;
            }

            if (comboBoxSemestr.SelectedValue == null)
            {
                MessageBox.Show("Semestr səçilməlidir.");
                return;
            }

            if (numericUpDownBuraxilisIsineRehberlik.Value == 0m && numericUpDownDigerDersYuku.Value == 0m && numericUpDownHQIEvTapsiriklari.Value == 0m && numericUpDownImtihan.Value == 0m && numericUpDownKursIsi.Value == 0m && numericUpDownLaboratoriya.Value == 0m && numericUpDownMagistrDissertasiyasinaRehberlik.Value == 0m && numericUpDownMagistrMeslehet.Value == 0m && numericUpDownMagistrPrograminaRehberlik.Value == 0m && numericUpDownMeqbul.Value == 0m && numericUpDownMeslehet.Value == 0m && numericUpDownMesqeleSeminar.Value == 0m && numericUpDownMuhazire.Value == 0m && numericUpDownReferat.Value == 0m && numericUpDownTecrubeyeRehberlik.Value == 0m)
            {
                MessageBox.Show("Dərs hissələrinin ən az biri yazılmalıdır.");
                return;
            }

            secilmisIxtisasDersi.Ders = comboBoxDers.SelectedItem as Ders;
            secilmisIxtisasDersi.Semestr = (int)comboBoxSemestr.SelectedValue;
            secilmisIxtisasDersi.BirakilisIsineRehberlik = numericUpDownBuraxilisIsineRehberlik.IntValue();
            secilmisIxtisasDersi.DigerDersYuku = numericUpDownDigerDersYuku.IntValue();
            secilmisIxtisasDersi.HQIEvTapsiriklari = numericUpDownHQIEvTapsiriklari.IntValue();
            secilmisIxtisasDersi.Imtihan = numericUpDownImtihan.IntValue();
            secilmisIxtisasDersi.KurIsi = numericUpDownKursIsi.IntValue();
            secilmisIxtisasDersi.Laboratoriya = numericUpDownLaboratoriya.IntValue();
            secilmisIxtisasDersi.MagistrDissertasiyasinaRehberlik = numericUpDownMagistrDissertasiyasinaRehberlik.IntValue();
            secilmisIxtisasDersi.MagistrMeslehet = numericUpDownMagistrMeslehet.IntValue();
            secilmisIxtisasDersi.MagistrPrograminaRehberlik = numericUpDownMagistrPrograminaRehberlik.IntValue();
            secilmisIxtisasDersi.Meqbul = numericUpDownMeqbul.IntValue();
            secilmisIxtisasDersi.Meslehet = numericUpDownMeslehet.IntValue();
            secilmisIxtisasDersi.MesqeleSeminer = numericUpDownMesqeleSeminar.IntValue();
            secilmisIxtisasDersi.Muhazire = numericUpDownMuhazire.IntValue();
            secilmisIxtisasDersi.Referat = numericUpDownReferat.IntValue();
            secilmisIxtisasDersi.TecrubeyeRehberlik = numericUpDownTecrubeyeRehberlik.IntValue();

            Program.VBE.Store(secilmisIxtisasDersi);
            ixtisasDersleriniGetir();
            comboBoxIxtisasDersleri.SelectedItem = secilmisIxtisasDersi;
            MessageBox.Show("İxtisasın dərsi qeyd edildi.");
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (secilmisIxtisasDersi == null) return;
            Program.VBE.Delete(secilmisIxtisasDersi);
            MessageBox.Show("İxtisasın dərsi silindi.");
        }

        void ixtisasDersleriniGetir()
        {
            var ixtisasDersleri = (from IxtisasDersi id in Program.VBE
                                   orderby id.Ad ascending
                                   where id.Ixtisas == this.Ixtisas
                                   select id).ToList();
            comboBoxIxtisasDersleri.DataSource = ixtisasDersleri;
            comboBoxIxtisasDersleri.DisplayMember = "Ad";
            comboBoxIxtisasDersleri.SelectedItem = null;
        }
    }
}
