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
    public partial class FormMuellimSorgulamalari : Form
    {
        private List<Muellim> muellimler;
        private List<Dil> diller;
        public FormMuellimSorgulamalari()
        {
            InitializeComponent();
        }

        private void FormMuellimSorgulamalari_Load(object sender, EventArgs e)
        {
            muellimler = (from Muellim m in Program.VBE
                          orderby m.Familya, m.Ad, m.AtaAdi ascending
                          where m.VezifeliOlduguYer.Fakulte.Universitet == Program.SecilmisUniversitet
                          select m).ToList();

            diller = (from Dil d in Program.VBE
                      orderby d.Ad ascending
                      select d).ToList();
        }

        private void buttonSorgula_Click(object sender, EventArgs e)
        {

        }
    }
}
