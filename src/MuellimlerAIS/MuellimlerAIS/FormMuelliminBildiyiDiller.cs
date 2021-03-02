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
    public partial class FormMuelliminBildiyiDiller : Form
    {
        public Muellim Muellim { get; set; }
        private IList<Dil> diller;
        private IList<MuelliminBildiyiDil> bildiyiDiller;

        public FormMuelliminBildiyiDiller()
        {
            InitializeComponent();
        }

        private void FormMuelliminBildiyiDiller_Load(object sender, EventArgs e)
        {
            if (this.Muellim == null) this.Close();
            this.Text = this.Muellim.TamAdi + " - Bildiyi Dillər";

            diller = (from Dil d in Program.VBE
                      orderby d.Ad ascending
                      select d).ToList();

            bildiyiDilleriGetir();
        }

        private void buttonSaxla_Click(object sender, EventArgs e)
        {
            flowLayoutPanelBildiyiDiller.Controls.OfType<UserControlMuelliminBildiyiDil>().ToList().ForEach(uc =>
            {
                if (uc.SeciliMi)
                {
                    if (bildiyiDiller.Count(x => x.Dil == uc.Dil) > 0)
                    {
                        bildiyiDiller.Single(x => x.Dil == uc.Dil).Seviyye = uc.Seviyye;
                    }
                    else
                    {
                        bildiyiDiller.Add(new MuelliminBildiyiDil() { Muellim = this.Muellim, Dil = uc.Dil, Seviyye = uc.Seviyye });
                    }
                }
                else
                {
                    if (bildiyiDiller.Count(x => x.Dil == uc.Dil) > 0)
                    {
                        var bd = bildiyiDiller.Single(x => x.Dil == uc.Dil);
                        bildiyiDiller.Remove(bd);
                        Program.VBE.Delete(bd);
                    }
                }
            });
            foreach (var bd in bildiyiDiller)
            {
                Program.VBE.Store(bd);
            }
            bildiyiDilleriGetir();
        }

        void bildiyiDilleriGetir()
        {
            flowLayoutPanelBildiyiDiller.Controls.Clear();

            bildiyiDiller = (from MuelliminBildiyiDil mbd in Program.VBE
                             where mbd.Muellim == this.Muellim
                             select mbd).ToList();

            foreach (var dil in diller)
            {
                if (bildiyiDiller.Count(x => x.Dil == dil) > 0)
                {
                    var bd = bildiyiDiller.Single(x => x.Dil == dil);
                    flowLayoutPanelBildiyiDiller.Controls.Add(new UserControlMuelliminBildiyiDil() { SeciliMi = true, Dil = bd.Dil, Seviyye = bd.Seviyye });
                }
                else
                {
                    flowLayoutPanelBildiyiDiller.Controls.Add(new UserControlMuelliminBildiyiDil() { SeciliMi = false, Dil = dil });
                }
            }
        }
    }
}
