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
    public partial class FormMuelliminDeyeBildiyiDersler : Form
    {
        private List<Ders> dersler;
        private List<MuelliminDeyeBildiyiDers> deyeBildiyiDersler;
        public FormMuelliminDeyeBildiyiDersler()
        {
            InitializeComponent();
        }

        public Muellim Muellim { get; set; }

        private void FormMuelliminDeyeBildiyiDersler_Load(object sender, EventArgs e)
        {
            if (Muellim == null)
            {
                this.Close();
                return;
            }

            this.Text = this.Muellim.TamAdi + " - Deyə Bildiyi Dərslər";

            dersler = (from Ders d in Program.VBE
                       orderby d.Ad ascending
                       where d.Kafedra == this.Muellim.VezifeliOlduguYer
                       select d).ToList();

            deyeBildiyiDersleriGetir();
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDeyeBildiyiDersler.Controls.OfType<UserControlMuelliminDeyeBildiyiDers>().ToList().ForEach(x =>
            {
                if (x.SeciliMi)
                {
                    if (deyeBildiyiDersler.Count(y => y.Ders == x.Ders) > 0)
                    {
                        deyeBildiyiDersler.Single(y => y.Ders == x.Ders).DediyiIlSayi = x.DediyiIlSayi;
                    }
                    else
                    {
                        deyeBildiyiDersler.Add(new MuelliminDeyeBildiyiDers { Muellim = this.Muellim, Ders = x.Ders, DediyiIlSayi = x.DediyiIlSayi });
                    }
                }
                else
                {
                    if (deyeBildiyiDersler.Count(y => y.Ders == x.Ders) > 0)
                    {
                        var dbd = deyeBildiyiDersler.Single(y => y.Ders == x.Ders);
                        deyeBildiyiDersler.Remove(dbd);
                        Program.VBE.Delete(dbd);
                    }
                }
            });

            foreach (var dbd in deyeBildiyiDersler)
            {
                Program.VBE.Store(dbd);
            }

            deyeBildiyiDersleriGetir();
        }

        void deyeBildiyiDersleriGetir()
        {
            flowLayoutPanelDeyeBildiyiDersler.Controls.Clear();
            deyeBildiyiDersler = (from MuelliminDeyeBildiyiDers mdbd in Program.VBE
                                  orderby mdbd.Ad ascending
                                  where mdbd.Muellim == this.Muellim
                                  select mdbd).ToList();

            foreach (var ders in dersler)
            {
                if (deyeBildiyiDersler.Count(x => x.Ders == ders) > 0)
                {
                    var dbd = deyeBildiyiDersler.Single(x => x.Ders == ders);
                    flowLayoutPanelDeyeBildiyiDersler.Controls.Add(new UserControlMuelliminDeyeBildiyiDers { SeciliMi = true, Ders = ders, DediyiIlSayi = dbd.DediyiIlSayi });
                }
                else
                {
                    flowLayoutPanelDeyeBildiyiDersler.Controls.Add(new UserControlMuelliminDeyeBildiyiDers { SeciliMi = false, Ders = ders, DediyiIlSayi = 0 });
                }
            }
        }
    }
}
