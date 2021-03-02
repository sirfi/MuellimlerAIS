using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MuellimlerAIS.VerilenlerStrukturlari;

namespace MuellimlerAIS
{
    public partial class UserControlMuelliminDeyeBildiyiDers : UserControl
    {
        public UserControlMuelliminDeyeBildiyiDers()
        {
            InitializeComponent();
        }

        private void UserControlMuelliminDeyeBildiyiDers_Load(object sender, EventArgs e)
        {
            if (Ders != null)
            {
                checkBoxDersinAdi.Text = Ders.Ad;
            }
        }

        public Ders Ders { get; set; }

        public int DediyiIlSayi
        {
            get { return numericUpDownDediyiIlSayi.IntValue(); }
            set { numericUpDownDediyiIlSayi.Value = value; }
        }

        public bool SeciliMi
        {
            get { return checkBoxDersinAdi.Checked; }
            set { checkBoxDersinAdi.Checked = value; }
        }



    }
}
