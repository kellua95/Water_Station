using static Water_Station_Final.FinalReportsDBDataSet;
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
    public partial class Reports : Form
    {

        double Total_sales;
        double Total_profit;
        public Reports()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storsDBDataSet.Stors' table. You can move, or remove it, as needed.
            this.storsTableAdapter.Fill(this.storsDBDataSet.Stors);
            // TODO: This line of code loads data into the 'finalReportsDBDataSet.Reports' table. You can move, or remove it, as needed.
            this.reportsTableAdapter.Fill(this.finalReportsDBDataSet.Reports);
            
            foreach(ReportsRow row in finalReportsDBDataSet.Tables[0].Rows)
            {
                Total_sales += double.Parse(row[4].ToString());
            }
            Total_profit = Total_sales * 0.15;
            if (Total_sales <= 5)
            {
                laRed.Visible = true;
                laGreen.Visible = false;
                laOrange.Visible = false;
                laYellow.Visible = false;
            }
            else if (5  < Total_sales && Total_sales < 25)
            {
                laRed.Visible = false;
                laGreen.Visible = false;
                laOrange.Visible = true;
                laYellow.Visible = false;
            }
            else if (25 < Total_sales && Total_sales < 50)
            {
                laRed.Visible = false;
                laGreen.Visible = false;
                laOrange.Visible = false;
                laYellow.Visible = true;
            }
            else
            {
                laRed.Visible = false;
                laGreen.Visible = true;
                laOrange.Visible = false;
                laYellow.Visible = false;
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CombReports.SelectedIndex == 0)
            {
                laResult.Text = Total_sales.ToString() + " Jordanian dinar";
            }
            else
            {
                laResult.Text = Total_profit.ToString() + " Jordanian dinar";
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            storsDataGridView.Visible = false;
            button3.Visible = true;
            dataGridView1.Visible = true;
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            new FormHome().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            storsDataGridView.Visible = true;
            dataGridView1.Visible = false;
            button1.Visible = true;
            button3.Visible = false;
        }
    }
}
