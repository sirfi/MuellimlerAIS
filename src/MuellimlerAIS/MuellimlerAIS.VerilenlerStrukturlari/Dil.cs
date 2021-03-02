using MuellimlerAIS.Libs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MuellimlerAIS.VerilenlerStrukturlari
{
    public class Dil
    {
        public string Ad { get; set; }
    }

    public enum DilBilgisiSeviyyesi
    {
        [StringValue("Çox Yaxşı")]
        CokYaxsi = 4,
        [StringValue("Yaxşı")]
        Yaxsi = 3,
        [StringValue("Orta")]
        Orta = 2,
        [StringValue("Az")]
        Az = 1,
        [StringValue("Çox Az")]
        CoxAz = 0
    }
}
