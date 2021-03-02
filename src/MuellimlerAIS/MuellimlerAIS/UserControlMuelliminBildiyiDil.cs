using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MuellimlerAIS.VerilenlerStrukturlari;
using MuellimlerAIS.Libs;

namespace MuellimlerAIS
{
    public partial class UserControlMuelliminBildiyiDil : UserControl
    {
        List<EnumListItem<DilBilgisiSeviyyesi>> seviyyeler;

        public UserControlMuelliminBildiyiDil()
        {
            InitializeComponent();
            seviyyeler = EnumLib.GetEnumList<DilBilgisiSeviyyesi>();
        }

        private void UserControlMuelliminBildiyiDil_Load(object sender, EventArgs e)
        {
            if (this.Dil != null)
            {
                checkBoxDilinAdi.Text = this.Dil.Ad;
            }

            seviyyeleriGetir();
        }

        private void seviyyeleriGetir()
        {
            comboBoxSeviyye.DataSource = seviyyeler;
            comboBoxSeviyye.DisplayMember = "Name";
            comboBoxSeviyye.ValueMember = "Value";
        }

        public DilBilgisiSeviyyesi Seviyye
        {
            get
            {
                if (comboBoxSeviyye.SelectedItem == null) return DilBilgisiSeviyyesi.Orta;
                return ((EnumListItem<DilBilgisiSeviyyesi>)(comboBoxSeviyye.SelectedItem)).Value;
            }
            set
            {
                seviyyeleriGetir();
                comboBoxSeviyye.SelectedValue = value;
            }
        }

        public bool SeciliMi
        {
            get
            {
                return checkBoxDilinAdi.Checked;
            }
            set
            {
                checkBoxDilinAdi.Checked = value;
            }
        }

        public Dil Dil { get; set; }
    }
}
