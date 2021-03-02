namespace MuellimlerAIS
{
    partial class FormMuellimSorgulamalari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanelMuellimler = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageEsasXususiyetler = new System.Windows.Forms.TabPage();
            this.groupBoxAdFamilyaVeAtaAdi = new System.Windows.Forms.GroupBox();
            this.textBoxAtaAdi = new System.Windows.Forms.TextBox();
            this.labelAtaAdi = new System.Windows.Forms.Label();
            this.textBoxFamilya = new System.Windows.Forms.TextBox();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.checkBoxAdFamilyaVeAtaAdiSorgulansin = new System.Windows.Forms.CheckBox();
            this.labelFamilya = new System.Windows.Forms.Label();
            this.labelAd = new System.Windows.Forms.Label();
            this.groupBoxCinsiyyet = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBoxCinsiyyetSorgulansin = new System.Windows.Forms.CheckBox();
            this.labelCinsiyyet = new System.Windows.Forms.Label();
            this.groupBoxMilliyetVeVetendaslik = new System.Windows.Forms.GroupBox();
            this.textBoxVetendaslik = new System.Windows.Forms.TextBox();
            this.textBoxMilliyet = new System.Windows.Forms.TextBox();
            this.checkBoxMilliyetVeVetendaslikSorgulansin = new System.Windows.Forms.CheckBox();
            this.labelVetendaslik = new System.Windows.Forms.Label();
            this.labelMilliyet = new System.Windows.Forms.Label();
            this.groupBoxTecrube = new System.Windows.Forms.GroupBox();
            this.checkBoxTecrubeSorgulansin = new System.Windows.Forms.CheckBox();
            this.numericUpDownMaksimalTecrube = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinimalTecrube = new System.Windows.Forms.NumericUpDown();
            this.labelMaksimalTecrube = new System.Windows.Forms.Label();
            this.labelMinimalTecrube = new System.Windows.Forms.Label();
            this.groupBoxYasAraligi = new System.Windows.Forms.GroupBox();
            this.checkBoxYasAraligiSorgulansin = new System.Windows.Forms.CheckBox();
            this.numericUpDownMaksimalYas = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinimalYas = new System.Windows.Forms.NumericUpDown();
            this.labelMaksimalYas = new System.Windows.Forms.Label();
            this.labelMinimalYas = new System.Windows.Forms.Label();
            this.tabPageDilQabiliyyetleri = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelDiller = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxDilQabiliyyetleriSorgulansin = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanelDersler = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxDerslerSorgulansin = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonSorgula = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageEsasXususiyetler.SuspendLayout();
            this.groupBoxAdFamilyaVeAtaAdi.SuspendLayout();
            this.groupBoxCinsiyyet.SuspendLayout();
            this.groupBoxMilliyetVeVetendaslik.SuspendLayout();
            this.groupBoxTecrube.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaksimalTecrube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimalTecrube)).BeginInit();
            this.groupBoxYasAraligi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaksimalYas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimalYas)).BeginInit();
            this.tabPageDilQabiliyyetleri.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMuellimler
            // 
            this.flowLayoutPanelMuellimler.AutoScroll = true;
            this.flowLayoutPanelMuellimler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelMuellimler.Location = new System.Drawing.Point(12, 213);
            this.flowLayoutPanelMuellimler.Name = "flowLayoutPanelMuellimler";
            this.flowLayoutPanelMuellimler.Size = new System.Drawing.Size(960, 437);
            this.flowLayoutPanelMuellimler.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageEsasXususiyetler);
            this.tabControl1.Controls.Add(this.tabPageDilQabiliyyetleri);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 166);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageEsasXususiyetler
            // 
            this.tabPageEsasXususiyetler.AutoScroll = true;
            this.tabPageEsasXususiyetler.AutoScrollMinSize = new System.Drawing.Size(0, 300);
            this.tabPageEsasXususiyetler.Controls.Add(this.groupBoxAdFamilyaVeAtaAdi);
            this.tabPageEsasXususiyetler.Controls.Add(this.groupBoxCinsiyyet);
            this.tabPageEsasXususiyetler.Controls.Add(this.groupBoxMilliyetVeVetendaslik);
            this.tabPageEsasXususiyetler.Controls.Add(this.groupBoxTecrube);
            this.tabPageEsasXususiyetler.Controls.Add(this.groupBoxYasAraligi);
            this.tabPageEsasXususiyetler.Location = new System.Drawing.Point(4, 22);
            this.tabPageEsasXususiyetler.Name = "tabPageEsasXususiyetler";
            this.tabPageEsasXususiyetler.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEsasXususiyetler.Size = new System.Drawing.Size(952, 140);
            this.tabPageEsasXususiyetler.TabIndex = 0;
            this.tabPageEsasXususiyetler.Text = "Əsas Xususiyətlər";
            this.tabPageEsasXususiyetler.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdFamilyaVeAtaAdi
            // 
            this.groupBoxAdFamilyaVeAtaAdi.Controls.Add(this.textBoxAtaAdi);
            this.groupBoxAdFamilyaVeAtaAdi.Controls.Add(this.labelAtaAdi);
            this.groupBoxAdFamilyaVeAtaAdi.Controls.Add(this.textBoxFamilya);
            this.groupBoxAdFamilyaVeAtaAdi.Controls.Add(this.textBoxAd);
            this.groupBoxAdFamilyaVeAtaAdi.Controls.Add(this.checkBoxAdFamilyaVeAtaAdiSorgulansin);
            this.groupBoxAdFamilyaVeAtaAdi.Controls.Add(this.labelFamilya);
            this.groupBoxAdFamilyaVeAtaAdi.Controls.Add(this.labelAd);
            this.groupBoxAdFamilyaVeAtaAdi.Location = new System.Drawing.Point(10, 6);
            this.groupBoxAdFamilyaVeAtaAdi.Name = "groupBoxAdFamilyaVeAtaAdi";
            this.groupBoxAdFamilyaVeAtaAdi.Size = new System.Drawing.Size(215, 125);
            this.groupBoxAdFamilyaVeAtaAdi.TabIndex = 9;
            this.groupBoxAdFamilyaVeAtaAdi.TabStop = false;
            this.groupBoxAdFamilyaVeAtaAdi.Text = "Ad, Familya Və Ata Adı";
            // 
            // textBoxAtaAdi
            // 
            this.textBoxAtaAdi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxAtaAdi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxAtaAdi.Location = new System.Drawing.Point(80, 91);
            this.textBoxAtaAdi.Name = "textBoxAtaAdi";
            this.textBoxAtaAdi.Size = new System.Drawing.Size(129, 20);
            this.textBoxAtaAdi.TabIndex = 9;
            // 
            // labelAtaAdi
            // 
            this.labelAtaAdi.AutoSize = true;
            this.labelAtaAdi.Location = new System.Drawing.Point(6, 94);
            this.labelAtaAdi.Name = "labelAtaAdi";
            this.labelAtaAdi.Size = new System.Drawing.Size(47, 13);
            this.labelAtaAdi.TabIndex = 8;
            this.labelAtaAdi.Text = "Ata Adı :";
            // 
            // textBoxFamilya
            // 
            this.textBoxFamilya.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxFamilya.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxFamilya.Location = new System.Drawing.Point(80, 65);
            this.textBoxFamilya.Name = "textBoxFamilya";
            this.textBoxFamilya.Size = new System.Drawing.Size(129, 20);
            this.textBoxFamilya.TabIndex = 7;
            // 
            // textBoxAd
            // 
            this.textBoxAd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxAd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxAd.Location = new System.Drawing.Point(80, 39);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(129, 20);
            this.textBoxAd.TabIndex = 6;
            // 
            // checkBoxAdFamilyaVeAtaAdiSorgulansin
            // 
            this.checkBoxAdFamilyaVeAtaAdiSorgulansin.AutoSize = true;
            this.checkBoxAdFamilyaVeAtaAdiSorgulansin.Location = new System.Drawing.Point(9, 17);
            this.checkBoxAdFamilyaVeAtaAdiSorgulansin.Name = "checkBoxAdFamilyaVeAtaAdiSorgulansin";
            this.checkBoxAdFamilyaVeAtaAdiSorgulansin.Size = new System.Drawing.Size(87, 17);
            this.checkBoxAdFamilyaVeAtaAdiSorgulansin.TabIndex = 5;
            this.checkBoxAdFamilyaVeAtaAdiSorgulansin.Text = "Sorğulansın?";
            this.checkBoxAdFamilyaVeAtaAdiSorgulansin.UseVisualStyleBackColor = true;
            // 
            // labelFamilya
            // 
            this.labelFamilya.AutoSize = true;
            this.labelFamilya.Location = new System.Drawing.Point(6, 68);
            this.labelFamilya.Name = "labelFamilya";
            this.labelFamilya.Size = new System.Drawing.Size(48, 13);
            this.labelFamilya.TabIndex = 2;
            this.labelFamilya.Text = "Familya :";
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(6, 42);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(26, 13);
            this.labelAd.TabIndex = 1;
            this.labelAd.Text = "Ad :";
            // 
            // groupBoxCinsiyyet
            // 
            this.groupBoxCinsiyyet.Controls.Add(this.comboBox1);
            this.groupBoxCinsiyyet.Controls.Add(this.checkBoxCinsiyyetSorgulansin);
            this.groupBoxCinsiyyet.Controls.Add(this.labelCinsiyyet);
            this.groupBoxCinsiyyet.Location = new System.Drawing.Point(10, 137);
            this.groupBoxCinsiyyet.Name = "groupBoxCinsiyyet";
            this.groupBoxCinsiyyet.Size = new System.Drawing.Size(136, 71);
            this.groupBoxCinsiyyet.TabIndex = 8;
            this.groupBoxCinsiyyet.TabStop = false;
            this.groupBoxCinsiyyet.Text = "Cinsiyyət";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kişi",
            "Qadın"});
            this.comboBox1.Location = new System.Drawing.Point(66, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(62, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // checkBoxCinsiyyetSorgulansin
            // 
            this.checkBoxCinsiyyetSorgulansin.AutoSize = true;
            this.checkBoxCinsiyyetSorgulansin.Location = new System.Drawing.Point(6, 17);
            this.checkBoxCinsiyyetSorgulansin.Name = "checkBoxCinsiyyetSorgulansin";
            this.checkBoxCinsiyyetSorgulansin.Size = new System.Drawing.Size(87, 17);
            this.checkBoxCinsiyyetSorgulansin.TabIndex = 5;
            this.checkBoxCinsiyyetSorgulansin.Text = "Sorğulansın?";
            this.checkBoxCinsiyyetSorgulansin.UseVisualStyleBackColor = true;
            // 
            // labelCinsiyyet
            // 
            this.labelCinsiyyet.AutoSize = true;
            this.labelCinsiyyet.Location = new System.Drawing.Point(6, 42);
            this.labelCinsiyyet.Name = "labelCinsiyyet";
            this.labelCinsiyyet.Size = new System.Drawing.Size(54, 13);
            this.labelCinsiyyet.TabIndex = 1;
            this.labelCinsiyyet.Text = "Cinsiyyət :";
            // 
            // groupBoxMilliyetVeVetendaslik
            // 
            this.groupBoxMilliyetVeVetendaslik.Controls.Add(this.textBoxVetendaslik);
            this.groupBoxMilliyetVeVetendaslik.Controls.Add(this.textBoxMilliyet);
            this.groupBoxMilliyetVeVetendaslik.Controls.Add(this.checkBoxMilliyetVeVetendaslikSorgulansin);
            this.groupBoxMilliyetVeVetendaslik.Controls.Add(this.labelVetendaslik);
            this.groupBoxMilliyetVeVetendaslik.Controls.Add(this.labelMilliyet);
            this.groupBoxMilliyetVeVetendaslik.Location = new System.Drawing.Point(591, 6);
            this.groupBoxMilliyetVeVetendaslik.Name = "groupBoxMilliyetVeVetendaslik";
            this.groupBoxMilliyetVeVetendaslik.Size = new System.Drawing.Size(213, 125);
            this.groupBoxMilliyetVeVetendaslik.TabIndex = 6;
            this.groupBoxMilliyetVeVetendaslik.TabStop = false;
            this.groupBoxMilliyetVeVetendaslik.Text = "Milliyət Və Vətəndaşlık";
            // 
            // textBoxVetendaslik
            // 
            this.textBoxVetendaslik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxVetendaslik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxVetendaslik.Location = new System.Drawing.Point(80, 65);
            this.textBoxVetendaslik.Name = "textBoxVetendaslik";
            this.textBoxVetendaslik.Size = new System.Drawing.Size(125, 20);
            this.textBoxVetendaslik.TabIndex = 7;
            // 
            // textBoxMilliyet
            // 
            this.textBoxMilliyet.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxMilliyet.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxMilliyet.Location = new System.Drawing.Point(80, 39);
            this.textBoxMilliyet.Name = "textBoxMilliyet";
            this.textBoxMilliyet.Size = new System.Drawing.Size(125, 20);
            this.textBoxMilliyet.TabIndex = 6;
            // 
            // checkBoxMilliyetVeVetendaslikSorgulansin
            // 
            this.checkBoxMilliyetVeVetendaslikSorgulansin.AutoSize = true;
            this.checkBoxMilliyetVeVetendaslikSorgulansin.Location = new System.Drawing.Point(9, 17);
            this.checkBoxMilliyetVeVetendaslikSorgulansin.Name = "checkBoxMilliyetVeVetendaslikSorgulansin";
            this.checkBoxMilliyetVeVetendaslikSorgulansin.Size = new System.Drawing.Size(87, 17);
            this.checkBoxMilliyetVeVetendaslikSorgulansin.TabIndex = 5;
            this.checkBoxMilliyetVeVetendaslikSorgulansin.Text = "Sorğulansın?";
            this.checkBoxMilliyetVeVetendaslikSorgulansin.UseVisualStyleBackColor = true;
            // 
            // labelVetendaslik
            // 
            this.labelVetendaslik.AutoSize = true;
            this.labelVetendaslik.Location = new System.Drawing.Point(6, 68);
            this.labelVetendaslik.Name = "labelVetendaslik";
            this.labelVetendaslik.Size = new System.Drawing.Size(68, 13);
            this.labelVetendaslik.TabIndex = 2;
            this.labelVetendaslik.Text = "Vətəndaşlık :";
            // 
            // labelMilliyet
            // 
            this.labelMilliyet.AutoSize = true;
            this.labelMilliyet.Location = new System.Drawing.Point(6, 42);
            this.labelMilliyet.Name = "labelMilliyet";
            this.labelMilliyet.Size = new System.Drawing.Size(44, 13);
            this.labelMilliyet.TabIndex = 1;
            this.labelMilliyet.Text = "Milliyət :";
            // 
            // groupBoxTecrube
            // 
            this.groupBoxTecrube.Controls.Add(this.checkBoxTecrubeSorgulansin);
            this.groupBoxTecrube.Controls.Add(this.numericUpDownMaksimalTecrube);
            this.groupBoxTecrube.Controls.Add(this.numericUpDownMinimalTecrube);
            this.groupBoxTecrube.Controls.Add(this.labelMaksimalTecrube);
            this.groupBoxTecrube.Controls.Add(this.labelMinimalTecrube);
            this.groupBoxTecrube.Location = new System.Drawing.Point(402, 6);
            this.groupBoxTecrube.Name = "groupBoxTecrube";
            this.groupBoxTecrube.Size = new System.Drawing.Size(183, 125);
            this.groupBoxTecrube.TabIndex = 4;
            this.groupBoxTecrube.TabStop = false;
            this.groupBoxTecrube.Text = "Təcrübə";
            // 
            // checkBoxTecrubeSorgulansin
            // 
            this.checkBoxTecrubeSorgulansin.AutoSize = true;
            this.checkBoxTecrubeSorgulansin.Location = new System.Drawing.Point(9, 17);
            this.checkBoxTecrubeSorgulansin.Name = "checkBoxTecrubeSorgulansin";
            this.checkBoxTecrubeSorgulansin.Size = new System.Drawing.Size(87, 17);
            this.checkBoxTecrubeSorgulansin.TabIndex = 5;
            this.checkBoxTecrubeSorgulansin.Text = "Sorğulansın?";
            this.checkBoxTecrubeSorgulansin.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMaksimalTecrube
            // 
            this.numericUpDownMaksimalTecrube.Location = new System.Drawing.Point(111, 66);
            this.numericUpDownMaksimalTecrube.Name = "numericUpDownMaksimalTecrube";
            this.numericUpDownMaksimalTecrube.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownMaksimalTecrube.TabIndex = 3;
            // 
            // numericUpDownMinimalTecrube
            // 
            this.numericUpDownMinimalTecrube.Location = new System.Drawing.Point(111, 40);
            this.numericUpDownMinimalTecrube.Name = "numericUpDownMinimalTecrube";
            this.numericUpDownMinimalTecrube.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownMinimalTecrube.TabIndex = 1;
            // 
            // labelMaksimalTecrube
            // 
            this.labelMaksimalTecrube.AutoSize = true;
            this.labelMaksimalTecrube.Location = new System.Drawing.Point(6, 68);
            this.labelMaksimalTecrube.Name = "labelMaksimalTecrube";
            this.labelMaksimalTecrube.Size = new System.Drawing.Size(100, 13);
            this.labelMaksimalTecrube.TabIndex = 2;
            this.labelMaksimalTecrube.Text = "Maksimal Təcrübə :";
            // 
            // labelMinimalTecrube
            // 
            this.labelMinimalTecrube.AutoSize = true;
            this.labelMinimalTecrube.Location = new System.Drawing.Point(6, 42);
            this.labelMinimalTecrube.Name = "labelMinimalTecrube";
            this.labelMinimalTecrube.Size = new System.Drawing.Size(91, 13);
            this.labelMinimalTecrube.TabIndex = 1;
            this.labelMinimalTecrube.Text = "Minimal Təcrübə :";
            // 
            // groupBoxYasAraligi
            // 
            this.groupBoxYasAraligi.Controls.Add(this.checkBoxYasAraligiSorgulansin);
            this.groupBoxYasAraligi.Controls.Add(this.numericUpDownMaksimalYas);
            this.groupBoxYasAraligi.Controls.Add(this.numericUpDownMinimalYas);
            this.groupBoxYasAraligi.Controls.Add(this.labelMaksimalYas);
            this.groupBoxYasAraligi.Controls.Add(this.labelMinimalYas);
            this.groupBoxYasAraligi.Location = new System.Drawing.Point(231, 6);
            this.groupBoxYasAraligi.Name = "groupBoxYasAraligi";
            this.groupBoxYasAraligi.Size = new System.Drawing.Size(165, 125);
            this.groupBoxYasAraligi.TabIndex = 0;
            this.groupBoxYasAraligi.TabStop = false;
            this.groupBoxYasAraligi.Text = "Yaş Aralığı";
            // 
            // checkBoxYasAraligiSorgulansin
            // 
            this.checkBoxYasAraligiSorgulansin.AutoSize = true;
            this.checkBoxYasAraligiSorgulansin.Location = new System.Drawing.Point(9, 17);
            this.checkBoxYasAraligiSorgulansin.Name = "checkBoxYasAraligiSorgulansin";
            this.checkBoxYasAraligiSorgulansin.Size = new System.Drawing.Size(87, 17);
            this.checkBoxYasAraligiSorgulansin.TabIndex = 4;
            this.checkBoxYasAraligiSorgulansin.Text = "Sorğulansın?";
            this.checkBoxYasAraligiSorgulansin.UseVisualStyleBackColor = true;
            // 
            // numericUpDownMaksimalYas
            // 
            this.numericUpDownMaksimalYas.Location = new System.Drawing.Point(90, 65);
            this.numericUpDownMaksimalYas.Name = "numericUpDownMaksimalYas";
            this.numericUpDownMaksimalYas.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownMaksimalYas.TabIndex = 3;
            // 
            // numericUpDownMinimalYas
            // 
            this.numericUpDownMinimalYas.Location = new System.Drawing.Point(90, 40);
            this.numericUpDownMinimalYas.Name = "numericUpDownMinimalYas";
            this.numericUpDownMinimalYas.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownMinimalYas.TabIndex = 1;
            // 
            // labelMaksimalYas
            // 
            this.labelMaksimalYas.AutoSize = true;
            this.labelMaksimalYas.Location = new System.Drawing.Point(6, 68);
            this.labelMaksimalYas.Name = "labelMaksimalYas";
            this.labelMaksimalYas.Size = new System.Drawing.Size(78, 13);
            this.labelMaksimalYas.TabIndex = 2;
            this.labelMaksimalYas.Text = "Maksimal Yaş :";
            // 
            // labelMinimalYas
            // 
            this.labelMinimalYas.AutoSize = true;
            this.labelMinimalYas.Location = new System.Drawing.Point(6, 42);
            this.labelMinimalYas.Name = "labelMinimalYas";
            this.labelMinimalYas.Size = new System.Drawing.Size(69, 13);
            this.labelMinimalYas.TabIndex = 1;
            this.labelMinimalYas.Text = "Minimal Yaş :";
            // 
            // tabPageDilQabiliyyetleri
            // 
            this.tabPageDilQabiliyyetleri.Controls.Add(this.flowLayoutPanelDiller);
            this.tabPageDilQabiliyyetleri.Controls.Add(this.checkBoxDilQabiliyyetleriSorgulansin);
            this.tabPageDilQabiliyyetleri.Location = new System.Drawing.Point(4, 22);
            this.tabPageDilQabiliyyetleri.Name = "tabPageDilQabiliyyetleri";
            this.tabPageDilQabiliyyetleri.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDilQabiliyyetleri.Size = new System.Drawing.Size(952, 140);
            this.tabPageDilQabiliyyetleri.TabIndex = 1;
            this.tabPageDilQabiliyyetleri.Text = "Dil Qabiliyyətləri";
            this.tabPageDilQabiliyyetleri.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelDiller
            // 
            this.flowLayoutPanelDiller.AutoScroll = true;
            this.flowLayoutPanelDiller.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelDiller.Location = new System.Drawing.Point(6, 29);
            this.flowLayoutPanelDiller.Name = "flowLayoutPanelDiller";
            this.flowLayoutPanelDiller.Size = new System.Drawing.Size(940, 105);
            this.flowLayoutPanelDiller.TabIndex = 7;
            // 
            // checkBoxDilQabiliyyetleriSorgulansin
            // 
            this.checkBoxDilQabiliyyetleriSorgulansin.AutoSize = true;
            this.checkBoxDilQabiliyyetleriSorgulansin.Location = new System.Drawing.Point(6, 6);
            this.checkBoxDilQabiliyyetleriSorgulansin.Name = "checkBoxDilQabiliyyetleriSorgulansin";
            this.checkBoxDilQabiliyyetleriSorgulansin.Size = new System.Drawing.Size(87, 17);
            this.checkBoxDilQabiliyyetleriSorgulansin.TabIndex = 6;
            this.checkBoxDilQabiliyyetleriSorgulansin.Text = "Sorğulansın?";
            this.checkBoxDilQabiliyyetleriSorgulansin.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanelDersler);
            this.tabPage1.Controls.Add(this.checkBoxDerslerSorgulansin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(952, 140);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Dərslər";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanelDersler
            // 
            this.flowLayoutPanelDersler.AutoScroll = true;
            this.flowLayoutPanelDersler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanelDersler.Location = new System.Drawing.Point(6, 29);
            this.flowLayoutPanelDersler.Name = "flowLayoutPanelDersler";
            this.flowLayoutPanelDersler.Size = new System.Drawing.Size(940, 105);
            this.flowLayoutPanelDersler.TabIndex = 9;
            // 
            // checkBoxDerslerSorgulansin
            // 
            this.checkBoxDerslerSorgulansin.AutoSize = true;
            this.checkBoxDerslerSorgulansin.Location = new System.Drawing.Point(6, 6);
            this.checkBoxDerslerSorgulansin.Name = "checkBoxDerslerSorgulansin";
            this.checkBoxDerslerSorgulansin.Size = new System.Drawing.Size(87, 17);
            this.checkBoxDerslerSorgulansin.TabIndex = 8;
            this.checkBoxDerslerSorgulansin.Text = "Sorğulansın?";
            this.checkBoxDerslerSorgulansin.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 140);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(952, 140);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(952, 140);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonSorgula
            // 
            this.buttonSorgula.Location = new System.Drawing.Point(897, 184);
            this.buttonSorgula.Name = "buttonSorgula";
            this.buttonSorgula.Size = new System.Drawing.Size(75, 23);
            this.buttonSorgula.TabIndex = 2;
            this.buttonSorgula.Text = "Sorğula";
            this.buttonSorgula.UseVisualStyleBackColor = true;
            this.buttonSorgula.Click += new System.EventHandler(this.buttonSorgula_Click);
            // 
            // FormMuellimSorgulamalari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.buttonSorgula);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.flowLayoutPanelMuellimler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMuellimSorgulamalari";
            this.ShowIcon = false;
            this.Text = "Müəllim Sorğulamaları";
            this.Load += new System.EventHandler(this.FormMuellimSorgulamalari_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageEsasXususiyetler.ResumeLayout(false);
            this.groupBoxAdFamilyaVeAtaAdi.ResumeLayout(false);
            this.groupBoxAdFamilyaVeAtaAdi.PerformLayout();
            this.groupBoxCinsiyyet.ResumeLayout(false);
            this.groupBoxCinsiyyet.PerformLayout();
            this.groupBoxMilliyetVeVetendaslik.ResumeLayout(false);
            this.groupBoxMilliyetVeVetendaslik.PerformLayout();
            this.groupBoxTecrube.ResumeLayout(false);
            this.groupBoxTecrube.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaksimalTecrube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimalTecrube)).EndInit();
            this.groupBoxYasAraligi.ResumeLayout(false);
            this.groupBoxYasAraligi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaksimalYas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinimalYas)).EndInit();
            this.tabPageDilQabiliyyetleri.ResumeLayout(false);
            this.tabPageDilQabiliyyetleri.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMuellimler;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageEsasXususiyetler;
        private System.Windows.Forms.TabPage tabPageDilQabiliyyetleri;
        private System.Windows.Forms.Button buttonSorgula;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBoxYasAraligi;
        private System.Windows.Forms.NumericUpDown numericUpDownMaksimalYas;
        private System.Windows.Forms.NumericUpDown numericUpDownMinimalYas;
        private System.Windows.Forms.Label labelMaksimalYas;
        private System.Windows.Forms.Label labelMinimalYas;
        private System.Windows.Forms.GroupBox groupBoxTecrube;
        private System.Windows.Forms.NumericUpDown numericUpDownMaksimalTecrube;
        private System.Windows.Forms.NumericUpDown numericUpDownMinimalTecrube;
        private System.Windows.Forms.Label labelMaksimalTecrube;
        private System.Windows.Forms.Label labelMinimalTecrube;
        private System.Windows.Forms.CheckBox checkBoxYasAraligiSorgulansin;
        private System.Windows.Forms.CheckBox checkBoxTecrubeSorgulansin;
        private System.Windows.Forms.GroupBox groupBoxMilliyetVeVetendaslik;
        private System.Windows.Forms.CheckBox checkBoxMilliyetVeVetendaslikSorgulansin;
        private System.Windows.Forms.Label labelVetendaslik;
        private System.Windows.Forms.Label labelMilliyet;
        private System.Windows.Forms.TextBox textBoxVetendaslik;
        private System.Windows.Forms.TextBox textBoxMilliyet;
        private System.Windows.Forms.GroupBox groupBoxCinsiyyet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBoxCinsiyyetSorgulansin;
        private System.Windows.Forms.Label labelCinsiyyet;
        private System.Windows.Forms.GroupBox groupBoxAdFamilyaVeAtaAdi;
        private System.Windows.Forms.TextBox textBoxAtaAdi;
        private System.Windows.Forms.Label labelAtaAdi;
        private System.Windows.Forms.TextBox textBoxFamilya;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.CheckBox checkBoxAdFamilyaVeAtaAdiSorgulansin;
        private System.Windows.Forms.Label labelFamilya;
        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDiller;
        private System.Windows.Forms.CheckBox checkBoxDilQabiliyyetleriSorgulansin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDersler;
        private System.Windows.Forms.CheckBox checkBoxDerslerSorgulansin;
    }
}