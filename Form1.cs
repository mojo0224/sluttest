using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
