using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuellimlerAIS.VerilenlerStrukturlari
{
    public class Fakulte
    {
        public Universitet Universitet { get; set; }
        public string Ad { get; set; }
        public Muellim Dekan { get; set; }
        public Muellim DekanMuavini { get; set; }
    }
}
