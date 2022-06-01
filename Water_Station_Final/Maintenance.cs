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
    public partial class Maintenance : Form
    {
        public Maintenance()
        {
            InitializeComponent();
        }

        private void comBoxDescription_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxDescription.SelectedIndex == 0)
            {

                comBoxType.Items.Clear();
                comBoxType.Items.Add("(None)");
                comBoxType.SelectedIndex = 0;
            }
            else if (comBoxDescription.SelectedIndex == 1)
            {
                laParts.Text = "Type of Car Malfunction:";
                comBoxType.Items.Clear();
                comBoxType.Items.Add("Electrical falituer");
                comBoxType.Items.Add("Mechanical falituer");
                comBoxType.Items.Add("Accident");
                comBoxType.Items.Add("No Driver");
                comBoxType.SelectedIndex = 0;
            }
            else if (comBoxDescription.SelectedIndex == 2)
            {
                laParts.Text = "Type of Pipe Malfunction:";
                comBoxType.Items.Clear();
                comBoxType.Items.Add("Pipe failures");
                comBoxType.SelectedIndex = 0;
            }
            else if (comBoxDescription.SelectedIndex == 3)
            {
                laParts.Text = "Type of Electricity Malfunction:";
                comBoxType.Items.Clear();
                comBoxType.Items.Add("Local malfunction");
                comBoxType.Items.Add("Parent Company");
                comBoxType.SelectedIndex = 0;
            }
            else if (comBoxDescription.SelectedIndex == 4)
            {
                laParts.Text = "Type of Water Malfunction:";
                comBoxType.Items.Clear();
                comBoxType.Items.Add("No Water");
                comBoxType.SelectedIndex = 0;
            }
            else if (comBoxDescription.SelectedIndex == 5)
            {
                laParts.Text = "Type of Filters Malfunction:";
                comBoxType.Items.Clear();
                comBoxType.Items.Add("Malfunction in the filters");
                comBoxType.SelectedIndex = 0;
            }
            else
            {
                laParts.Text = "Type of Emergency:";
                comBoxType.Items.Clear();
                comBoxType.Items.Add("Medical Emergency");
                comBoxType.Items.Add("Mechanical Emergency");
                comBoxType.SelectedIndex = 0;
            }

        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            comBoxDescription.SelectedIndex = 0;
        }

        private void comBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comBoxType.SelectedItem.ToString() == "(None)")
            {
                laDescrbtion.Text = "Welcom in maintenance window \numFilling20ltr\numFilling20ltr" +
                    "    You can always call the managers.\numFilling20ltr\numFilling20ltr" +
                    "    Mahmod : 0777373355\numFilling20ltr\numFilling20ltr" +
                    "    Ayham   : 0772752233";
            }
            else if (comBoxDescription.SelectedIndex == 1 && comBoxType.SelectedIndex == 0)
            {
                laDescrbtion.Text = "you can call the car maintenance specialist.\numFilling20ltr\numFilling20ltr" +
                    "    Fadi    : 0784531993\numFilling20ltr\numFilling20ltr" +
                    "You can always call the managers.\numFilling20ltr\numFilling20ltr" +
                    "    Mahmod : 0777373355\numFilling20ltr\numFilling20ltr" +
                    "    Ayham   : 0772752233";
            }
            else if (comBoxDescription.SelectedIndex == 1 && comBoxType.SelectedIndex == 1)
            {
                laDescrbtion.Text = "you can call the car maintenance specialist.\numFilling20ltr\numFilling20ltr" +
                    "    Feras   : 0794561983\numFilling20ltr\numFilling20ltr" +
                    "You can always call the managers.\numFilling20ltr\numFilling20ltr" +
                    "    Mahmod : 0777373355\numFilling20ltr\numFilling20ltr" +
                    "    Ayham   : 0772752233";
            }
            else if (comBoxDescription.SelectedIndex == 1 && comBoxType.SelectedIndex == 2)
            {
                laDescrbtion.Text = "you should call the traffic police.\numFilling20ltr\numFilling20ltr" +
                    "    police   : 911\numFilling20ltr\numFilling20ltr" +
                    "You can always call the managers.\numFilling20ltr\numFilling20ltr" +
                    "    Mahmod : 0777373355\numFilling20ltr\numFilling20ltr" +
                    "    Ayham   : 0772752233";
            }
            else if (comBoxDescription.SelectedIndex == 1 && comBoxType.SelectedIndex == 3)
            {
                laDescrbtion.Text = "you can call the replacement drivers.\numFilling20ltr\numFilling20ltr" +
                    "    yousef   : 0794765783\numFilling20ltr\numFilling20ltr" +
                    "    Adham    : 0774543769\numFilling20ltr\numFilling20ltr" +
                    "You can always call the managers.\numFilling20ltr\numFilling20ltr" +
                    "    Mahmod : 0777373355\numFilling20ltr\numFilling20ltr" +
                    "    Ayham   : 0772752233";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            new FormHome().Show();
        }
    }
}
