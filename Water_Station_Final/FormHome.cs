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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
            ResizeMenu();
        }

        private void butMenu_Click(object sender, EventArgs e)
        {
            ResizeMenu();
        }

        private void ResizeMenu()
        {
            if (this.panelmenu.Width >= 200)
            {
                panelmenu.Width = 100;
                lacom.Visible = false;
                lawat.Visible = false;
                butMenu.Dock = DockStyle.Top;
                butMenu.IconColor = Color.White;
                ibutExpenses.IconColor = Color.White;
                ibutLogout.IconColor = Color.White;
                ibutMantinans.IconColor = Color.White;
                ibutPOS.IconColor = Color.White;
                ibutReports.IconColor = Color.White;
                ibutRigester.IconColor = Color.White;

                foreach (Button mb in panelmenu.Controls.OfType<Button>())
                {
                    mb.Text = "";
                    mb.ImageAlign = ContentAlignment.MiddleCenter;
                    mb.Padding = new Padding(0);
                    
                }
            }
            else
            {

                panelmenu.Width = 250;
                lacom.Visible = true;
                lawat.Visible = true;
                butMenu.Dock = DockStyle.None;
                butMenu.IconColor = Color.Black;
                ibutExpenses.IconColor = Color.Black;
                ibutLogout.IconColor = Color.Black;
                ibutMantinans.IconColor = Color.Black;
                ibutPOS.IconColor = Color.Black;
                ibutReports.IconColor = Color.Black;
                ibutRigester.IconColor = Color.Black;

                foreach (Button mb in panelmenu.Controls.OfType<Button>())
                {
                    mb.Text = mb.Tag.ToString();
                    mb.ImageAlign = ContentAlignment.MiddleLeft;
                    mb.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Close();
            new Rigester().Show();
        }

        private void ibutPOS_Click(object sender, EventArgs e)
        {
            Close();
            new POS().Show();
        }

        private void ibutExpenses_Click(object sender, EventArgs e)
        {
            Close();
            new StationExpenses().Show();
        }

        private void ibutMantinans_Click(object sender, EventArgs e)
        {
            Close();
            new Maintenance().Show();
        }

        private void ibutReports_Click(object sender, EventArgs e)
        {
            Close();
            new Reports().Show();
        }

        private void ibutLogout_Click(object sender, EventArgs e)
        {
            DialogResult Dr = MessageBox.Show("Are you sure to log out ??", "Confirm Log Out !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Dr == DialogResult.Yes)
            {
                Close();
                new FormLogin().Show();
            }
        }



        private void button5_Click(object sender, EventArgs e)
        {
            Close();
            new POS().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            new Rigester().Show();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            new StationExpenses().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            new Maintenance().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
            new Reports().Show();
        }

        private void laTime_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            laTime.Text = DateTime.Now.ToLongTimeString();
            laDate.Text = DateTime.Now.ToLongDateString();
        }
    }
}
