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

namespace MuellimlerinTedrisYuku
{
    public partial class FormAvtomatikDuzelis : Form
    {
        private List<Muellim> muellimler;
        private List<Ders> dersler;
        private List<IxtisasQrubu> ixtisasQruplari;
        private List<TedrisYuku> payizTedrisYukleri;
        private List<TedrisYuku> yazTedrisYukleri;
        private List<MuelliminDeyeBildiyiDers> muelliminDeyeBildiyiDersler;
        private List<IxtisasDersi> ixtisasDersleri;
        private TedrisIli tedrisIli;
        public FormAvtomatikDuzelis()
        {
            InitializeComponent();
        }

        private void FormAvtomatikDuzelis_Load(object sender, EventArgs e)
        {
            if (Program.SecilmisUniversitet == null) { this.Close(); return; }
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

            buttonSaxla.Enabled = false;
            muellimler = (from Muellim m in Program.VBE
                          orderby m.Familya, m.Ad, m.AtaAdi ascending
                          where m.VezifeliOlduguYer.Fakulte.Universitet == Program.SecilmisUniversitet
                          select m).ToList();
            if (muellimler == null || muellimler.Count == 0)
            {
                MessageBox.Show("Qeydli Müəllim Yox.");
                this.Close();
                return;
            }
            dersler = (from Ders d in Program.VBE
                       orderby d.Ad ascending
                       select d).ToList();
            if (dersler == null || dersler.Count == 0)
            {
                MessageBox.Show("Qeydli Dərs Yox.");
                this.Close();
                return;
            }
            ixtisasQruplari = (from IxtisasQrubu iq in Program.VBE
                               orderby iq.Ad ascending
                               select iq).ToList();
            if (ixtisasQruplari == null || ixtisasQruplari.Count == 0)
            {
                MessageBox.Show("Qeydli İxtisas Qrubu Yox.");
                this.Close();
                return;
            }
            muelliminDeyeBildiyiDersler = (from MuelliminDeyeBildiyiDers mdbd in Program.VBE
                                           orderby mdbd.DediyiIlSayi descending
                                           select mdbd).ToList();
            ixtisasDersleri = (from IxtisasDersi id in Program.VBE
                               orderby id.Ad ascending
                               select id).ToList();
        }

        private void buttonTedrisYukunuAvtomatikHazirla_Click(object sender, EventArgs e)
        {
            textBoxGorulenEmeliyyatlar.Clear();
            payizTedrisYukleri = new List<TedrisYuku>();
            yazTedrisYukleri = new List<TedrisYuku>();
            if (tedrisIli == null)
            {
                MessageBox.Show("Tədris İli olmalıdır.");
                return;
            }
            progressBarEmelliyatVeziyyeti.Visible = true;
            foreach (var ders in dersler)
            {
                var mdbdler = muelliminDeyeBildiyiDersler.Where(x => x.Ders == ders);
                foreach (var ixtisasQrubu in ixtisasQruplari.Where(x => ixtisasDersleri.Count(y => y.Ders == ders && y.Ixtisas == x.Ixtisas) > 0).OrderByDescending(x => ixtisasDersleri.SingleOrDefault(y => y.Ixtisas == x.Ixtisas && y.Ders == ders).Cem))
                {

                    if (ixtisasDersleri.Count(x => x.Ixtisas == ixtisasQrubu.Ixtisas && x.Ders == ders) > 0)
                    {
                        var semestr = (tedrisIli.Il - ixtisasQrubu.BaslamaIli) * 2 + 1;
                        var id = ixtisasDersleri.SingleOrDefault(x => x.Ixtisas == ixtisasQrubu.Ixtisas && x.Ders == ders);
                        var tedrisYuku = new TedrisYuku();
                        tedrisYuku.Ders = ders;
                        tedrisYuku.Qrup = ixtisasQrubu;
                        tedrisYuku.TedrisIli = tedrisIli.Il;
                        if (semestr == id.Semestr)
                        {
                            var muelliminDeyeBildiyiDers = mdbdler.Where(x =>
                            {
                                var muelliminSemestrDersCemi = payizTedrisYukleri.Where(y => y.Muellim == x.Muellim).Sum(y =>
                                {
                                    var id_ = ixtisasDersleri.SingleOrDefault(z => z.Ixtisas == y.Qrup.Ixtisas && y.Ders == z.Ders);
                                    return id_ != null ? id_.Cem : 0;
                                });
                                var id__ = ixtisasDersleri.SingleOrDefault(z => z.Ixtisas == ixtisasQrubu.Ixtisas && z.Ders == ders);
                                return muelliminSemestrDersCemi < 500;
                            }).OrderByDescending(t => payizTedrisYukleri.Count(z => z.TedrisIli == tedrisIli.Il && z.Muellim == t.Muellim && z.Ders == ders && z.Qrup == ixtisasQrubu) == 0).ThenByDescending(t => t.DediyiIlSayi).ThenBy(t => t.Muellim.BaslamaIli).FirstOrDefault();
                            if (muelliminDeyeBildiyiDers != null)
                            {
                                tedrisYuku.Muellim = muelliminDeyeBildiyiDers.Muellim;
                                payizTedrisYukleri.Add(tedrisYuku);
                                textBoxGorulenEmeliyyatlar.AppendText("Payız Semestri - " + tedrisYuku.Muellim.TamAdi + " - " + tedrisYuku.Qrup.Ad + " - " + tedrisYuku.Ders.Ad);
                                textBoxGorulenEmeliyyatlar.AppendText("\n----------------------------------------------------------------------\n");
                            }
                        }
                        semestr++;
                        if (semestr == id.Semestr)
                        {
                            var muelliminDeyeBildiyiDers = mdbdler.Where(x =>
                            {
                                var muelliminSemestrDersCemi = yazTedrisYukleri.Where(y => y.Muellim == x.Muellim).Sum(y =>
                                {
                                    var id_ = ixtisasDersleri.SingleOrDefault(z => z.Ixtisas == y.Qrup.Ixtisas && y.Ders == z.Ders);
                                    return id_ != null ? id_.Cem : 0;
                                });
                                var id__ = ixtisasDersleri.SingleOrDefault(z => z.Ixtisas == ixtisasQrubu.Ixtisas && z.Ders == ders);
                                return muelliminSemestrDersCemi < 500;
                            }).OrderByDescending(t => t.Ders == ders && yazTedrisYukleri.Count(z => z.TedrisIli == tedrisIli.Il && z.Muellim == t.Muellim && z.Ders == ders && z.Qrup == ixtisasQrubu) == 0).OrderByDescending(t => t.DediyiIlSayi).ThenBy(t => t.Muellim.BaslamaIli).FirstOrDefault();
                            if (muelliminDeyeBildiyiDers != null)
                            {
                                tedrisYuku.Muellim = muelliminDeyeBildiyiDers.Muellim;
                                yazTedrisYukleri.Add(tedrisYuku);
                                textBoxGorulenEmeliyyatlar.AppendText("Yaz Semestri - " + tedrisYuku.Muellim.TamAdi + " - " + tedrisYuku.Qrup.Ad + " - " + tedrisYuku.Ders.Ad);
                                textBoxGorulenEmeliyyatlar.AppendText("/n----------------------------------------------------------------------/n");
                            }
                        }
                    }
                }
            }
            buttonSaxla.Enabled = true;
            progressBarEmelliyatVeziyyeti.Visible = false;
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            progressBarEmelliyatVeziyyeti.Visible = true;
            var eskiTedrisYukleri = (from TedrisYuku ty in Program.VBE
                                     where ty.Muellim.VezifeliOlduguYer.Fakulte.Universitet == Program.SecilmisUniversitet && ty.TedrisIli == tedrisIli.Il
                                     select ty).ToList();
            foreach (var tedrisYuku in eskiTedrisYukleri)
            {
                Program.VBE.Delete(tedrisYuku);
            }
            var tedrisYukleri = new List<TedrisYuku>();
            tedrisYukleri.AddRange(payizTedrisYukleri);
            tedrisYukleri.AddRange(yazTedrisYukleri);
            foreach (var tedrisYuku in tedrisYukleri)
            {
                Program.VBE.Store(tedrisYuku);
            }
            progressBarEmelliyatVeziyyeti.Visible = false;
            buttonSaxla.Enabled = true;
            MessageBox.Show("Tədris yükü qeyd edildi.");
        }

        private void comboBoxTedrisIli_SelectedIndexChanged(object sender, EventArgs e)
        {
            tedrisIli = comboBoxTedrisIli.SelectedItem as TedrisIli;
            if (tedrisIli == null)
            {
                buttonTedrisYukunuAvtomatikHazirla.Enabled = false;
                buttonSaxla.Enabled = false;
            }
            else
            {
                buttonTedrisYukunuAvtomatikHazirla.Enabled = true;
                buttonSaxla.Enabled = false;
            }
        }
    }
}