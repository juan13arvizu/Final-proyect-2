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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\im1.jpg");
            this.BackgroundImage = img;
        }
        private void Join()
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=clinic";
            string query = "SELECT * FROM admin where Username1='" + UserBoxtxt1.Text + "'AND Password1=SHA1('" + PswBoxtxt1.Text + "')";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader bibliophile;

            try
            {

                databaseConnection.Open();
                bibliophile = commandDatabase.ExecuteReader();
                if (bibliophile.Read())
                {  
                    MessageBox.Show("ACCESS ALLOWED");
                     AdminDB registered = new AdminDB();
                     registered.Show();
                }
                else
                {
                    MessageBox.Show("Access denied /n Username/Password, MISTAKEN."); 
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoginBotton1_Click(object sender, EventArgs e)
        {
            Join();

        }
        private void PswBoxtxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserBoxtxt1_TextChanged(object sender, EventArgs e)
        {

        }   
        private void PatientButton_Click(object sender, EventArgs e)
        {
            Patient registered = new Patient();
            registered.Show();

        }

        private void SpecialistButton_Click(object sender, EventArgs e)
        {
            Specialist registered = new Specialist();
            registered.Show();

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}

