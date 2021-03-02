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
using MuellimlerAIS.VerilenlerStrukturlari;

namespace MuellimlerinTedrisYuku
{
    public partial class FormManualDuzelis : Form
    {
        private Muellim secilmisMuellim;
        private int tedrisIli;
        public FormManualDuzelis()
        {
            InitializeComponent();
        }

        private void FormAna_Load(object sender, EventArgs e)
        {
            var tedrisIlleri = new List<TedrisIli>();
            for (int i = DateTime.Today.Year - 10; i < DateTime.Today.Year + 10; i++)
            {
                var ty = new TedrisIli { Il = i };
                tedrisIlleri.Add(ty);
            }
            comboBoxTedrisIli.DataSource = tedrisIlleri;
            comboBoxTedrisIli.DisplayMember = "Ad";
            comboBoxTedrisIli.ValueMember = "Il";
            comboBoxTedrisIli.SelectedItem = tedrisIlleri.SingleOrDefault(x => DateTime.Today.AddMonths(-7).Year == x.Il);

            var fakulteler = from Fakulte f in Program.VBE
                             orderby f.Ad ascending
                             where f.Universitet == Program.SecilmisUniversitet
                             select f;
            comboBoxFakulte.DataSource = fakulteler.ToList();
            comboBoxFakulte.DisplayMember = "Ad";

            var ixtisasQruplari = (from IxtisasQrubu iq in Program.VBE
                                   orderby iq.Ad ascending
                                   select iq).ToList();
            foreach (var ixtisasQrubu in ixtisasQruplari)
            {
                flowLayoutPanelIxtisasGruplari.Controls.Add(new ButtonIxtisasQrubu(ixtisasQrubu));
            }
        }

        private void comboBoxFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilmisFakulte = comboBoxFakulte.SelectedItem as Fakulte;
            if (secilmisFakulte != null)
            {
                var kafedralar = (from Kafedra k in Program.VBE
                                  orderby k.Ad ascending
                                  where k.Fakulte == secilmisFakulte
                                  select k).ToList();

                comboBoxKafedra.DataSource = kafedralar;
                comboBoxKafedra.DisplayMember = "Ad";
            }
            else
            {
                comboBoxKafedra.DataSource = null;
            }
        }

        private void comboBoxKafedra_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilmisKafedra = comboBoxKafedra.SelectedItem as Kafedra;
            if (secilmisKafedra != null)
            {
                var muellimler = (from Muellim m in Program.VBE
                                  orderby m.Familya, m.Ad, m.AtaAdi ascending
                                  where m.VezifeliOlduguYer == secilmisKafedra
                                  select m).ToList();
                comboBoxMuellim.DataSource = muellimler;
                comboBoxMuellim.DisplayMember = "TamAdi";
            }
            else
            {
                comboBoxMuellim.DataSource = null;
                flowLayoutPanelIxtisasGruplari.Controls.Clear();
            }
        }

        private void comboBoxMuellim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTedrisIli.SelectedItem == null)
            {
                MessageBox.Show("Tədris İli səçilməlidir.");
                return;
            }
            secilmisMuellim = comboBoxMuellim.SelectedItem as Muellim;
            if (secilmisMuellim != null)
            {
                var deyeBildiyiDersler = (from MuelliminDeyeBildiyiDers mdbd in Program.VBE
                                          orderby mdbd.Ad ascending
                                          where mdbd.Muellim == secilmisMuellim
                                          select mdbd).ToList();

                var tedrisYukleri = (from TedrisYuku ty in Program.VBE
                                     where ty.Muellim == secilmisMuellim
                                     select ty).ToList();

                flowLayoutPanelPayizSemestriDersleri.Controls.Clear();
                flowLayoutPanelYazSemestriDersleri.Controls.Clear();

                foreach (var dders in deyeBildiyiDersler)
                {
                    var payizSemestrDersi = new UserControlDers()
                    {
                        YazSemestriMi = false,
                        Muellim = secilmisMuellim,
                        Ders = dders.Ders,
                        TedrisIli = tedrisIli,
                        TedrisYukleri = tedrisYukleri.Where(x =>
                        {
                            var ixtisasDersiSayi = (from IxtisasDersi id in Program.VBE
                                                    where id.Semestr % 2 == 1 && id.Ders==x.Ders && id.Ixtisas == x.Qrup.Ixtisas
                                                    select id).Count();
                            return x.TedrisIli == tedrisIli && x.Ders == dders.Ders && ixtisasDersiSayi > 0;
                        }).ToList()
                    };
                    payizSemestrDersi.DersSaatiCemiDeyisti += payizSemestrDersi_DersSaatiCemiDeyisti;
                    flowLayoutPanelPayizSemestriDersleri.Controls.Add(payizSemestrDersi);
                    var yazSemestrDersi = new UserControlDers()
                    {
                        YazSemestriMi = true,
                        Muellim = secilmisMuellim,
                        Ders = dders.Ders,
                        TedrisIli = tedrisIli,
                        TedrisYukleri = tedrisYukleri.Where(x =>
                            {
                                var ixtisasDersiSayi = (from IxtisasDersi id in Program.VBE
                                                        where id.Semestr % 2 == 0 && id.Ders == x.Ders && id.Ixtisas == x.Qrup.Ixtisas
                                                        select id).Count();
                                return x.TedrisIli == tedrisIli && x.Ders == dders.Ders && ixtisasDersiSayi > 0;
                            }).ToList()
                    };
                    yazSemestrDersi.DersSaatiCemiDeyisti += yazSemestrDersi_DersSaatiCemiDeyisti;
                    flowLayoutPanelYazSemestriDersleri.Controls.Add(yazSemestrDersi);
                }
            }
            else
            {
                flowLayoutPanelPayizSemestriDersleri.Controls.Clear();
                flowLayoutPanelYazSemestriDersleri.Controls.Clear();
            }
        }

        Dictionary<Ders, int> yazSemestrDersleri = new Dictionary<Ders, int>();
        int yazSemestrDersSaatleriCemi = 0;
        void yazSemestrDersi_DersSaatiCemiDeyisti(object sender, DersSaatiCemiDeyistiEventArgs e)
        {
            if (yazSemestrDersleri.Keys.Count(x => x == e.Ders) == 0)
            {
                yazSemestrDersleri.Add(e.Ders, e.DersSaatiCemi);
            }
            else
            {
                yazSemestrDersleri[e.Ders] = e.DersSaatiCemi;
            }
            yazSemestrDersSaatleriCemi = 0;
            foreach (var item in yazSemestrDersleri)
            {
                yazSemestrDersSaatleriCemi += item.Value;
            }
            labelYazCemiDeger.Text = yazSemestrDersSaatleriCemi.ToString();
            labelIllikDersSaatiCemiDeger.Text = (yazSemestrDersSaatleriCemi + payizSemestrDersSaatleriCemi).ToString();
        }

        Dictionary<Ders, int> payizSemestrDersleri = new Dictionary<Ders, int>();
        int payizSemestrDersSaatleriCemi = 0;
        void payizSemestrDersi_DersSaatiCemiDeyisti(object sender, DersSaatiCemiDeyistiEventArgs e)
        {
            if (payizSemestrDersleri.Keys.Count(x => x == e.Ders) == 0)
            {
                payizSemestrDersleri.Add(e.Ders, e.DersSaatiCemi);
            }
            else
            {
                payizSemestrDersleri[e.Ders] = e.DersSaatiCemi;
            }
            payizSemestrDersSaatleriCemi = 0;
            foreach (var item in payizSemestrDersleri)
            {
                payizSemestrDersSaatleriCemi += item.Value;
            }
            labelPayizCemiDeger.Text = payizSemestrDersSaatleriCemi.ToString();
            labelIllikDersSaatiCemiDeger.Text = (yazSemestrDersSaatleriCemi + payizSemestrDersSaatleriCemi).ToString();
        }

        private void comboBoxTedrisIli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTedrisIli.SelectedItem != null)
            {
                tedrisIli = (comboBoxTedrisIli.SelectedItem as TedrisIli).Il;
                comboBoxMuellim_SelectedIndexChanged(sender,e);
            }
        }
    }

    public class TedrisIli
    {
        public string Ad { get { return Il.ToString() + " / " + (Il + 1).ToString(); } }
        public int Il { get; set; }
    }

    public sealed class ButtonIxtisasQrubu : Button
    {
        public ButtonIxtisasQrubu(IxtisasQrubu ixtisasQrubu)
            : base()
        {
            if (ixtisasQrubu == null)
            {
                return;
            }
            this.Text = ixtisasQrubu.Ad;
            IxtisasQrubu = ixtisasQrubu;
            this.Height = 30;
            this.Width = 150;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font("Times New Roman", 12f, FontStyle.Bold);
            this.MouseDown += ButtonIxtisasGrubu_MouseDown;
        }

        void ButtonIxtisasGrubu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.DoDragDrop(this, DragDropEffects.Copy);
            }
        }

        public IxtisasQrubu IxtisasQrubu { get; set; }
    }
}
