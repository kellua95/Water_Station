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
using System.Data.OleDb;

namespace Water_Station_Final
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void butLogin_Click(object sender, EventArgs e)
        {
            foreach (EmployeeRow row in dB_EmployeeDataSet.Tables[0].Rows)
            {
                if (row[0].ToString().Equals(txtUsername.Text) &&
                    row[2].ToString().Equals(txtPassword.Text))
                {
                    this.Hide();
                    new FormHome().Show();
                    return;
                }
            }
            lainvalid.Visible = true;
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtPassword.UseSystemPasswordChar = true;
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
        }

        private void pictUnViwe_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            pictUnViwe.Visible = false;
            pictViwe.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            laTime.Text = DateTime.Now.ToLongTimeString();
            laDate.Text = DateTime.Now.ToLongDateString();
        }

        private void linkLaForgetPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormForget().Show();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            DialogResult drExit = MessageBox.Show("Are you sure?", "confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictViwe_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
            pictUnViwe.Visible = true;
            pictViwe.Visible = false;
        }

        private void FormLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";

            }
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void linkLaForgetPassword_MouseHover(object sender, EventArgs e)
        {
            linkLaForgetPassword.ForeColor = Color.Red;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'dB_EmployeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dB_EmployeeDataSet.Employee);




        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

            try
            {
                OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" +Application.StartupPath +"DB_Employee.mdb");
                OleDbCommand cmd = connection.CreateCommand();
                cmd.CommandText = "select * from Employee where Username = '" + txtUsername.Text + "' ";

                connection.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (txtPassword.Text.Equals(reader["Username"].ToString()) && txtUsername.Text.Equals(reader["Password"].ToString()))
                        {
                            new FormHome().Show();
                            this.Hide();
                            break;
                        }
                    }
                    connection.Close();
                }
            }
            catch
            {
               lainvalid.Visible = true;
                
            }
            
        }
    }
}


