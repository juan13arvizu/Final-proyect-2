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
    public partial class AdminDB : Form
    {
        public AdminDB()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\im14.jpg");
            this.BackgroundImage = img;
        }
            private void database()
            {
             string connection = "datasource=localhost;port=3306;username=root;password=;database=clinic";
            string query = "SELECT INTO admin where Username='" + AUserBoxtxt.Text + "'AND Password ='" + APswBoxtxt.Text + "'"; ;
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conectionDatabase.Open();
                reader = databaseCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Console.WriteLine(reader.GetString(0) + "-" + reader.GetString(1) + "-" + reader.GetString(2) + "-" + reader.GetString(3) + "-" + reader.GetString(4) + "-" + reader.GetString(5) + "-" + reader.GetString(6) + "-" + reader.GetString(7));
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);

                    }
                }
                else
                {
                    Console.WriteLine("No Data");
                }
                conectionDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Botonx()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=clinic";
            string query = "SELECT INTO specialist where Username='" + SUserBoxtxt.Text + "'AND Password = '" + SPswBoxtxt.Text + "'"; 
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conectionDatabase.Open();
                reader = databaseCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Console.WriteLine(reader.GetString(0) + "-" + reader.GetString(1) + "-" + reader.GetString(2) + "-" + reader.GetString(3) + "-" + reader.GetString(4) + "-" + reader.GetString(5) + "-" + reader.GetString(6) + "-" + reader.GetString(7));
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);

                    }
                }
                else
                {
                    Console.WriteLine("No Data");
                }
                conectionDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Botonf()
        {
            string connection = "datasource=localhost;port=3306;username=root;password=;database=clinic";
            string query = "SELECT INTO patient where Username='" + PUserBoxtxt.Text + "'AND Password = '" + PPswBoxtxt.Text + "'"; 
            MySqlConnection conectionDatabase = new MySqlConnection(connection);
            MySqlCommand databaseCommand = new MySqlCommand(query, conectionDatabase);
            databaseCommand.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                conectionDatabase.Open();
                reader = databaseCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Console.WriteLine(reader.GetString(0) + "-" + reader.GetString(1) + "-" + reader.GetString(2) + "-" + reader.GetString(3) + "-" + reader.GetString(4) + "-" + reader.GetString(5) + "-" + reader.GetString(6) + "-" + reader.GetString(7));
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);

                    }
                }
                else
                {
                    Console.WriteLine("No Data");
                }
                conectionDatabase.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void AdminDB_Load(object sender, EventArgs e)
        {

           
        }

        private void listViewAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void APswBoxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void AUserBoxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SUserBoxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void SPswBoxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PUserBoxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void PPswBoxtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MoButton1_Click(object sender, EventArgs e)
        {

        }

        private void DeButton1_Click(object sender, EventArgs e)
        {

        }

        private void SaButton1_Click(object sender, EventArgs e)
        {

        }

        private void MoButton2_Click(object sender, EventArgs e)
        {

        }

        private void DeButton2_Click(object sender, EventArgs e)
        {

        }

        private void SaButton2_Click(object sender, EventArgs e)
        {

        }

        private void MoButton3_Click(object sender, EventArgs e)
        {

        }

        private void DeButton3_Click(object sender, EventArgs e)
        {

        }

        private void SaButton3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            database();
        }

        private void ShBotton2_Click(object sender, EventArgs e)
        {
            Botonx();
        }

        private void ShBotton3_Click(object sender, EventArgs e)
        {
            Botonf();
        }
    }
}
