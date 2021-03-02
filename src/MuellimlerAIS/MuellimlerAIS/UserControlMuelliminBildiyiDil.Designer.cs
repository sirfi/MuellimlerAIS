namespace MuellimlerAIS
{
    partial class UserControlMuelliminBildiyiDil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxDilinAdi = new System.Windows.Forms.CheckBox();
            this.labelSeviyye = new System.Windows.Forms.Label();
            this.comboBoxSeviyye = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // checkBoxDilinAdi
            // 
            this.checkBoxDilinAdi.Location = new System.Drawing.Point(3, 3);
            this.checkBoxDilinAdi.Name = "checkBoxDilinAdi";
            this.checkBoxDilinAdi.Size = new System.Drawing.Size(120, 24);
            this.checkBoxDilinAdi.TabIndex = 0;
            this.checkBoxDilinAdi.Text = "Dilin Adı";
            this.checkBoxDilinAdi.UseVisualStyleBackColor = true;
            // 
            // labelSeviyye
            // 
            this.labelSeviyye.AutoSize = true;
            this.labelSeviyye.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSeviyye.Location = new System.Drawing.Point(129, 8);
            this.labelSeviyye.Name = "labelSeviyye";
            this.labelSeviyye.Size = new System.Drawing.Size(55, 15);
            this.labelSeviyye.TabIndex = 1;
            this.labelSeviyye.Text = "Səviyyə : ";
            // 
            // comboBoxSeviyye
            // 
            this.comboBoxSeviyye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSeviyye.FormattingEnabled = true;
            this.comboBoxSeviyye.Location = new System.Drawing.Point(190, 5);
            this.comboBoxSeviyye.Name = "comboBoxSeviyye";
            this.comboBoxSeviyye.Size = new System.Drawing.Size(100, 21);
            this.comboBoxSeviyye.TabIndex = 2;
            // 
            // UserControlMuelliminBildiyiDil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.comboBoxSeviyye);
            this.Controls.Add(this.labelSeviyye);
            this.Controls.Add(this.checkBoxDilinAdi);
            this.Name = "UserControlMuelliminBildiyiDil";
            this.Size = new System.Drawing.Size(295, 30);
            this.Load += new System.EventHandler(this.UserControlMuelliminBildiyiDil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxDilinAdi;
        private System.Windows.Forms.Label labelSeviyye;
        private System.Windows.Forms.ComboBox comboBoxSeviyye;
    }
}
