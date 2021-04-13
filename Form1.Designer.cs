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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nyMedlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bokaPassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sökMedlemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utloggningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stängAvToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.nyMedlemToolStripMenuItem,
            this.bokaPassToolStripMenuItem,
            this.sökMedlemToolStripMenuItem,
            this.utloggningToolStripMenuItem,
            this.stängAvToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(27, 20);
            this.toolStripMenuItem1.Text = ">";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // nyMedlemToolStripMenuItem
            // 
            this.nyMedlemToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.nyMedlemToolStripMenuItem.Name = "nyMedlemToolStripMenuItem";
            this.nyMedlemToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.nyMedlemToolStripMenuItem.Text = "Ny Medlem";
            // 
            // bokaPassToolStripMenuItem
            // 
            this.bokaPassToolStripMenuItem.Name = "bokaPassToolStripMenuItem";
            this.bokaPassToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.bokaPassToolStripMenuItem.Text = "Boka Pass";
            // 
            // sökMedlemToolStripMenuItem
            // 
            this.sökMedlemToolStripMenuItem.Name = "sökMedlemToolStripMenuItem";
            this.sökMedlemToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.sökMedlemToolStripMenuItem.Text = "Sök Medlem";
            // 
            // utloggningToolStripMenuItem
            // 
            this.utloggningToolStripMenuItem.Name = "utloggningToolStripMenuItem";
            this.utloggningToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.utloggningToolStripMenuItem.Text = "Utloggning";
            // 
            // stängAvToolStripMenuItem
            // 
            this.stängAvToolStripMenuItem.Name = "stängAvToolStripMenuItem";
            this.stängAvToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.stängAvToolStripMenuItem.Text = "Stäng Av";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nyMedlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bokaPassToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sökMedlemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utloggningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stängAvToolStripMenuItem;
    }
}

