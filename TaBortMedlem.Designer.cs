
namespace sluttest
{
    partial class TaBortMedlem
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
            this.components = new System.ComponentModel.Container();
            this.label_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.button_radera = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_sök = new System.Windows.Forms.Button();
            this.medlemmarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.midDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.förnamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.könDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnumerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecknatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivåDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.födelsedagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemmarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(171, 74);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(51, 13);
            this.label_ID.TabIndex = 0;
            this.label_ID.Text = "Sätt in ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(281, 74);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(340, 20);
            this.txt_ID.TabIndex = 1;
            // 
            // button_radera
            // 
            this.button_radera.Location = new System.Drawing.Point(388, 126);
            this.button_radera.Name = "button_radera";
            this.button_radera.Size = new System.Drawing.Size(75, 23);
            this.button_radera.TabIndex = 2;
            this.button_radera.Text = "Radera";
            this.button_radera.UseVisualStyleBackColor = true;
            this.button_radera.Click += new System.EventHandler(this.button_radera_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.midDataGridViewTextBoxColumn,
            this.förnamnDataGridViewTextBoxColumn,
            this.efternamnDataGridViewTextBoxColumn,
            this.könDataGridViewTextBoxColumn,
            this.telefonnumerDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.tecknatDataGridViewTextBoxColumn,
            this.nivåDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn,
            this.födelsedagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medlemmarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(82, 181);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(650, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // button_sök
            // 
            this.button_sök.Location = new System.Drawing.Point(300, 125);
            this.button_sök.Name = "button_sök";
            this.button_sök.Size = new System.Drawing.Size(75, 23);
            this.button_sök.TabIndex = 4;
            this.button_sök.Text = "Sök";
            this.button_sök.UseVisualStyleBackColor = true;
            this.button_sök.Click += new System.EventHandler(this.button_sök_Click);
            // 
            // medlemmarBindingSource
            // 
            this.medlemmarBindingSource.DataSource = typeof(sluttest.Medlemmar);
            // 
            // midDataGridViewTextBoxColumn
            // 
            this.midDataGridViewTextBoxColumn.DataPropertyName = "Mid";
            this.midDataGridViewTextBoxColumn.HeaderText = "Mid";
            this.midDataGridViewTextBoxColumn.Name = "midDataGridViewTextBoxColumn";
            // 
            // förnamnDataGridViewTextBoxColumn
            // 
            this.förnamnDataGridViewTextBoxColumn.DataPropertyName = "Förnamn";
            this.förnamnDataGridViewTextBoxColumn.HeaderText = "Förnamn";
            this.förnamnDataGridViewTextBoxColumn.Name = "förnamnDataGridViewTextBoxColumn";
            // 
            // efternamnDataGridViewTextBoxColumn
            // 
            this.efternamnDataGridViewTextBoxColumn.DataPropertyName = "Efternamn";
            this.efternamnDataGridViewTextBoxColumn.HeaderText = "Efternamn";
            this.efternamnDataGridViewTextBoxColumn.Name = "efternamnDataGridViewTextBoxColumn";
            // 
            // könDataGridViewTextBoxColumn
            // 
            this.könDataGridViewTextBoxColumn.DataPropertyName = "Kön";
            this.könDataGridViewTextBoxColumn.HeaderText = "Kön";
            this.könDataGridViewTextBoxColumn.Name = "könDataGridViewTextBoxColumn";
            // 
            // telefonnumerDataGridViewTextBoxColumn
            // 
            this.telefonnumerDataGridViewTextBoxColumn.DataPropertyName = "Telefonnumer";
            this.telefonnumerDataGridViewTextBoxColumn.HeaderText = "Telefonnumer";
            this.telefonnumerDataGridViewTextBoxColumn.Name = "telefonnumerDataGridViewTextBoxColumn";
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // tecknatDataGridViewTextBoxColumn
            // 
            this.tecknatDataGridViewTextBoxColumn.DataPropertyName = "Tecknat";
            this.tecknatDataGridViewTextBoxColumn.HeaderText = "Tecknat";
            this.tecknatDataGridViewTextBoxColumn.Name = "tecknatDataGridViewTextBoxColumn";
            // 
            // nivåDataGridViewTextBoxColumn
            // 
            this.nivåDataGridViewTextBoxColumn.DataPropertyName = "Nivå";
            this.nivåDataGridViewTextBoxColumn.HeaderText = "Nivå";
            this.nivåDataGridViewTextBoxColumn.Name = "nivåDataGridViewTextBoxColumn";
            // 
            // periodDataGridViewTextBoxColumn
            // 
            this.periodDataGridViewTextBoxColumn.DataPropertyName = "Period";
            this.periodDataGridViewTextBoxColumn.HeaderText = "Period";
            this.periodDataGridViewTextBoxColumn.Name = "periodDataGridViewTextBoxColumn";
            // 
            // födelsedagDataGridViewTextBoxColumn
            // 
            this.födelsedagDataGridViewTextBoxColumn.DataPropertyName = "Födelsedag";
            this.födelsedagDataGridViewTextBoxColumn.HeaderText = "Födelsedag";
            this.födelsedagDataGridViewTextBoxColumn.Name = "födelsedagDataGridViewTextBoxColumn";
            // 
            // TaBortMedlem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_sök);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_radera);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label_ID);
            this.Name = "TaBortMedlem";
            this.Text = "TaBortMedlem";
            this.Load += new System.EventHandler(this.TaBortMedlem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemmarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Button button_radera;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_sök;
        private System.Windows.Forms.DataGridViewTextBoxColumn midDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn förnamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn könDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecknatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivåDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn födelsedagDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medlemmarBindingSource;
    }
}