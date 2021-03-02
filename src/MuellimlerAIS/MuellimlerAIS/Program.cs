using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MuellimlerAIS
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            SecilmisUniversitet = null;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Program.FormGiris);
        }

        private static FormGiris formGiris;
        public static FormGiris FormGiris
        {
            get
            {
                if (formGiris == null)
                {
                    formGiris = new FormGiris();
                }
                return formGiris;
            }
        }

        private static FormAna formAna;
        public static FormAna FormAna
        {
            get
            {
                if (formAna == null)
                {
                    formAna = new FormAna();
                }
                return formAna;
            }
        }

        private static Db4objects.Db4o.IObjectContainer _VBE;
        public static Db4objects.Db4o.IObjectContainer VBE
        {
            get
            {
                if (_VBE == null)
                {
                    var config = Db4objects.Db4o.Db4oEmbedded.NewConfiguration();
                    _VBE = Db4objects.Db4o.Db4oEmbedded.OpenFile(config, "../../../MAIS.yap");
                }
                return _VBE;
            }
        }

        public static MuellimlerAIS.VerilenlerStrukturlari.Universitet SecilmisUniversitet { get; set; }
    }

    public static class NumericUpDownExtensions
    {
        public static int IntValue(this NumericUpDown nud)
        {
            return Convert.ToInt32(nud.Value);
        }
    }
}
