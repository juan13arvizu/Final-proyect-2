using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Rehabilitation_Clinic_JIZ
{
    public partial class Appointment : Form
    {
        public Appointment()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\im13.jpg");
            this.BackgroundImage = img;
        }

        private void REGISTERAPP()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=clinic";
            string query = "INSERT INTO appointment (`Username`, `Date`, `Area`, `Hour`, `Specialist`) VALUES ('" + UserBoxtxt.Text + "','" + DateBoxtxt.Text + "','" + AreaBoxtxt.Text + "','" + HourBoxtxt.Text + "','" + DocBoxtxt.Text + "')";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {
                databaseConnection.Open();
                MySqlDataReader bibliophile = commandDatabase.ExecuteReader();
                MessageBox.Show("Data saved");
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DateBoxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserBoxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AreaBoxtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void HourBoxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void DocBoxtxt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            REGISTERAPP();
        }
    }
}
