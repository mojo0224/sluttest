using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sluttest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Boolean b = true;
        //Kunna ändra om man vill ha menyn på sidan eller på toppen
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(b==true)
            {
                menuStrip1.Dock = DockStyle.Left;
                b = false;
                
            }
            else 
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
            }
        }

        private void nyMedlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Gör att en nytt fönster öppnas för att teckna ny medlem
            NyttMedlemskap nm = new NyttMedlemskap();
            nm.Show();
        }

        private void bokaPassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NyPassbokning nb = new NyPassbokning();
            nb.Show();
        }

        private void sökMedlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Medlem m = new Medlem();
            m.Show();
        }

        private void taBortMedlemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaBortMedlem tab = new TaBortMedlem();
            tab.Show();
        }

        private void stängAvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Detta kommer att stänga ner programmet. Vill du fortsätta?","Close", MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else 
            {
                MessageBox.Show("Händelse avbruten", "Händelse", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
