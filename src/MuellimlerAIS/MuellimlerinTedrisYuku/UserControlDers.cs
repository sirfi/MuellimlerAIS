using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using MuellimlerAIS.Libs;
using MuellimlerAIS.VerilenlerStrukturlari;

namespace MuellimlerinTedrisYuku
{
    public partial class UserControlDers : UserControl
    {
        private List<IxtisasDersi> ixtisasDersleri;
        public UserControlDers()
        {
            InitializeComponent();
            ixtisasDersleri = null;
        }

        public Muellim Muellim { get; set; }
        public Ders Ders { get; set; }
        public int TedrisIli { get; set; }
        public List<TedrisYuku> TedrisYukleri { get; set; }
        public bool YazSemestriMi { get; set; }

        private void flowLayoutPanelIxtisasQruplari_DragEnter(object sender, DragEventArgs e)
        {
            var buttonIxtisasQrubu = e.Data.GetData(typeof(ButtonIxtisasQrubu)) as ButtonIxtisasQrubu;
            if (buttonIxtisasQrubu == null || buttonIxtisasQrubu.IxtisasQrubu == null) return;
            var qrubunSemestri = ((TedrisIli - buttonIxtisasQrubu.IxtisasQrubu.BaslamaIli) * 2) + 1;
            if (YazSemestriMi)
            {
                qrubunSemestri++;
            }
            if (ixtisasDersleri.Count(x => x.Ixtisas == buttonIxtisasQrubu.IxtisasQrubu.Ixtisas && x.Semestr == qrubunSemestri) == 0)
            {
                e.Effect = DragDropEffects.None;
                return;
            }
            e.Effect = flowLayoutPanelIxtisasQruplari.Controls.OfType<ButtonTedrisYuku>().Count(x => x.TedrisYuku.Qrup == buttonIxtisasQrubu.IxtisasQrubu) == 0 ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void flowLayoutPanelIxtisasQruplari_DragDrop(object sender, DragEventArgs e)
        {
            var buttonIxtisasQrubu = e.Data.GetData(typeof(ButtonIxtisasQrubu)) as ButtonIxtisasQrubu;
            if (buttonIxtisasQrubu != null && buttonIxtisasQrubu.IxtisasQrubu != null)
            {
                var tedrisYuku = new TedrisYuku { Muellim = this.Muellim, Ders = this.Ders, Qrup = buttonIxtisasQrubu.IxtisasQrubu, TedrisIli = this.TedrisIli };
                flowLayoutPanelIxtisasQruplari.Controls.Add(new ButtonTedrisYuku(tedrisYuku));
                TedrisYukleri.Add(tedrisYuku);
                Program.VBE.Store(tedrisYuku);
            }
        }

        private void UserControlDers_Load(object sender, EventArgs e)
        {
            if (Muellim == null || Ders == null || TedrisYukleri == null)
            {
                this.Dispose();
                return;
            }
            this.labelDersAdi.Text = Ders.Ad;

            ixtisasDersleri = (from IxtisasDersi id in Program.VBE
                               where id.Ders == this.Ders
                               select id).ToList();

            foreach (var tedrisYuku in TedrisYukleri)
            {
                flowLayoutPanelIxtisasQruplari.Controls.Add(new ButtonTedrisYuku(tedrisYuku));
            }
        }

        private void flowLayoutPanelIxtisasQruplari_ControlAdded(object sender, ControlEventArgs e)
        {
            DersSaatiKontrol(e);
        }

        private void flowLayoutPanelIxtisasQruplari_ControlRemoved(object sender, ControlEventArgs e)
        {
            DersSaatiKontrol(e);
        }

        private void DersSaatiKontrol(ControlEventArgs e)
        {
            if (e.Control is ButtonTedrisYuku)
            {
                int cem = 0;
                flowLayoutPanelIxtisasQruplari.Controls.OfType<ButtonTedrisYuku>().ToList().ForEach(x =>
                {
                    var idler = ixtisasDersleri.Where(y => y.Ixtisas == x.TedrisYuku.Qrup.Ixtisas).ToList();
                    if (idler.Count>0)
                    {
                        cem += idler[0].Cem;
                    }
                });

                DersSaatiCemiDeyisti(this, new DersSaatiCemiDeyistiEventArgs(cem,Ders));
            }
        }


        public event EventHandler<DersSaatiCemiDeyistiEventArgs> DersSaatiCemiDeyisti;
    }

    public class ButtonTedrisYuku : Button
    {
        public ButtonTedrisYuku(TedrisYuku tedrisYuku)
            : base()
        {
            if (tedrisYuku == null)
            {
                return;
            }
            TedrisYuku = tedrisYuku;
            this.Text = tedrisYuku.Qrup.Ad;
            this.Height = 30;
            this.Width = 165;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font("Times New Roman", 12f, FontStyle.Bold);
            this.MouseClick += ButtonTedrisYuku_MouseClick;
        }

        void ButtonTedrisYuku_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Qrubu dərsdən silmək istəyirsiniz?", "Dərdən qrup silmə", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Program.VBE.Delete(TedrisYuku);
                if (this.Parent != null)
                    this.Parent.Controls.Remove(this);
            }
        }

        public TedrisYuku TedrisYuku { get; set; }
    }
}
