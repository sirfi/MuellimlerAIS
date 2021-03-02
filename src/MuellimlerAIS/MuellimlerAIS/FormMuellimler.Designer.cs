namespace MuellimlerAIS
{
    partial class FormMuellimler
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
            this.labelAd = new System.Windows.Forms.Label();
            this.labelFamilya = new System.Windows.Forms.Label();
            this.labelAtaAdi = new System.Windows.Forms.Label();
            this.labelCinsiyyet = new System.Windows.Forms.Label();
            this.labelDogulduguTarix = new System.Windows.Forms.Label();
            this.labelElmiDerece = new System.Windows.Forms.Label();
            this.labelElimiVezife = new System.Windows.Forms.Label();
            this.labelVezifeliOlduguYer = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxFamilya = new System.Windows.Forms.TextBox();
            this.textBoxAtaAdi = new System.Windows.Forms.TextBox();
            this.comboBoxCinsiyyet = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxDogulduguTarix = new System.Windows.Forms.MaskedTextBox();
            this.comboBoxMuellimler = new System.Windows.Forms.ComboBox();
            this.comboBoxElmiDerece = new System.Windows.Forms.ComboBox();
            this.comboBoxVezife = new System.Windows.Forms.ComboBox();
            this.comboBoxVezifeliOlduguFakulte = new System.Windows.Forms.ComboBox();
            this.comboBoxVezifeliOlduguKafedra = new System.Windows.Forms.ComboBox();
            this.pictureBoxSekil = new System.Windows.Forms.PictureBox();
            this.buttonSekilDeyisdir = new System.Windows.Forms.Button();
            this.openFileDialogSekil = new System.Windows.Forms.OpenFileDialog();
            this.buttonYeni = new System.Windows.Forms.Button();
            this.buttonSaxla = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonBildiyiDiller = new System.Windows.Forms.Button();
            this.buttonDeyeBildiyiDersler = new System.Windows.Forms.Button();
            this.buttonElmiDereceSil = new System.Windows.Forms.Button();
            this.buttonElmiVezifeSil = new System.Windows.Forms.Button();
            this.labelDogulduguYer = new System.Windows.Forms.Label();
            this.labelMilliyet = new System.Windows.Forms.Label();
            this.labelVetendasliq = new System.Windows.Forms.Label();
            this.labelEvTelefonNomresi = new System.Windows.Forms.Label();
            this.labelMobilTelefonNomresi = new System.Windows.Forms.Label();
            this.labelEvUnvani = new System.Windows.Forms.Label();
            this.textBoxDogulduguYer = new System.Windows.Forms.TextBox();
            this.textBoxMilliyet = new System.Windows.Forms.TextBox();
            this.textBoxVetendasliq = new System.Windows.Forms.TextBox();
            this.maskedTextBoxEvTelefonNomresi = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMobilTelefonNomresi = new System.Windows.Forms.MaskedTextBox();
            this.textBoxEvUnvani = new System.Windows.Forms.TextBox();
            this.buttonTehsilleri = new System.Windows.Forms.Button();
            this.buttonMeqaleleri = new System.Windows.Forms.Button();
            this.buttonKitablari = new System.Windows.Forms.Button();
            this.labelBaslamaIli = new System.Windows.Forms.Label();
            this.numericUpDownBaslamaIli = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSekil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaslamaIli)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAd
            // 
            this.labelAd.AutoSize = true;
            this.labelAd.Location = new System.Drawing.Point(10, 43);
            this.labelAd.Name = "labelAd";
            this.labelAd.Size = new System.Drawing.Size(26, 13);
            this.labelAd.TabIndex = 1;
            this.labelAd.Text = "Ad :";
            // 
            // labelFamilya
            // 
            this.labelFamilya.AutoSize = true;
            this.labelFamilya.Location = new System.Drawing.Point(10, 69);
            this.labelFamilya.Name = "labelFamilya";
            this.labelFamilya.Size = new System.Drawing.Size(48, 13);
            this.labelFamilya.TabIndex = 1;
            this.labelFamilya.Text = "Familya :";
            // 
            // labelAtaAdi
            // 
            this.labelAtaAdi.AutoSize = true;
            this.labelAtaAdi.Location = new System.Drawing.Point(10, 97);
            this.labelAtaAdi.Name = "labelAtaAdi";
            this.labelAtaAdi.Size = new System.Drawing.Size(47, 13);
            this.labelAtaAdi.TabIndex = 2;
            this.labelAtaAdi.Text = "Ata Adı :";
            // 
            // labelCinsiyyet
            // 
            this.labelCinsiyyet.AutoSize = true;
            this.labelCinsiyyet.Location = new System.Drawing.Point(10, 122);
            this.labelCinsiyyet.Name = "labelCinsiyyet";
            this.labelCinsiyyet.Size = new System.Drawing.Size(54, 13);
            this.labelCinsiyyet.TabIndex = 3;
            this.labelCinsiyyet.Text = "Cinsiyyət :";
            // 
            // labelDogulduguTarix
            // 
            this.labelDogulduguTarix.AutoSize = true;
            this.labelDogulduguTarix.Location = new System.Drawing.Point(10, 150);
            this.labelDogulduguTarix.Name = "labelDogulduguTarix";
            this.labelDogulduguTarix.Size = new System.Drawing.Size(91, 13);
            this.labelDogulduguTarix.TabIndex = 4;
            this.labelDogulduguTarix.Text = "Doğulduğu Tarix :";
            // 
            // labelElmiDerece
            // 
            this.labelElmiDerece.AutoSize = true;
            this.labelElmiDerece.Location = new System.Drawing.Point(10, 398);
            this.labelElmiDerece.Name = "labelElmiDerece";
            this.labelElmiDerece.Size = new System.Drawing.Size(70, 13);
            this.labelElmiDerece.TabIndex = 9;
            this.labelElmiDerece.Text = "Elmi Dərəcə :";
            // 
            // labelElimiVezife
            // 
            this.labelElimiVezife.AutoSize = true;
            this.labelElimiVezife.Location = new System.Drawing.Point(10, 427);
            this.labelElimiVezife.Name = "labelElimiVezife";
            this.labelElimiVezife.Size = new System.Drawing.Size(42, 13);
            this.labelElimiVezife.TabIndex = 10;
            this.labelElimiVezife.Text = "Vəzifə :";
            // 
            // labelVezifeliOlduguYer
            // 
            this.labelVezifeliOlduguYer.AutoSize = true;
            this.labelVezifeliOlduguYer.Location = new System.Drawing.Point(10, 454);
            this.labelVezifeliOlduguYer.Name = "labelVezifeliOlduguYer";
            this.labelVezifeliOlduguYer.Size = new System.Drawing.Size(102, 13);
            this.labelVezifeliOlduguYer.TabIndex = 11;
            this.labelVezifeliOlduguYer.Text = "Vəzifəli Olduğu Yer :";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(126, 40);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(200, 20);
            this.textBoxAd.TabIndex = 12;
            // 
            // textBoxFamilya
            // 
            this.textBoxFamilya.Location = new System.Drawing.Point(126, 66);
            this.textBoxFamilya.Name = "textBoxFamilya";
            this.textBoxFamilya.Size = new System.Drawing.Size(200, 20);
            this.textBoxFamilya.TabIndex = 13;
            // 
            // textBoxAtaAdi
            // 
            this.textBoxAtaAdi.Location = new System.Drawing.Point(126, 94);
            this.textBoxAtaAdi.Name = "textBoxAtaAdi";
            this.textBoxAtaAdi.Size = new System.Drawing.Size(200, 20);
            this.textBoxAtaAdi.TabIndex = 14;
            // 
            // comboBoxCinsiyyet
            // 
            this.comboBoxCinsiyyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCinsiyyet.FormattingEnabled = true;
            this.comboBoxCinsiyyet.Items.AddRange(new object[] {
            "Kişi",
            "Qadın"});
            this.comboBoxCinsiyyet.Location = new System.Drawing.Point(126, 119);
            this.comboBoxCinsiyyet.Name = "comboBoxCinsiyyet";
            this.comboBoxCinsiyyet.Size = new System.Drawing.Size(80, 21);
            this.comboBoxCinsiyyet.TabIndex = 15;
            // 
            // maskedTextBoxDogulduguTarix
            // 
            this.maskedTextBoxDogulduguTarix.Location = new System.Drawing.Point(126, 147);
            this.maskedTextBoxDogulduguTarix.Mask = "00.00.0000";
            this.maskedTextBoxDogulduguTarix.Name = "maskedTextBoxDogulduguTarix";
            this.maskedTextBoxDogulduguTarix.Size = new System.Drawing.Size(63, 20);
            this.maskedTextBoxDogulduguTarix.TabIndex = 16;
            // 
            // comboBoxMuellimler
            // 
            this.comboBoxMuellimler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMuellimler.FormattingEnabled = true;
            this.comboBoxMuellimler.Location = new System.Drawing.Point(13, 13);
            this.comboBoxMuellimler.Name = "comboBoxMuellimler";
            this.comboBoxMuellimler.Size = new System.Drawing.Size(313, 21);
            this.comboBoxMuellimler.TabIndex = 0;
            this.comboBoxMuellimler.SelectedIndexChanged += new System.EventHandler(this.comboBoxMuellimler_SelectedIndexChanged);
            // 
            // comboBoxElmiDerece
            // 
            this.comboBoxElmiDerece.FormattingEnabled = true;
            this.comboBoxElmiDerece.Location = new System.Drawing.Point(126, 395);
            this.comboBoxElmiDerece.Name = "comboBoxElmiDerece";
            this.comboBoxElmiDerece.Size = new System.Drawing.Size(150, 21);
            this.comboBoxElmiDerece.TabIndex = 22;
            // 
            // comboBoxVezife
            // 
            this.comboBoxVezife.FormattingEnabled = true;
            this.comboBoxVezife.Location = new System.Drawing.Point(126, 423);
            this.comboBoxVezife.Name = "comboBoxVezife";
            this.comboBoxVezife.Size = new System.Drawing.Size(150, 21);
            this.comboBoxVezife.TabIndex = 24;
            // 
            // comboBoxVezifeliOlduguFakulte
            // 
            this.comboBoxVezifeliOlduguFakulte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVezifeliOlduguFakulte.FormattingEnabled = true;
            this.comboBoxVezifeliOlduguFakulte.Location = new System.Drawing.Point(126, 451);
            this.comboBoxVezifeliOlduguFakulte.Name = "comboBoxVezifeliOlduguFakulte";
            this.comboBoxVezifeliOlduguFakulte.Size = new System.Drawing.Size(200, 21);
            this.comboBoxVezifeliOlduguFakulte.TabIndex = 26;
            this.comboBoxVezifeliOlduguFakulte.SelectedIndexChanged += new System.EventHandler(this.comboBoxVezifeliOlduguFakulte_SelectedIndexChanged);
            // 
            // comboBoxVezifeliOlduguKafedra
            // 
            this.comboBoxVezifeliOlduguKafedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVezifeliOlduguKafedra.FormattingEnabled = true;
            this.comboBoxVezifeliOlduguKafedra.Location = new System.Drawing.Point(126, 479);
            this.comboBoxVezifeliOlduguKafedra.Name = "comboBoxVezifeliOlduguKafedra";
            this.comboBoxVezifeliOlduguKafedra.Size = new System.Drawing.Size(200, 21);
            this.comboBoxVezifeliOlduguKafedra.TabIndex = 27;
            // 
            // pictureBoxSekil
            // 
            this.pictureBoxSekil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxSekil.Location = new System.Drawing.Point(332, 13);
            this.pictureBoxSekil.Name = "pictureBoxSekil";
            this.pictureBoxSekil.Size = new System.Drawing.Size(160, 200);
            this.pictureBoxSekil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSekil.TabIndex = 25;
            this.pictureBoxSekil.TabStop = false;
            // 
            // buttonSekilDeyisdir
            // 
            this.buttonSekilDeyisdir.Location = new System.Drawing.Point(332, 220);
            this.buttonSekilDeyisdir.Name = "buttonSekilDeyisdir";
            this.buttonSekilDeyisdir.Size = new System.Drawing.Size(160, 23);
            this.buttonSekilDeyisdir.TabIndex = 26;
            this.buttonSekilDeyisdir.Text = "Şəkil Dəyişdir";
            this.buttonSekilDeyisdir.UseVisualStyleBackColor = true;
            this.buttonSekilDeyisdir.Click += new System.EventHandler(this.buttonSekilDeyisdir_Click);
            // 
            // openFileDialogSekil
            // 
            this.openFileDialogSekil.Filter = "GIF|*.gif|PNG|*.png|JPG|*.jpg";
            this.openFileDialogSekil.Title = "Müəllimin Şəklini Seç";
            // 
            // buttonYeni
            // 
            this.buttonYeni.Location = new System.Drawing.Point(13, 506);
            this.buttonYeni.Name = "buttonYeni";
            this.buttonYeni.Size = new System.Drawing.Size(100, 23);
            this.buttonYeni.TabIndex = 28;
            this.buttonYeni.Text = "Yeni";
            this.buttonYeni.UseVisualStyleBackColor = true;
            this.buttonYeni.Click += new System.EventHandler(this.buttonYeni_Click);
            // 
            // buttonSaxla
            // 
            this.buttonSaxla.Location = new System.Drawing.Point(119, 506);
            this.buttonSaxla.Name = "buttonSaxla";
            this.buttonSaxla.Size = new System.Drawing.Size(101, 23);
            this.buttonSaxla.TabIndex = 29;
            this.buttonSaxla.Text = "Saxla";
            this.buttonSaxla.UseVisualStyleBackColor = true;
            this.buttonSaxla.Click += new System.EventHandler(this.buttonSaxla_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(226, 506);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(100, 23);
            this.buttonSil.TabIndex = 30;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonBildiyiDiller
            // 
            this.buttonBildiyiDiller.Location = new System.Drawing.Point(332, 278);
            this.buttonBildiyiDiller.Name = "buttonBildiyiDiller";
            this.buttonBildiyiDiller.Size = new System.Drawing.Size(160, 23);
            this.buttonBildiyiDiller.TabIndex = 32;
            this.buttonBildiyiDiller.Text = "Bildiyi Dillər";
            this.buttonBildiyiDiller.UseVisualStyleBackColor = true;
            this.buttonBildiyiDiller.Click += new System.EventHandler(this.buttonBildiyiDiller_Click);
            // 
            // buttonDeyeBildiyiDersler
            // 
            this.buttonDeyeBildiyiDersler.Location = new System.Drawing.Point(332, 307);
            this.buttonDeyeBildiyiDersler.Name = "buttonDeyeBildiyiDersler";
            this.buttonDeyeBildiyiDersler.Size = new System.Drawing.Size(160, 23);
            this.buttonDeyeBildiyiDersler.TabIndex = 33;
            this.buttonDeyeBildiyiDersler.Text = "Deyə Bildiyi Dərslər";
            this.buttonDeyeBildiyiDersler.UseVisualStyleBackColor = true;
            this.buttonDeyeBildiyiDersler.Click += new System.EventHandler(this.buttonDeyeBildiyiDersler_Click);
            // 
            // buttonElmiDereceSil
            // 
            this.buttonElmiDereceSil.Location = new System.Drawing.Point(282, 393);
            this.buttonElmiDereceSil.Name = "buttonElmiDereceSil";
            this.buttonElmiDereceSil.Size = new System.Drawing.Size(44, 23);
            this.buttonElmiDereceSil.TabIndex = 23;
            this.buttonElmiDereceSil.Text = "Sil";
            this.buttonElmiDereceSil.UseVisualStyleBackColor = true;
            this.buttonElmiDereceSil.Click += new System.EventHandler(this.buttonElmiDereceSil_Click);
            // 
            // buttonElmiVezifeSil
            // 
            this.buttonElmiVezifeSil.Location = new System.Drawing.Point(282, 422);
            this.buttonElmiVezifeSil.Name = "buttonElmiVezifeSil";
            this.buttonElmiVezifeSil.Size = new System.Drawing.Size(44, 23);
            this.buttonElmiVezifeSil.TabIndex = 25;
            this.buttonElmiVezifeSil.Text = "Sil";
            this.buttonElmiVezifeSil.UseVisualStyleBackColor = true;
            this.buttonElmiVezifeSil.Click += new System.EventHandler(this.buttonElmiVezifeSil_Click);
            // 
            // labelDogulduguYer
            // 
            this.labelDogulduguYer.AutoSize = true;
            this.labelDogulduguYer.Location = new System.Drawing.Point(10, 181);
            this.labelDogulduguYer.Name = "labelDogulduguYer";
            this.labelDogulduguYer.Size = new System.Drawing.Size(84, 13);
            this.labelDogulduguYer.TabIndex = 34;
            this.labelDogulduguYer.Text = "Doğulduğu Yer :";
            // 
            // labelMilliyet
            // 
            this.labelMilliyet.AutoSize = true;
            this.labelMilliyet.Location = new System.Drawing.Point(10, 204);
            this.labelMilliyet.Name = "labelMilliyet";
            this.labelMilliyet.Size = new System.Drawing.Size(49, 13);
            this.labelMilliyet.TabIndex = 35;
            this.labelMilliyet.Text = "Milliyyət :";
            // 
            // labelVetendasliq
            // 
            this.labelVetendasliq.AutoSize = true;
            this.labelVetendasliq.Location = new System.Drawing.Point(10, 231);
            this.labelVetendasliq.Name = "labelVetendasliq";
            this.labelVetendasliq.Size = new System.Drawing.Size(68, 13);
            this.labelVetendasliq.TabIndex = 36;
            this.labelVetendasliq.Text = "Vətəndaşlıq :";
            // 
            // labelEvTelefonNomresi
            // 
            this.labelEvTelefonNomresi.AutoSize = true;
            this.labelEvTelefonNomresi.Location = new System.Drawing.Point(10, 254);
            this.labelEvTelefonNomresi.Name = "labelEvTelefonNomresi";
            this.labelEvTelefonNomresi.Size = new System.Drawing.Size(112, 13);
            this.labelEvTelefonNomresi.TabIndex = 37;
            this.labelEvTelefonNomresi.Text = "Ev Telefonu Nömrəsi :";
            // 
            // labelMobilTelefonNomresi
            // 
            this.labelMobilTelefonNomresi.AutoSize = true;
            this.labelMobilTelefonNomresi.Location = new System.Drawing.Point(10, 281);
            this.labelMobilTelefonNomresi.Name = "labelMobilTelefonNomresi";
            this.labelMobilTelefonNomresi.Size = new System.Drawing.Size(118, 13);
            this.labelMobilTelefonNomresi.TabIndex = 38;
            this.labelMobilTelefonNomresi.Text = "Mobil Telefon Nömrəsi :";
            // 
            // labelEvUnvani
            // 
            this.labelEvUnvani.AutoSize = true;
            this.labelEvUnvani.Location = new System.Drawing.Point(10, 308);
            this.labelEvUnvani.Name = "labelEvUnvani";
            this.labelEvUnvani.Size = new System.Drawing.Size(63, 13);
            this.labelEvUnvani.TabIndex = 39;
            this.labelEvUnvani.Text = "Ev Ünvanı :";
            // 
            // textBoxDogulduguYer
            // 
            this.textBoxDogulduguYer.Location = new System.Drawing.Point(126, 174);
            this.textBoxDogulduguYer.Name = "textBoxDogulduguYer";
            this.textBoxDogulduguYer.Size = new System.Drawing.Size(200, 20);
            this.textBoxDogulduguYer.TabIndex = 17;
            // 
            // textBoxMilliyet
            // 
            this.textBoxMilliyet.Location = new System.Drawing.Point(126, 201);
            this.textBoxMilliyet.Name = "textBoxMilliyet";
            this.textBoxMilliyet.Size = new System.Drawing.Size(200, 20);
            this.textBoxMilliyet.TabIndex = 18;
            // 
            // textBoxVetendasliq
            // 
            this.textBoxVetendasliq.Location = new System.Drawing.Point(126, 228);
            this.textBoxVetendasliq.Name = "textBoxVetendasliq";
            this.textBoxVetendasliq.Size = new System.Drawing.Size(200, 20);
            this.textBoxVetendasliq.TabIndex = 19;
            // 
            // maskedTextBoxEvTelefonNomresi
            // 
            this.maskedTextBoxEvTelefonNomresi.Location = new System.Drawing.Point(126, 251);
            this.maskedTextBoxEvTelefonNomresi.Mask = "(999) 000-0000";
            this.maskedTextBoxEvTelefonNomresi.Name = "maskedTextBoxEvTelefonNomresi";
            this.maskedTextBoxEvTelefonNomresi.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBoxEvTelefonNomresi.TabIndex = 19;
            // 
            // maskedTextBoxMobilTelefonNomresi
            // 
            this.maskedTextBoxMobilTelefonNomresi.Location = new System.Drawing.Point(126, 278);
            this.maskedTextBoxMobilTelefonNomresi.Mask = "(999) 000-0000";
            this.maskedTextBoxMobilTelefonNomresi.Name = "maskedTextBoxMobilTelefonNomresi";
            this.maskedTextBoxMobilTelefonNomresi.Size = new System.Drawing.Size(200, 20);
            this.maskedTextBoxMobilTelefonNomresi.TabIndex = 20;
            // 
            // textBoxEvUnvani
            // 
            this.textBoxEvUnvani.Location = new System.Drawing.Point(126, 305);
            this.textBoxEvUnvani.Multiline = true;
            this.textBoxEvUnvani.Name = "textBoxEvUnvani";
            this.textBoxEvUnvani.Size = new System.Drawing.Size(200, 58);
            this.textBoxEvUnvani.TabIndex = 21;
            // 
            // buttonTehsilleri
            // 
            this.buttonTehsilleri.Location = new System.Drawing.Point(332, 249);
            this.buttonTehsilleri.Name = "buttonTehsilleri";
            this.buttonTehsilleri.Size = new System.Drawing.Size(160, 23);
            this.buttonTehsilleri.TabIndex = 31;
            this.buttonTehsilleri.Text = "Təhsilləri";
            this.buttonTehsilleri.UseVisualStyleBackColor = true;
            this.buttonTehsilleri.Click += new System.EventHandler(this.buttonTehsilleri_Click);
            // 
            // buttonMeqaleleri
            // 
            this.buttonMeqaleleri.Location = new System.Drawing.Point(332, 336);
            this.buttonMeqaleleri.Name = "buttonMeqaleleri";
            this.buttonMeqaleleri.Size = new System.Drawing.Size(160, 23);
            this.buttonMeqaleleri.TabIndex = 34;
            this.buttonMeqaleleri.Text = "Məqalələri";
            this.buttonMeqaleleri.UseVisualStyleBackColor = true;
            this.buttonMeqaleleri.Click += new System.EventHandler(this.buttonMeqaleleri_Click);
            // 
            // buttonKitablari
            // 
            this.buttonKitablari.Location = new System.Drawing.Point(332, 365);
            this.buttonKitablari.Name = "buttonKitablari";
            this.buttonKitablari.Size = new System.Drawing.Size(160, 23);
            this.buttonKitablari.TabIndex = 35;
            this.buttonKitablari.Text = "Kitabları";
            this.buttonKitablari.UseVisualStyleBackColor = true;
            this.buttonKitablari.Click += new System.EventHandler(this.buttonKitablari_Click);
            // 
            // labelBaslamaIli
            // 
            this.labelBaslamaIli.AutoSize = true;
            this.labelBaslamaIli.Location = new System.Drawing.Point(10, 370);
            this.labelBaslamaIli.Name = "labelBaslamaIli";
            this.labelBaslamaIli.Size = new System.Drawing.Size(63, 13);
            this.labelBaslamaIli.TabIndex = 40;
            this.labelBaslamaIli.Text = "Başlama İli :";
            // 
            // numericUpDownBaslamaIli
            // 
            this.numericUpDownBaslamaIli.Location = new System.Drawing.Point(126, 369);
            this.numericUpDownBaslamaIli.Maximum = new decimal(new int[] {
            2012,
            0,
            0,
            0});
            this.numericUpDownBaslamaIli.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDownBaslamaIli.Name = "numericUpDownBaslamaIli";
            this.numericUpDownBaslamaIli.Size = new System.Drawing.Size(63, 20);
            this.numericUpDownBaslamaIli.TabIndex = 41;
            this.numericUpDownBaslamaIli.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // FormMuellimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 542);
            this.Controls.Add(this.numericUpDownBaslamaIli);
            this.Controls.Add(this.labelBaslamaIli);
            this.Controls.Add(this.buttonKitablari);
            this.Controls.Add(this.buttonMeqaleleri);
            this.Controls.Add(this.buttonTehsilleri);
            this.Controls.Add(this.textBoxEvUnvani);
            this.Controls.Add(this.maskedTextBoxMobilTelefonNomresi);
            this.Controls.Add(this.maskedTextBoxEvTelefonNomresi);
            this.Controls.Add(this.textBoxVetendasliq);
            this.Controls.Add(this.textBoxMilliyet);
            this.Controls.Add(this.textBoxDogulduguYer);
            this.Controls.Add(this.labelEvUnvani);
            this.Controls.Add(this.labelMobilTelefonNomresi);
            this.Controls.Add(this.labelEvTelefonNomresi);
            this.Controls.Add(this.labelVetendasliq);
            this.Controls.Add(this.labelMilliyet);
            this.Controls.Add(this.labelDogulduguYer);
            this.Controls.Add(this.buttonElmiVezifeSil);
            this.Controls.Add(this.buttonElmiDereceSil);
            this.Controls.Add(this.buttonDeyeBildiyiDersler);
            this.Controls.Add(this.buttonBildiyiDiller);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.buttonSaxla);
            this.Controls.Add(this.buttonYeni);
            this.Controls.Add(this.buttonSekilDeyisdir);
            this.Controls.Add(this.pictureBoxSekil);
            this.Controls.Add(this.comboBoxVezifeliOlduguKafedra);
            this.Controls.Add(this.comboBoxVezifeliOlduguFakulte);
            this.Controls.Add(this.comboBoxVezife);
            this.Controls.Add(this.comboBoxElmiDerece);
            this.Controls.Add(this.comboBoxMuellimler);
            this.Controls.Add(this.maskedTextBoxDogulduguTarix);
            this.Controls.Add(this.comboBoxCinsiyyet);
            this.Controls.Add(this.textBoxAtaAdi);
            this.Controls.Add(this.textBoxFamilya);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.labelVezifeliOlduguYer);
            this.Controls.Add(this.labelElimiVezife);
            this.Controls.Add(this.labelElmiDerece);
            this.Controls.Add(this.labelDogulduguTarix);
            this.Controls.Add(this.labelCinsiyyet);
            this.Controls.Add(this.labelAtaAdi);
            this.Controls.Add(this.labelFamilya);
            this.Controls.Add(this.labelAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMuellimler";
            this.ShowIcon = false;
            this.Text = "Müəllimlər";
            this.Load += new System.EventHandler(this.FormMuellimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSekil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaslamaIli)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAd;
        private System.Windows.Forms.Label labelFamilya;
        private System.Windows.Forms.Label labelAtaAdi;
        private System.Windows.Forms.Label labelCinsiyyet;
        private System.Windows.Forms.Label labelDogulduguTarix;
        private System.Windows.Forms.Label labelElmiDerece;
        private System.Windows.Forms.Label labelElimiVezife;
        private System.Windows.Forms.Label labelVezifeliOlduguYer;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.TextBox textBoxFamilya;
        private System.Windows.Forms.TextBox textBoxAtaAdi;
        private System.Windows.Forms.ComboBox comboBoxCinsiyyet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDogulduguTarix;
        private System.Windows.Forms.ComboBox comboBoxMuellimler;
        private System.Windows.Forms.ComboBox comboBoxElmiDerece;
        private System.Windows.Forms.ComboBox comboBoxVezife;
        private System.Windows.Forms.ComboBox comboBoxVezifeliOlduguFakulte;
        private System.Windows.Forms.ComboBox comboBoxVezifeliOlduguKafedra;
        private System.Windows.Forms.PictureBox pictureBoxSekil;
        private System.Windows.Forms.Button buttonSekilDeyisdir;
        private System.Windows.Forms.OpenFileDialog openFileDialogSekil;
        private System.Windows.Forms.Button buttonYeni;
        private System.Windows.Forms.Button buttonSaxla;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonBildiyiDiller;
        private System.Windows.Forms.Button buttonDeyeBildiyiDersler;
        private System.Windows.Forms.Button buttonElmiDereceSil;
        private System.Windows.Forms.Button buttonElmiVezifeSil;
        private System.Windows.Forms.Label labelDogulduguYer;
        private System.Windows.Forms.Label labelMilliyet;
        private System.Windows.Forms.Label labelVetendasliq;
        private System.Windows.Forms.Label labelEvTelefonNomresi;
        private System.Windows.Forms.Label labelMobilTelefonNomresi;
        private System.Windows.Forms.Label labelEvUnvani;
        private System.Windows.Forms.TextBox textBoxDogulduguYer;
        private System.Windows.Forms.TextBox textBoxMilliyet;
        private System.Windows.Forms.TextBox textBoxVetendasliq;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEvTelefonNomresi;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMobilTelefonNomresi;
        private System.Windows.Forms.TextBox textBoxEvUnvani;
        private System.Windows.Forms.Button buttonTehsilleri;
        private System.Windows.Forms.Button buttonMeqaleleri;
        private System.Windows.Forms.Button buttonKitablari;
        private System.Windows.Forms.Label labelBaslamaIli;
        private System.Windows.Forms.NumericUpDown numericUpDownBaslamaIli;

    }
}