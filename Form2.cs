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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HospitalDBDataSet.Department' table. You can move, or remove it, as needed.
            this.DepartmentTableAdapter.Fill(this.HospitalDBDataSet.Department);
            // TODO: This line of code loads data into the 'HospitalDBDataSet.Nurses' table. You can move, or remove it, as needed.
            this.NursesTableAdapter.Fill(this.HospitalDBDataSet.Nurses);
            // TODO: This line of code loads data into the 'HospitalDBDataSet.Doctors' table. You can move, or remove it, as needed.
            this.DoctorsTableAdapter.Fill(this.HospitalDBDataSet.Doctors);

            this.reportViewer1.RefreshReport();
        }
    }
}
