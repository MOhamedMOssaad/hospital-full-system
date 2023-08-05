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
    public partial class Nurses : Form
    {
        Controller controllerObj;
        public Nurses()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NName.Text == "" || NId.Text == "" || NAd.Text == "" || NTel.Text == "" || NEm.Text == "" )
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int r = controllerObj.InsertNur(Int32.Parse(NId.Text.ToString()), NTel.Text.ToString(), NEm.Text.ToString(), NAd.Text.ToString(),
                    NName.Text.ToString());
                if (r == 0)
                {
                    MessageBox.Show("The insertion of a new Nurse failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }
        }

        private void Nurses_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt = controllerObj.SelectNUID();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string text = dt.Rows[i]["NurseId"].ToString();
                this.comboBox2.Items.Add(text);
                this.comboBox1.Items.Add(text);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RNum.Text == "" || !(radioButton1.Checked || radioButton2.Checked) ||  RPrice.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                string type = "Single";
                if (radioButton2.Checked)
                    type = "Double";

                int r = controllerObj.InsertRoom(Int32.Parse(RPrice.Text.ToString()), type, Int32.Parse(RNum.Text.ToString()));
                if (r == 0)
                {
                    MessageBox.Show("The insertion of a new Nurse failed");
                }
                else
                {
                    MessageBox.Show("The row is inserted successfully!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectNurse();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataTable dt = controllerObj.SelectRoom();
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex==-1  || NNAd.Text == "" || NNTel.Text == "" || NNEm.Text == "")
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                int ID = Int32.Parse(comboBox2.Text);
                int r = controllerObj.UpdateNurse( NNTel.Text.ToString(), NNEm.Text.ToString(), NNAd.Text.ToString(), ID);
                if (r == 0)
                {
                    MessageBox.Show("The update failed");
                }
                else
                {
                    MessageBox.Show("The update done!");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Please, insert value");
            }
            else
            {
                int r = controllerObj.DeleteNur(Int32.Parse(comboBox1.Text));
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

        private void NNEm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NNTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void NNAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NNTel_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void NNTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
  }
 

