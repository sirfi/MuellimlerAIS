using MuellimlerAIS.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuellimlerAIS.VerilenlerStrukturlari
{
    public class Ixtisas
    {
        public Kafedra Kafedra { get; set; }
        public string Ad { get; set; }
        public IxtisasTuru Tur { get; set; }
    }

    public class IxtisasDersi
    {
        public Ixtisas Ixtisas { get; set; }
        public int Semestr { get; set; }
        public Ders Ders { get; set; }
        public string Ad
        {
            get
            {
                return Ders.Ad + " - " + Semestr.ToString() + ". Semestr";
            }
        }
        public int Muhazire { get; set; }
        public int MesqeleSeminer { get; set; }
        public int Laboratoriya { get; set; }
        public int HQIEvTapsiriklari { get; set; }
        public int KurIsi { get; set; }
        public int TecrubeyeRehberlik { get; set; }
        public int BirakilisIsineRehberlik { get; set; }
        public int MagistrDissertasiyasinaRehberlik { get; set; }
        public int MagistrMeslehet { get; set; }
        public int MagistrPrograminaRehberlik { get; set; }
        public int Referat { get; set; }
        public int Meqbul { get; set; }
        public int Meslehet { get; set; }
        public int Imtihan { get; set; }
        public int DigerDersYuku { get; set; }
        public int Cem
        {
            get
            {
                return Muhazire + MesqeleSeminer + Laboratoriya + HQIEvTapsiriklari
                    + KurIsi + TecrubeyeRehberlik + BirakilisIsineRehberlik
                    + MagistrDissertasiyasinaRehberlik + MagistrMeslehet + MagistrPrograminaRehberlik
                    + Referat + Meqbul + Meslehet + Imtihan + DigerDersYuku;
            }
        }
    }

    public enum IxtisasTuru
    {
        [StringValue("Bakalavr")]
        Bakalavr,
        [StringValue("Magistr")]
        Magistr
    }
}
