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
    public partial class Inloggning : Form
    {
        public Inloggning()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_användare.Text == "John" && txt_lösen.Text == "Molin")
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord", "fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
