
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
            this.components = new System.ComponentModel.Container();
            this.label_id = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button_sök = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medlemmarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Mid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.förnamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efternamnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.könDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.födelsedagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonnumerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecknatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nivåDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_rensa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemmarBindingSource)).BeginInit();
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
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mid,
            this.förnamnDataGridViewTextBoxColumn,
            this.efternamnDataGridViewTextBoxColumn,
            this.könDataGridViewTextBoxColumn,
            this.födelsedagDataGridViewTextBoxColumn,
            this.telefonnumerDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.tecknatDataGridViewTextBoxColumn,
            this.nivåDataGridViewTextBoxColumn,
            this.periodDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medlemmarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 147);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // medlemmarBindingSource
            // 
            this.medlemmarBindingSource.DataSource = typeof(sluttest.Medlemmar);
            // 
            // Mid
            // 
            this.Mid.DataPropertyName = "Mid";
            this.Mid.HeaderText = "ID";
            this.Mid.Name = "Mid";
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
            // födelsedagDataGridViewTextBoxColumn
            // 
            this.födelsedagDataGridViewTextBoxColumn.DataPropertyName = "Födelsedag";
            this.födelsedagDataGridViewTextBoxColumn.HeaderText = "Födelsedag";
            this.födelsedagDataGridViewTextBoxColumn.Name = "födelsedagDataGridViewTextBoxColumn";
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
            // button_rensa
            // 
            this.button_rensa.Location = new System.Drawing.Point(418, 80);
            this.button_rensa.Name = "button_rensa";
            this.button_rensa.Size = new System.Drawing.Size(75, 23);
            this.button_rensa.TabIndex = 4;
            this.button_rensa.Text = "Rensa";
            this.button_rensa.UseVisualStyleBackColor = true;
            this.button_rensa.Click += new System.EventHandler(this.button_rensa_Click);
            // 
            // Medlem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 309);
            this.Controls.Add(this.button_rensa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_sök);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label_id);
            this.Name = "Medlem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Medlem";
            this.Load += new System.EventHandler(this.Medlem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medlemmarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button_sök;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource medlemmarBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mid;
        private System.Windows.Forms.DataGridViewTextBoxColumn förnamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efternamnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn könDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn födelsedagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonnumerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecknatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nivåDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_rensa;
    }
}