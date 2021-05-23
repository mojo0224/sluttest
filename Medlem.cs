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
using MySql.Data.MySqlClient;

namespace sluttest
{
    public partial class Medlem : Form
    {
        List<Medlemmar> minamedlemmar = new List<Medlemmar>();
        List<Medlemmar> enmedlem = new List<Medlemmar>();
        public Medlem()
        {
            InitializeComponent();
 
        }

        private void button_sök_Click(object sender, EventArgs e)
        {

            if (txt_id.Text != "")
            {
                enmedlem.Clear();
                int id = int.Parse(txt_id.Text);
                bool hittat = false;
                foreach(Medlemmar md in minamedlemmar)
                {
                    if(md.Mid==id)
                    {
                        hittat = true;
                        enmedlem.Add(md);
                        break;
                    }
                    
                }
                if (hittat)
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = enmedlem;
                }


              
            }
            else 
            {
                MessageBox.Show("Slå in ID!", "Meddelande",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void Medlem_Load(object sender, EventArgs e)
        {
            String ConnectionString = "data source = localhost;DATABASE=gym;UID=Lasse;Password=Kagge; integrated security = True";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();


            string sqlsats = $"select * from medlemmar";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                List<string> kolumner = new List<string>();

                for(int i = 0; i < dataReader.FieldCount;i++)
                {
                    if (!dataReader.IsDBNull(i))
                    {
                        kolumner.Add(dataReader.GetString(i));
                    }
                    else
                    {
                        kolumner.Add("NULL");
                    }
                }
                Medlemmar md = new Medlemmar(int.Parse(kolumner[0]), kolumner[1], kolumner[2], kolumner[3], kolumner[4], int.Parse(kolumner[5]), kolumner[6], kolumner[7], kolumner[8], kolumner[9]);
                minamedlemmar.Add(md);
            }
            conn.Close();
            dataGridView1.DataSource = minamedlemmar;
        }

        private void button_rensa_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = minamedlemmar;
        }
    }
}
