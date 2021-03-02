using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuellimlerAIS.VerilenlerStrukturlari
{
    public class Universitet
    {
        public string Ad { get; set; }
        public byte[] Logo { get; set; }
        public Muellim Rektor { get; set; }
        public bool? Secili { get; set; }
    }

    public class UniversitetProrektoru
    {
        public Universitet Universitet { get; set; }
        public Muellim Prorektor { get; set; }
        public string Vezife { get; set; }
    }
}
