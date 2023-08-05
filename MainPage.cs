using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalDB
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Patients F = new Patients();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doctors F = new Doctors();
            F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nurses F = new Nurses();
            F.Show();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

        }
    }
}
