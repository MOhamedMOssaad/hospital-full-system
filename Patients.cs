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
    public partial class Patients : Form
    {
        Controller controllerObj;

        public Patients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctors F = new Doctors();
            F.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nurses F = new Nurses();
            F.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (PName.Text == "" || PId.Text == "" || PAd.Text == "" || PTel.Text == "" || PEm.Text == "" || comboBox1.SelectedIndex == -1
                || comboBox2.SelectedIndex == -1|| comboBox3.SelectedIndex == -1)
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int NId = Int32.Parse(comboBox1.Text);
                int DrId = Int32.Parse(comboBox2.Text);
                int RoomNo = Int32.Parse(comboBox3.Text);

                int r =  controllerObj.InsertPatient(Int32.Parse(PId.Text.ToString()),
                                                    PName.Text.ToString(),
                                                    PAd.Text.ToString(),
                                                    PEm.Text.ToString(),
                                                    NId,
                                                    DrId,
                                                    RoomNo,
                                                    PTel.Text.ToString());
                if (r == 0)
                {
                    MessageBox.Show("The insertion of a new Doctor failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectNUID();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string text = dt.Rows[i]["NurseId"].ToString();
                this.comboBox1.Items.Add(text);
            }
            dt = controllerObj.SelectDRID();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string text = dt.Rows[i]["DoctorId"].ToString();
                this.comboBox2.Items.Add(text);
            }
            dt = controllerObj.SelectRoomNo();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string text = dt.Rows[i]["RoomNo"].ToString();
                this.comboBox3.Items.Add(text);
            }
            dt = controllerObj.SelectPID();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string text = dt.Rows[i]["PatientId"].ToString();
                this.comboBox5.Items.Add(text);
                this.comboBox4.Items.Add(text);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectPatient();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectMedicine();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (MName.Text == "" || MId.Text == ""|| MPrice.Text==""||comboBox5.SelectedIndex==-1)
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int PatId = Int32.Parse(comboBox5.Text);
                int r = controllerObj.InsertMed(MName.Text.ToString(), Int32.Parse(MId.Text.ToString()), Int32.Parse(MPrice.Text.ToString()),PatId);
                if (r == 0)
                {
                    MessageBox.Show("The insertion of a new medicine failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (comboBox4.SelectedIndex == -1)
            {
                MessageBox.Show("Please, insert value");
            }
            else
            {
                int r = controllerObj.DeletePat(Int32.Parse(comboBox4.Text));
                if (r == 0)
                {
                    MessageBox.Show("Removal failed");
                }
                else
                {
                    MessageBox.Show("Removed successfully!");
                }
            }
        }

        private void PId_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            
        }

        private void PName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void MPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
 }
 

