using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Water_Station_Final.StorsDBDataSet;



namespace Water_Station_Final
{
    public partial class Cash : Form
    {

        Products pro =  new Products();

        public Cash()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Cash_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storsDBDataSet.Stors' table. You can move, or remove it, as needed.
            this.storsTableAdapter.Fill(this.storsDBDataSet.Stors);
            foreach (StorsRow row in storsDBDataSet.Tables[0].Rows)
            {
                if (row[0].ToString().Equals("21"))
                {
                     textBox1.Text = row[2].ToString();
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox3.Text = (double.Parse(textBox2.Text) - double.Parse(textBox1.Text)).ToString();
            }
            catch
            {
                textBox3.Text = "error";
            }
        }

        private void btnsell_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
