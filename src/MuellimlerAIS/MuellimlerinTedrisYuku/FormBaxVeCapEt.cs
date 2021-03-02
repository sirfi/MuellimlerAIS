using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using MuellimlerAIS.Libs;
using MuellimlerAIS.VerilenlerStrukturlari;
using Microsoft.Office.Core;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using System.Runtime.InteropServices;

namespace MuellimlerinTedrisYuku
{
    public partial class FormBaxVeCapEt : Form
    {
        private Excel.Application excelApp;
        private Excel.Workbook excelWorkbook;
        public FormBaxVeCapEt()
        {
            InitializeComponent();
        }

        private void FormBaxVeCapEt_Load(object sender, EventArgs e)
        {
            if (Program.SecilmisUniversitet == null) { this.Close(); return; }
            var tedrisIlleri = new List<TedrisIli>();
            for (int i = DateTime.Today.Year - 10; i < DateTime.Today.Year + 10; i++)
            {
                var ty = new TedrisIli { Il = i };
                tedrisIlleri.Add(ty);
            }
            comboBoxTedrisIli.DataSource = tedrisIlleri;
            comboBoxTedrisIli.DisplayMember = "Ad";
            comboBoxTedrisIli.ValueMember = "Il";
            comboBoxTedrisIli.SelectedItem = tedrisIlleri.SingleOrDefault(x => DateTime.Today.AddMonths(-7).Year == x.Il);

            var fakulteler = from Fakulte f in Program.VBE
                             orderby f.Ad ascending
                             where f.Universitet == Program.SecilmisUniversitet
                             select f;
            comboBoxFakulte.DataSource = fakulteler.ToList();
            comboBoxFakulte.DisplayMember = "Ad";

        }

        private void comboBoxFakulte_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilmisFakulte = comboBoxFakulte.SelectedItem as Fakulte;
            if (secilmisFakulte != null)
            {
                var kafedralar = (from Kafedra k in Program.VBE
                                  orderby k.Ad ascending
                                  where k.Fakulte == secilmisFakulte
                                  select k).ToList();

                comboBoxKafedra.DataSource = kafedralar;
                comboBoxKafedra.DisplayMember = "Ad";
            }
            else
            {
                comboBoxKafedra.DataSource = null;
            }
        }

        private void comboBoxKafedra_SelectedIndexChanged(object sender, EventArgs e)
        {
            var secilmisKafedra = comboBoxKafedra.SelectedItem as Kafedra;
            if (secilmisKafedra != null)
            {
                var muellimler = (from Muellim m in Program.VBE
                                  orderby m.Familya, m.Ad, m.AtaAdi ascending
                                  where m.VezifeliOlduguYer == secilmisKafedra
                                  select m).ToList();
                comboBoxMuellim.DataSource = muellimler;
                comboBoxMuellim.DisplayMember = "TamAdi";
            }
            else
            {
                comboBoxMuellim.DataSource = null;
            }
        }

        private void comboBoxMuellim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonExcelFayliniGoster_Click(object sender, EventArgs e)
        {
            if (comboBoxMuellim.SelectedItem == null)
            {
                MessageBox.Show("Müəllim səçilməlidir.");
                return;
            }

            if (comboBoxTedrisIli.SelectedItem == null)
            {
                MessageBox.Show("Tədris İli səçilməlidir.");
                return;
            }

            var secilmisMuellim = comboBoxMuellim.SelectedItem as Muellim;
            var secilmisTedrisIli = comboBoxTedrisIli.SelectedItem as TedrisIli;
            var tedrisYukleri = (from TedrisYuku ty in Program.VBE
                                 orderby ty.Qrup.Ad, ty.Ders.Ad ascending
                                 where ty.Muellim == secilmisMuellim && ty.TedrisIli == secilmisTedrisIli.Il
                                 select ty).ToList();

            excelApp = new Excel.Application();
            excelApp.Visible = false;
            excelWorkbook = excelApp.Workbooks.Open(Path.GetDirectoryName(Application.ExecutablePath) + "\\BosTedrisYuku.xlsx");
            Excel.Worksheet excelWorksheet = excelWorkbook.ActiveSheet as Excel.Worksheet;
            excelWorksheet.Cells[2, 1].Value = Program.SecilmisUniversitet.Ad;
            excelWorksheet.Cells[1, 7].Value = secilmisMuellim.VezifeliOlduguYer.Ad;
            excelWorksheet.Cells[2, 7].Value = secilmisMuellim.TamAdi;
            excelWorksheet.Cells[2, 27].Value = secilmisTedrisIli.Ad;
            excelWorksheet.Cells[24, 23].Value = secilmisMuellim.VezifeliOlduguYer != null && secilmisMuellim.VezifeliOlduguYer.Mudir != null ? secilmisMuellim.VezifeliOlduguYer.Mudir.TamAdi : "";
            int satir = 6;
            foreach (var tedrisYuku in tedrisYukleri)
            {
                excelWorksheet.Cells[satir, 1].Value = tedrisYuku.Ders.Ad;
                excelWorksheet.Cells[satir, 2].Value = tedrisYuku.Qrup.Ad;
                excelWorksheet.Cells[satir, 3].Value = tedrisYuku.Qrup.TelebeSayi;

                var ixtisasDersi = (from IxtisasDersi id in Program.VBE
                                    where id.Ixtisas == tedrisYuku.Qrup.Ixtisas && id.Ders == tedrisYuku.Ders
                                    select id).SingleOrDefault();

                int ekle = ixtisasDersi.Semestr % 2 == 1 ? 0 : 17;
                excelWorksheet.Cells[satir, 4 + ekle].Value = ixtisasDersi.Muhazire;
                excelWorksheet.Cells[satir, 5 + ekle].Value = ixtisasDersi.MesqeleSeminer;
                excelWorksheet.Cells[satir, 6 + ekle].Value = ixtisasDersi.Laboratoriya;
                excelWorksheet.Cells[satir, 7 + ekle].Value = ixtisasDersi.HQIEvTapsiriklari;
                excelWorksheet.Cells[satir, 8 + ekle].Value = ixtisasDersi.KurIsi;
                excelWorksheet.Cells[satir, 9 + ekle].Value = ixtisasDersi.TecrubeyeRehberlik;
                excelWorksheet.Cells[satir, 10 + ekle].Value = ixtisasDersi.BirakilisIsineRehberlik;
                excelWorksheet.Cells[satir, 11 + ekle].Value = ixtisasDersi.MagistrDissertasiyasinaRehberlik;
                excelWorksheet.Cells[satir, 12 + ekle].Value = ixtisasDersi.MagistrMeslehet;
                excelWorksheet.Cells[satir, 13 + ekle].Value = ixtisasDersi.MagistrPrograminaRehberlik;
                excelWorksheet.Cells[satir, 14 + ekle].Value = ixtisasDersi.Referat;
                excelWorksheet.Cells[satir, 15 + ekle].Value = ixtisasDersi.Meqbul;
                excelWorksheet.Cells[satir, 16 + ekle].Value = ixtisasDersi.Meslehet;
                excelWorksheet.Cells[satir, 17 + ekle].Value = ixtisasDersi.Imtihan;
                excelWorksheet.Cells[satir, 18 + ekle].Value = ixtisasDersi.DigerDersYuku;

                satir++;
            }
            excelApp.Visible = true;
        }

        private void FormBaxVeCapEt_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (excelWorkbook != null)
            {
                Marshal.ReleaseComObject(excelWorkbook);
            }
            if (excelApp != null)
            {
                Marshal.ReleaseComObject(excelApp);
            }
        }
    }
}
