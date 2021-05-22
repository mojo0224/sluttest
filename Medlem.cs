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
    public partial class Medlem : Form
    {
        public Medlem()
        {
            InitializeComponent();
        }

        private void button_sök_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = localhost;DATABASE=SQL;UID=Lasse;Password=Kagge; database = gym; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NyMedlem where MID = " + txt_id.Text + "";

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];
            }
            else 
            {
                MessageBox.Show("Slå in ID!", "Meddelande",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void Medlem_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = localhost;DATABASE=SQL;UID=Lasse;Password=Kagge; database = gym; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NyMedlem";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];
        }
    }
}
