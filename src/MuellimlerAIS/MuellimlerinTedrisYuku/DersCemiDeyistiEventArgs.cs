using MuellimlerAIS.VerilenlerStrukturlari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MuellimlerinTedrisYuku
{
    public class DersSaatiCemiDeyistiEventArgs : EventArgs
    {
        public DersSaatiCemiDeyistiEventArgs(int dersSaatiCemi, Ders Ders)
            : base()
        {
            this.DersSaatiCemi = dersSaatiCemi;
            this.Ders = Ders;
        }

        public int DersSaatiCemi { get; private set; }

        public Ders Ders { get; private set; }
    }
}
