using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuellimlerAIS.VerilenlerStrukturlari
{
    public class TedrisYuku
    {
        public Muellim Muellim { get; set; }
        public IxtisasQrubu Qrup { get; set; }
        public int TedrisIli { get; set; }
        public Ders Ders { get; set; }
    }
}
