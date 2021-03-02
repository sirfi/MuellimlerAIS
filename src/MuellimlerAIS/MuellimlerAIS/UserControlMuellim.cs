using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MuellimlerAIS.VerilenlerStrukturlari;
using MuellimlerAIS.Libs;

namespace MuellimlerAIS
{
    public partial class UserControlMuellim : UserControl
    {
        public UserControlMuellim()
        {
            InitializeComponent();
        }

        public Muellim Muellim { get; set; }

        private void UserControlMuellim_Load(object sender, EventArgs e)
        {
            if (Muellim == null) { this.Parent.Controls.Remove(this); return; }
            groupBoxXususiyetler.Text = Muellim.TamAdi;
            labelCinsiyyetDeger.Text = Muellim.Cinsiyyet ? "Kişi" : "Qadın";
            pictureBoxSekil.Image = ImageLib.ByteArrayToImage(Muellim.Sekil);
            labelDogulduguTarixDeger.Text = Muellim.DogulduguTarix.ToShortDateString();
            labelDogulduguYerDeger.Text = Muellim.DogulduguYer;
            labelMilliyetDeger.Text = Muellim.Milliyet;
            labelVetendaslikDeger.Text = Muellim.Vetendaslik;
            labelEvTelefonNomresiDeger.Text = Muellim.EvTelefonuNomresi;
            labelMobilTelefonNomresiDeger.Text = Muellim.MobilTelefonNomresi;
            labelEvUnvaniDeger.Text = Muellim.EvUnvani;
            labelBaslamaIliDeger.Text = Muellim.BaslamaIli.ToString();
            labelElmiDereceDeger.Text = Muellim.ElmiDerece.GetStringValue();
            labelVezifeDeger.Text = Muellim.Vezife.GetStringValue();
            labelVezifeYeriFakulteDeger.Text = Muellim.VezifeliOlduguYer.Fakulte.Ad;
            labelVezifeYeriKafedraDeger.Text = Muellim.VezifeliOlduguYer.Ad;
        }
    }
}
