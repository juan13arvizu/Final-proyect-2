using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehabilitation_Clinic_JIZ
{
    public partial class MainAccess : Form
    {
        public MainAccess()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\im8.jpg");
            this.BackgroundImage = img;
        }

        private void MainAccess_Load(object sender, EventArgs e)
        {

        }

        private void SpecialistBotton_Click(object sender, EventArgs e)
        {
            Specialist registered = new Specialist();
            registered.Show();
        }

        private void AdminBotton_Click(object sender, EventArgs e)
        {
            Admin registered = new Admin();
            registered.Show();
        }

        private void PatientsBotton_Click(object sender, EventArgs e)
        {
            Patient registered = new Patient();
            registered.Show();
        }
    }
}
 