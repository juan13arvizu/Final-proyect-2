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
    public partial class Cites : Form
    {
        public Cites()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\im14.jpg");
            this.BackgroundImage = img;
        }

        private void Cites_Load(object sender, EventArgs e)
        {

        }
        private void refresh()
        
        {
            string Connect = "datasource=localhost;port=3306;username=root;password=;database=clinic";
            string query = "SELECT * FROM patient where Username = '" + PUserBoxtxt.Text + "'";
            MySqlConnection databaseConnection = new MySqlConnection(Connect);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;

            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {

                        Console.WriteLine(reader.GetString(0) + "-" + reader.GetString(1) + "-" + reader.GetString(2) + "-"+reader.GetString(3) + "-" + reader.GetString(4) +"-"+ reader.GetString(5) + "-" + reader.GetString(6) + "-" + reader.GetString(7));
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7) };
                        var listViewItem = new ListViewItem(row);
                        listView2.Items.Add(listViewItem);

                    }
                }
                else
                {
                    Console.WriteLine("No Data");
                }
                databaseConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LogoLabel_Click(object sender, EventArgs e)
        {

        }

        private void ReButton1_Click(object sender, EventArgs e)
        {
            refresh();
        }
    }
}
