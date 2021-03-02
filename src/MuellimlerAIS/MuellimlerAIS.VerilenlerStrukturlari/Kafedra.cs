using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuellimlerAIS.VerilenlerStrukturlari
{
    public class Kafedra
    {
        public Fakulte Fakulte { get; set; }
        public string Ad { get; set; }
        public Muellim Mudir { get; set; }
        public Muellim MudirMuavini { get; set; }
    }
}
