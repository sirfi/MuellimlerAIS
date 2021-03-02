using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuellimlerAIS.VerilenlerStrukturlari
{
    public class Muellim
    {
        public string Ad { get; set; }
        public string Familya { get; set; }
        public string AtaAdi { get; set; }
        public bool Cinsiyyet { get; set; }
        public byte[] Sekil { get; set; }
        public string TamAdi
        {
            get
            {
                return Ad + " " + AtaAdi + " " + (Cinsiyyet ? "oğlu" : "qızı") + " " + Familya;
            }
        }
        public DateTime DogulduguTarix { get; set; }
        public string DogulduguYer { get; set; }
        public string Milliyet { get; set; }
        public string Vetendaslik { get; set; }
        public string EvTelefonuNomresi { get; set; }
        public string MobilTelefonNomresi { get; set; }
        public string EvUnvani { get; set; }
        public int BaslamaIli { get; set; }
        public ElmiDerece ElmiDerece { get; set; }
        public Vezife Vezife { get; set; }
        public Kafedra VezifeliOlduguYer { get; set; }
    }

    public class MuellimTehsili
    {
        public Muellim Muellim { get; set; }
        public Universitet Universitet { get; set; }
        public string Ixtisas { get; set; }
        public int MezuniyyetIli { get; set; }
        public string Ad
        {
            get
            {
                return Universitet.Ad + " - " + Ixtisas + " - " + MezuniyyetIli.ToString();
            }
        }
    }

    public enum TehsilNovu
    {
        Bakalavr,
        Magistr
    }

    public class MuelliminIstirakEtdiyiKonfrans
    {
        public Muellim Muellim { get; set; }
        public Konfrans Konfrans { get; set; }
        public bool NatiqIdi { get; set; }
    }

    public class ElmiDerece
    {
        public string Ad { get; set; }
    }

    public class Vezife
    {
        public string Ad { get; set; }
    }

    public class MuelliminBildiyiDil
    {
        public Muellim Muellim { get; set; }
        public Dil Dil { get; set; }
        public DilBilgisiSeviyyesi Seviyye { get; set; }
    }

    public class MuelliminDeyeBildiyiDers
    {
        public Muellim Muellim { get; set; }
        public Ders Ders { get; set; }
        public int DediyiIlSayi { get; set; }
        public string Ad
        {
            get
            {
                if (DediyiIlSayi > 0)
                    return Ders.Ad + " - " + DediyiIlSayi.ToString() + " İl Deyib";
                else
                    return Ders.Ad + " - Heç Demeyib";
            }
        }
    }

    public class MuellimMeqalesi
    {
        public Muellim Muellim { get; set; }
        public string Movzu { get; set; }
        public DateTime NesrTarixi { get; set; }
        public string Ad
        {
            get
            {
                return Movzu + " - " + NesrTarixi.ToString("dd.MM.yyyy");
            }
        }
    }

    public class MuellimKitabi
    {
        public Muellim Muellim { get; set; }
        public string Ad { get; set; }
        public string Movzu { get; set; }
        public int CapIli { get; set; }
    }
}
