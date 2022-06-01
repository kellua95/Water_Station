using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Water_Station_Final.DB_EmployeeDataSet;
using System.Data.OleDb;

namespace Water_Station_Final
{
    public partial class Rigester : Form
    {
        string admin = "Fales";
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\abods\Desktop\Final_project\DB_Employee.mdb");
        public Rigester()
        {
            InitializeComponent();
        }

        private void Rigester_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_EmployeeDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.dB_EmployeeDataSet.Employee);

            
            
            


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void Is_Admin()
        {
            if (checkBox1.Checked)
            {
                admin = "True";
            }
            else
            {
                admin = "Fales";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Is_Admin();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandText = "INSERT INTO Employee (Username, Email, [Password], Is_Admin) VALUES ('" +txtUsername.Text + "' , '" + txtEmail.Text +
                "' , '" + txtPassword.Text + "' , '" + admin +  "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Sccessful add employee " + txtUsername.Text + " to Database" , "Sccessful");
        }

        private void butBack_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
            new FormHome().Show();
        }
    }
}
