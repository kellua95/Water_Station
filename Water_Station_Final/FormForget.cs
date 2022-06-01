using static Water_Station_Final.DB_EmployeeDataSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Water_Station_Final
{
    public partial class FormForget : Form
    {
        public FormForget()
        {
            InitializeComponent();
        }

        private void butShowPass_Click(object sender, EventArgs e)
        {
            
            foreach (EmployeeRow row in dB_EmployeeDataSet.Tables[0].Rows)
            {
                if (row[0].Equals(txtUsername.Text) && row[1].Equals(txtEmail.Text))
                {
                    MessageBox.Show("your Password is: " + row[2].ToString(), "Password");
                    return;
                }
            }
            lainvalid.Visible = true;
            
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
            }
        }

        private void txtEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
        }

        private void FormForget_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
            }
        }

        private void linkLaBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }

        private void FormForget_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EmployeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dB_EmployeeDataSet.Employee);
            

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            new FormLogin().Show();
        }
    }
}
