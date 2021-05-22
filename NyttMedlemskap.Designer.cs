
namespace sluttest
{
    partial class NyttMedlemskap
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
            this.txt_Förnamn = new System.Windows.Forms.TextBox();
            this.txt_Efternamn = new System.Windows.Forms.TextBox();
            this.radioButton_man = new System.Windows.Forms.RadioButton();
            this.radioButton_kvinna = new System.Windows.Forms.RadioButton();
            this.dateTimePicker_Födelsedag = new System.Windows.Forms.DateTimePicker();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.label_förnamn = new System.Windows.Forms.Label();
            this.label_efternamn = new System.Windows.Forms.Label();
            this.label_kön = new System.Windows.Forms.Label();
            this.label_ålder = new System.Windows.Forms.Label();
            this.label_telefonnummer = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_datum = new System.Windows.Forms.Label();
            this.label_nivå = new System.Windows.Forms.Label();
            this.comboBox_Nivå = new System.Windows.Forms.ComboBox();
            this.button_spara = new System.Windows.Forms.Button();
            this.button_radera = new System.Windows.Forms.Button();
            this.dateTimePicker_tecknat = new System.Windows.Forms.DateTimePicker();
            this.label_Period = new System.Windows.Forms.Label();
            this.comboBox_Period = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txt_Förnamn
            // 
            this.txt_Förnamn.Location = new System.Drawing.Point(144, 44);
            this.txt_Förnamn.Name = "txt_Förnamn";
            this.txt_Förnamn.Size = new System.Drawing.Size(100, 20);
            this.txt_Förnamn.TabIndex = 0;
            // 
            // txt_Efternamn
            // 
            this.txt_Efternamn.Location = new System.Drawing.Point(144, 85);
            this.txt_Efternamn.Name = "txt_Efternamn";
            this.txt_Efternamn.Size = new System.Drawing.Size(100, 20);
            this.txt_Efternamn.TabIndex = 1;
            // 
            // radioButton_man
            // 
            this.radioButton_man.AutoSize = true;
            this.radioButton_man.Location = new System.Drawing.Point(144, 131);
            this.radioButton_man.Name = "radioButton_man";
            this.radioButton_man.Size = new System.Drawing.Size(46, 17);
            this.radioButton_man.TabIndex = 2;
            this.radioButton_man.TabStop = true;
            this.radioButton_man.Text = "Man";
            this.radioButton_man.UseVisualStyleBackColor = true;
            // 
            // radioButton_kvinna
            // 
            this.radioButton_kvinna.AutoSize = true;
            this.radioButton_kvinna.Location = new System.Drawing.Point(209, 133);
            this.radioButton_kvinna.Name = "radioButton_kvinna";
            this.radioButton_kvinna.Size = new System.Drawing.Size(58, 17);
            this.radioButton_kvinna.TabIndex = 3;
            this.radioButton_kvinna.TabStop = true;
            this.radioButton_kvinna.Text = "Kvinna";
            this.radioButton_kvinna.UseVisualStyleBackColor = true;
            this.radioButton_kvinna.CheckedChanged += new System.EventHandler(this.radioButton_kvinna_CheckedChanged);
            // 
            // dateTimePicker_Födelsedag
            // 
            this.dateTimePicker_Födelsedag.Location = new System.Drawing.Point(144, 162);
            this.dateTimePicker_Födelsedag.Name = "dateTimePicker_Födelsedag";
            this.dateTimePicker_Födelsedag.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Födelsedag.TabIndex = 4;
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(144, 205);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefon.TabIndex = 5;
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(419, 47);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(100, 20);
            this.txt_Mail.TabIndex = 6;
            // 
            // label_förnamn
            // 
            this.label_förnamn.AutoSize = true;
            this.label_förnamn.Location = new System.Drawing.Point(44, 47);
            this.label_förnamn.Name = "label_förnamn";
            this.label_förnamn.Size = new System.Drawing.Size(48, 13);
            this.label_förnamn.TabIndex = 7;
            this.label_förnamn.Text = "Förnamn";
            // 
            // label_efternamn
            // 
            this.label_efternamn.AutoSize = true;
            this.label_efternamn.Location = new System.Drawing.Point(44, 92);
            this.label_efternamn.Name = "label_efternamn";
            this.label_efternamn.Size = new System.Drawing.Size(55, 13);
            this.label_efternamn.TabIndex = 8;
            this.label_efternamn.Text = "Efternamn";
            // 
            // label_kön
            // 
            this.label_kön.AutoSize = true;
            this.label_kön.Location = new System.Drawing.Point(44, 130);
            this.label_kön.Name = "label_kön";
            this.label_kön.Size = new System.Drawing.Size(26, 13);
            this.label_kön.TabIndex = 9;
            this.label_kön.Text = "Kön";
            // 
            // label_ålder
            // 
            this.label_ålder.AutoSize = true;
            this.label_ålder.Location = new System.Drawing.Point(44, 168);
            this.label_ålder.Name = "label_ålder";
            this.label_ålder.Size = new System.Drawing.Size(62, 13);
            this.label_ålder.TabIndex = 10;
            this.label_ålder.Text = "Födelsedag";
            // 
            // label_telefonnummer
            // 
            this.label_telefonnummer.AutoSize = true;
            this.label_telefonnummer.Location = new System.Drawing.Point(44, 208);
            this.label_telefonnummer.Name = "label_telefonnummer";
            this.label_telefonnummer.Size = new System.Drawing.Size(80, 13);
            this.label_telefonnummer.TabIndex = 11;
            this.label_telefonnummer.Text = "Telefonnummer";
            // 
            // label_mail
            // 
            this.label_mail.AutoSize = true;
            this.label_mail.Location = new System.Drawing.Point(362, 50);
            this.label_mail.Name = "label_mail";
            this.label_mail.Size = new System.Drawing.Size(26, 13);
            this.label_mail.TabIndex = 12;
            this.label_mail.Text = "Mail";
            // 
            // label_datum
            // 
            this.label_datum.AutoSize = true;
            this.label_datum.Location = new System.Drawing.Point(362, 88);
            this.label_datum.Name = "label_datum";
            this.label_datum.Size = new System.Drawing.Size(47, 13);
            this.label_datum.TabIndex = 13;
            this.label_datum.Text = "Tecknat";
            // 
            // label_nivå
            // 
            this.label_nivå.AutoSize = true;
            this.label_nivå.Location = new System.Drawing.Point(362, 131);
            this.label_nivå.Name = "label_nivå";
            this.label_nivå.Size = new System.Drawing.Size(29, 13);
            this.label_nivå.TabIndex = 14;
            this.label_nivå.Text = "Nivå";
            // 
            // comboBox_Nivå
            // 
            this.comboBox_Nivå.FormattingEnabled = true;
            this.comboBox_Nivå.Items.AddRange(new object[] {
            "Brons",
            "Silver",
            "Guld"});
            this.comboBox_Nivå.Location = new System.Drawing.Point(419, 127);
            this.comboBox_Nivå.Name = "comboBox_Nivå";
            this.comboBox_Nivå.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Nivå.TabIndex = 16;
            // 
            // button_spara
            // 
            this.button_spara.Location = new System.Drawing.Point(346, 264);
            this.button_spara.Name = "button_spara";
            this.button_spara.Size = new System.Drawing.Size(75, 23);
            this.button_spara.TabIndex = 17;
            this.button_spara.Text = "Spara";
            this.button_spara.UseVisualStyleBackColor = true;
            this.button_spara.Click += new System.EventHandler(this.button_spara_Click);
            // 
            // button_radera
            // 
            this.button_radera.Location = new System.Drawing.Point(461, 263);
            this.button_radera.Name = "button_radera";
            this.button_radera.Size = new System.Drawing.Size(75, 23);
            this.button_radera.TabIndex = 18;
            this.button_radera.Text = "Radera";
            this.button_radera.UseVisualStyleBackColor = true;
            this.button_radera.Click += new System.EventHandler(this.button_radera_Click);
            // 
            // dateTimePicker_tecknat
            // 
            this.dateTimePicker_tecknat.Location = new System.Drawing.Point(419, 85);
            this.dateTimePicker_tecknat.Name = "dateTimePicker_tecknat";
            this.dateTimePicker_tecknat.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_tecknat.TabIndex = 19;
            // 
            // label_Period
            // 
            this.label_Period.AutoSize = true;
            this.label_Period.Location = new System.Drawing.Point(362, 169);
            this.label_Period.Name = "label_Period";
            this.label_Period.Size = new System.Drawing.Size(37, 13);
            this.label_Period.TabIndex = 20;
            this.label_Period.Text = "Period";
            // 
            // comboBox_Period
            // 
            this.comboBox_Period.FormattingEnabled = true;
            this.comboBox_Period.Items.AddRange(new object[] {
            "1 månad",
            "3 månader",
            "6 månader",
            "9 månader",
            "12 månader"});
            this.comboBox_Period.Location = new System.Drawing.Point(419, 169);
            this.comboBox_Period.Name = "comboBox_Period";
            this.comboBox_Period.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Period.TabIndex = 21;
            // 
            // NyttMedlemskap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 308);
            this.Controls.Add(this.comboBox_Period);
            this.Controls.Add(this.label_Period);
            this.Controls.Add(this.dateTimePicker_tecknat);
            this.Controls.Add(this.button_radera);
            this.Controls.Add(this.button_spara);
            this.Controls.Add(this.comboBox_Nivå);
            this.Controls.Add(this.label_nivå);
            this.Controls.Add(this.label_datum);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.label_telefonnummer);
            this.Controls.Add(this.label_ålder);
            this.Controls.Add(this.label_kön);
            this.Controls.Add(this.label_efternamn);
            this.Controls.Add(this.label_förnamn);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.txt_Telefon);
            this.Controls.Add(this.dateTimePicker_Födelsedag);
            this.Controls.Add(this.radioButton_kvinna);
            this.Controls.Add(this.radioButton_man);
            this.Controls.Add(this.txt_Efternamn);
            this.Controls.Add(this.txt_Förnamn);
            this.Name = "NyttMedlemskap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NyttMedlemskap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Förnamn;
        private System.Windows.Forms.TextBox txt_Efternamn;
        private System.Windows.Forms.RadioButton radioButton_man;
        private System.Windows.Forms.RadioButton radioButton_kvinna;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Födelsedag;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label label_förnamn;
        private System.Windows.Forms.Label label_efternamn;
        private System.Windows.Forms.Label label_kön;
        private System.Windows.Forms.Label label_ålder;
        private System.Windows.Forms.Label label_telefonnummer;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Label label_datum;
        private System.Windows.Forms.Label label_nivå;
        private System.Windows.Forms.ComboBox comboBox_Nivå;
        private System.Windows.Forms.Button button_spara;
        private System.Windows.Forms.Button button_radera;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tecknat;
        private System.Windows.Forms.Label label_Period;
        private System.Windows.Forms.ComboBox comboBox_Period;
    }
}