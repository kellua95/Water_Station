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
    public partial class StationExpenses : Form
    {

        double Total1;
        double TotalEx;

        public StationExpenses()
        {
            InitializeComponent();
        }

        private void butCups200_Click(object sender, EventArgs e)
        {
            txtProducts.Text = btnMaterial.Text;
            txtPrice.Text = "0.00";
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            if (txtProducts.Text == butCups.Text)
            {
                Total1 = double.Parse(laCups.Text);
                Total1 += double.Parse(txtPrice.Text);
                TotalEx += Total1;
                laTotal.Text = TotalEx.ToString();
                laCups.Text = Total1.ToString();
                Total1 = 0;
                
            }
            else if (txtProducts.Text == butGallon20.Text)
            {
                Total1 = double.Parse(laGallon20.Text);
                Total1 += double.Parse(txtPrice.Text); 
                TotalEx += Total1;
                laTotal.Text = TotalEx.ToString();
                laGallon20.Text = Total1.ToString();
                Total1 = 0;
            }
            else if (txtProducts.Text == butGallon10.Text)
            {
                Total1 = double.Parse(laGallon10.Text);
                Total1 += double.Parse(txtPrice.Text);
                TotalEx += Total1;
                laTotal.Text = TotalEx.ToString();
                laGallon10.Text = Total1.ToString();
                Total1 = 0;

            }
            else if (txtProducts.Text == butBottle20.Text)
            {
                Total1 = double.Parse(labottle20.Text);
                Total1 += double.Parse(txtPrice.Text);
                TotalEx += Total1;
                laTotal.Text = TotalEx.ToString();
                labottle20.Text = Total1.ToString();
                Total1 = 0;
            }
            else if (txtProducts.Text == butBottle10.Text)
            {
                Total1 = double.Parse(laBottle10.Text);
                Total1 += double.Parse(txtPrice.Text);
                TotalEx += Total1;
                laTotal.Text = TotalEx.ToString();
                laBottle10.Text = Total1.ToString();
                Total1 = 0;
            }
            else
            {
                Total1 = double.Parse(laExpenses.Text);
                Total1 += double.Parse(txtPrice.Text);
                TotalEx += Total1;
                laTotal.Text = TotalEx.ToString();
                laExpenses.Text = Total1.ToString();
                Total1 = 0;
            }
            

        }

        private void laMaterialExpenses_Click(object sender, EventArgs e)
        {

        }

        private void butCups_Click(object sender, EventArgs e)
        {
            txtProducts.Text = butCups.Text;
            txtPrice.Text = "1.15";
        }

        private void butBottle20_Click(object sender, EventArgs e)
        {
            txtProducts.Text = butBottle20.Text;
            txtPrice.Text = "4.00";
        }

        private void butBottle10_Click(object sender, EventArgs e)
        {
            txtProducts.Text = butBottle10.Text;
            txtPrice.Text = "2.50";
        }

        private void butGallon20_Click(object sender, EventArgs e)
        {
            txtProducts.Text = butGallon20.Text;
            txtPrice.Text = "3.00";
        }

        private void butGallon10_Click(object sender, EventArgs e)
        {
            txtProducts.Text = butGallon10.Text;
            txtPrice.Text = "2.00";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            new FormHome().Show();
        }
    }
}
