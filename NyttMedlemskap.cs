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
    public partial class NyttMedlemskap : Form
    {
        public NyttMedlemskap()
        {
            InitializeComponent();
        }

        private void radioButton_kvinna_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_spara_Click(object sender, EventArgs e)
        {
            String förnamn = txt_Förnamn.Text;
            String efternamn = txt_Efternamn.Text;

            String kön = "";

            // kod för att kunna avgöra vilket kön som är ifylld
            bool ifylld = radioButton_man.Checked;

            if (ifylld)
            {
                kön = radioButton_man.Text;
            }
            else
            {
                kön = radioButton_kvinna.Text;
            }

            String födelsedag = dateTimePicker_Födelsedag.Text;
            int nummer = int.Parse(txt_Telefon.Text);
            String mail = txt_Mail.Text;
            String tecknat = dateTimePicker_tecknat.Text;
            String nivå = comboBox_Nivå.Text;
            String period = comboBox_Period.Text;


          String ConnectionString = "data source = localhost;DATABASE=gym;UID=Lasse;Password=Kagge; integrated security = True";
            MySqlConnection conn = new MySqlConnection(ConnectionString);
            conn.Open();

            //Sätta in den nya medlemmen i listan
            string sqlsats = $"insert into medlemmar(Förnamn, Efternamn, Kön, Födelsedag, Nummer, Mail, Tecknat, Nivå, Period) values ('{förnamn}','{efternamn}','{kön}','{födelsedag}',{nummer}, '{mail}', '{tecknat}', '{nivå}', '{period}')";
            MySqlCommand cmd = new MySqlCommand(sqlsats, conn);
            MySqlDataReader dataReader = cmd.ExecuteReader();
            conn.Close();
        }

        private void button_radera_Click(object sender, EventArgs e)
        {
            //Nollställer sidan
            txt_Förnamn.Clear();
            txt_Efternamn.Clear();
            radioButton_man.Checked = false;
            radioButton_kvinna.Checked = false;
            txt_Telefon.Clear();
            txt_Mail.Clear();
            comboBox_Nivå.ResetText();
            comboBox_Period.ResetText();
            dateTimePicker_Födelsedag.Value = DateTime.Now;
            dateTimePicker_tecknat.Value = DateTime.Now;
        }
    }
}
