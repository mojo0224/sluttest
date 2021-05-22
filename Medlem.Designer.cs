
namespace sluttest
{
    partial class Medlem
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
            this.label_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button_sök = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(90, 39);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(46, 13);
            this.label_id.TabIndex = 0;
            this.label_id.Text = "Enter ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(224, 39);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(305, 20);
            this.txt_id.TabIndex = 1;
            // 
            // button_sök
            // 
            this.button_sök.Location = new System.Drawing.Point(296, 80);
            this.button_sök.Name = "button_sök";
            this.button_sök.Size = new System.Drawing.Size(75, 23);
            this.button_sök.TabIndex = 2;
            this.button_sök.Text = "Sök";
            this.button_sök.UseVisualStyleBackColor = true;
            this.button_sök.Click += new System.EventHandler(this.button_sök_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // Medlem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 309);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_sök);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label_id);
            this.Name = "Medlem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medlem";
            this.Load += new System.EventHandler(this.Medlem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button_sök;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}