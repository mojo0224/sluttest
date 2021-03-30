namespace sluttest
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label_namn = new System.Windows.Forms.Label();
            this.label_roll = new System.Windows.Forms.Label();
            this.label_medlemskapsnivå = new System.Windows.Forms.Label();
            this.label_ålder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(112, 44);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 290);
            this.listBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(384, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(384, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(384, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(384, 89);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            // 
            // label_namn
            // 
            this.label_namn.AutoSize = true;
            this.label_namn.Location = new System.Drawing.Point(517, 44);
            this.label_namn.Name = "label_namn";
            this.label_namn.Size = new System.Drawing.Size(35, 13);
            this.label_namn.TabIndex = 6;
            this.label_namn.Text = "Namn";
            // 
            // label_roll
            // 
            this.label_roll.AutoSize = true;
            this.label_roll.Location = new System.Drawing.Point(517, 186);
            this.label_roll.Name = "label_roll";
            this.label_roll.Size = new System.Drawing.Size(25, 13);
            this.label_roll.TabIndex = 7;
            this.label_roll.Text = "Roll";
            // 
            // label_medlemskapsnivå
            // 
            this.label_medlemskapsnivå.AutoSize = true;
            this.label_medlemskapsnivå.Location = new System.Drawing.Point(517, 141);
            this.label_medlemskapsnivå.Name = "label_medlemskapsnivå";
            this.label_medlemskapsnivå.Size = new System.Drawing.Size(92, 13);
            this.label_medlemskapsnivå.TabIndex = 8;
            this.label_medlemskapsnivå.Text = "Medlemskapsnivå";
            // 
            // label_ålder
            // 
            this.label_ålder.AutoSize = true;
            this.label_ålder.Location = new System.Drawing.Point(517, 92);
            this.label_ålder.Name = "label_ålder";
            this.label_ålder.Size = new System.Drawing.Size(31, 13);
            this.label_ålder.TabIndex = 9;
            this.label_ålder.Text = "Ålder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_ålder);
            this.Controls.Add(this.label_medlemskapsnivå);
            this.Controls.Add(this.label_roll);
            this.Controls.Add(this.label_namn);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label_namn;
        private System.Windows.Forms.Label label_roll;
        private System.Windows.Forms.Label label_medlemskapsnivå;
        private System.Windows.Forms.Label label_ålder;
    }
}

