
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NyttMedlemskap));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton_man = new System.Windows.Forms.RadioButton();
            this.radioButton_kvinna = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label_förnamn = new System.Windows.Forms.Label();
            this.label_efternamn = new System.Windows.Forms.Label();
            this.label_kön = new System.Windows.Forms.Label();
            this.label_ålder = new System.Windows.Forms.Label();
            this.label_telefonnummer = new System.Windows.Forms.Label();
            this.label_mail = new System.Windows.Forms.Label();
            this.label_datum = new System.Windows.Forms.Label();
            this.label_nivå = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_spara = new System.Windows.Forms.Button();
            this.button_avbryt = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 85);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(144, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(144, 205);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(419, 47);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 6;
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
            this.label_ålder.Size = new System.Drawing.Size(31, 13);
            this.label_ålder.TabIndex = 10;
            this.label_ålder.Text = "Ålder";
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(419, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // button_spara
            // 
            this.button_spara.Location = new System.Drawing.Point(346, 264);
            this.button_spara.Name = "button_spara";
            this.button_spara.Size = new System.Drawing.Size(75, 23);
            this.button_spara.TabIndex = 17;
            this.button_spara.Text = "Spara";
            this.button_spara.UseVisualStyleBackColor = true;
            // 
            // button_avbryt
            // 
            this.button_avbryt.Location = new System.Drawing.Point(461, 263);
            this.button_avbryt.Name = "button_avbryt";
            this.button_avbryt.Size = new System.Drawing.Size(75, 23);
            this.button_avbryt.TabIndex = 18;
            this.button_avbryt.Text = "Avbryt";
            this.button_avbryt.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(419, 85);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // NyttMedlemskap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 308);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.button_avbryt);
            this.Controls.Add(this.button_spara);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label_nivå);
            this.Controls.Add(this.label_datum);
            this.Controls.Add(this.label_mail);
            this.Controls.Add(this.label_telefonnummer);
            this.Controls.Add(this.label_ålder);
            this.Controls.Add(this.label_kön);
            this.Controls.Add(this.label_efternamn);
            this.Controls.Add(this.label_förnamn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.radioButton_kvinna);
            this.Controls.Add(this.radioButton_man);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "NyttMedlemskap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NyttMedlemskap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton_man;
        private System.Windows.Forms.RadioButton radioButton_kvinna;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label_förnamn;
        private System.Windows.Forms.Label label_efternamn;
        private System.Windows.Forms.Label label_kön;
        private System.Windows.Forms.Label label_ålder;
        private System.Windows.Forms.Label label_telefonnummer;
        private System.Windows.Forms.Label label_mail;
        private System.Windows.Forms.Label label_datum;
        private System.Windows.Forms.Label label_nivå;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_spara;
        private System.Windows.Forms.Button button_avbryt;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}