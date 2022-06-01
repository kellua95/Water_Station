using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Water_Station_Final.FinalReportsDBDataSet;
using static Water_Station_Final.StorsDBDataSet;

using System.Data.OleDb;

namespace Water_Station_Final
{


    public partial class POS : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ Application.StartupPath +"FinalReportsDB.mdb");
        OleDbConnection co1 = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ Application.StartupPath +"StorsDB.mdb");

        Products pro = new Products();
        double price = 0;
        string Bill = "";

        public POS()
        {
            InitializeComponent();
        }

        private void btnFilling20Ltr_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.numFilling20ltr += double.Parse(txtNum.Text);
            double pricF20 = 0.5;
            laShow.Text = txtNum.Text + " X " + btnFilling20Ltr.Text;
            txtPrice.Text = (Num * pricF20).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
            pro.pricF20 = double.Parse(txtPrice.Text);
        }

        private void POS_Load(object sender, EventArgs e)
        {
            
        }

        private void ButSell_Click(object sender, EventArgs e)
        {
            pro.prevnumFilling20ltr = pro.numFilling20ltr;
            pro.prevnumFilling10ltr = pro.numFilling10ltr;

            pro.PrevnumCups200 = pro.numCups200;
            pro.prevnumCups250 = pro.numCups250;

            pro.prevnumPackage250 = pro.numPackage250;
            pro.prevnumPackage330 = pro.numPackage330;
            pro.prevnumPackage600 = pro.numPackage600;
            pro.prevnumPackage1500 = pro.numPackage1500;

            pro.prevnumAQUADOVA600 = pro.numAQUADOVA600;
            pro.prevnumAQUADOVA1500 = pro.numAQUADOVA1500;

            pro.prevcoupon = pro.coupon;
            pro.prevDisponser = pro.Disponser;
            pro.prevGallon10 = pro.Gallon10;
            pro.prevGallon20 = pro.Gallon20;
            pro.prevBottleJ10 = pro.BottleJ10;
            pro.prevBottleJ20 = pro.BottleJ20;
            pro.prevBottleS10 = pro.BottleS10;
            pro.prevBottleS20 = pro.BottleS20;
            pro.prevFfc = pro.Ffc;
            pro.prevFft = pro.Fft;

            co1.Open();
            OleDbCommand cm1 = co1.CreateCommand();
            cm1.CommandText = "UPDATE Stors SET Quantity = '" + price.ToString() + "' WHERE Id = '21'";
            cm1.ExecuteNonQuery();
            co1.Close();
            pro.totalprice = price;
            Show_Bill();
            Bill = "";
            txtNum.Text = "1";
            txtPrice.Text = "";
            laShow.Text = "";
            price = 0;
        }

        // Exit & update the store database
        private void button1_Click(object sender, EventArgs e)
        {


            DialogResult Dr = MessageBox.Show("Are you sure to exit this window ??", "Confirm Exit !!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Dr == DialogResult.Yes)
            {
                con.Open();
                OleDbCommand cmd = con.CreateCommand();

                foreach (ReportsRow row in finalReportsDBDataSet.Tables[0].Rows)
                {
                    if (row[1].ToString().Equals("Filling 20Ltr"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.numFilling20ltr);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 0.5).ToString() + "' WHERE Products = 'Filling 20Ltr' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Filling 10Ltr"))
                    {
                        double Quntity10 = double.Parse(row[2].ToString());
                        double All_Quntity10 = (Quntity10 + pro.numFilling10ltr);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity10.ToString() + "' , [Total Price] = '" + (All_Quntity10 * 0.25).ToString() + "' WHERE Products = 'Filling 10Ltr' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Water cups 200ml"))
                    {
                        double QuntityC200 = double.Parse(row[2].ToString());
                        double All_QuntityC200 = (QuntityC200 + pro.numCups200);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_QuntityC200.ToString() + "' , [Total Price] = '" + (All_QuntityC200 * 1.15).ToString() + "' WHERE Products = 'Water cups 200ml' ";
                        cmd.ExecuteNonQuery();
                        pro.DCups200 -= pro.NDCups200;
                        pro.NDCups200 = 0;
                        if (pro.DCups200 < 20)
                        {
                            btnCups200.BackColor = Color.Red;
                        }
                    }
                    if (row[1].ToString().Equals("Water cups 250ml"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.numCups250);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 1.25).ToString() + "' WHERE Products = 'Water cups 250ml' ";
                        cmd.ExecuteNonQuery();
                        pro.DCups250 -= pro.numCups250;
                        if (pro.DCups250 < 3)
                        {
                            btnCups250.BackColor = Color.Red;
                        }
                    }
                    if (row[1].ToString().Equals("Package 250ml"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.numPackage250);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 1.15).ToString() + "' WHERE Products = 'Package 250ml' ";
                        cmd.ExecuteNonQuery();
                        pro.DPa250 -= pro.numPackage250;
                        if (pro.DPa250 < 5)
                        {
                            btnPackage250ml.BackColor = Color.Red;
                        }
                    }
                    if (row[1].ToString().Equals("Package 330ml"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.numPackage330);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 1.25).ToString() + "' WHERE Products = 'Package 330ml' ";
                        cmd.ExecuteNonQuery();
                        pro.DPACU330 -= pro.numPackage330;
                        if (pro.DPACU330 < 3)
                        { btnPackage330.BackColor = Color.Red; }
                    }
                    if (row[1].ToString().Equals("Package 600ml"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.numPackage600);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 1.15).ToString() + "' WHERE Products = 'Package 600ml' ";
                        cmd.ExecuteNonQuery();
                        pro.DPa600 -= pro.numPackage600;
                        if (pro.DPa600 < 3)
                        { btnPackage600.BackColor = Color.Red; }
                    }
                    if (row[1].ToString().Equals("Package 1.5ltr"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.numPackage1500);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 0.90).ToString() + "' WHERE Products = 'Package 1.5ltr' ";
                        cmd.ExecuteNonQuery();
                        pro.DPa1500 -= pro.numPackage1500;
                        if (pro.DPACU330 < 3)
                        { btnPackage330.BackColor = Color.Red; }
                    }
                    if (row[1].ToString().Equals("Package AQUADOVA 600ml"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.numAQUADOVA600);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 1.25).ToString() + "' WHERE Products = 'Package AQUADOVA 600ml' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Package AQUADOVA 1500ml"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.numAQUADOVA1500);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 1.00).ToString() + "' WHERE Products = 'Package AQUADOVA 1500ml' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Bottle Saudi 10ltr"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.BottleS10);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 3.50).ToString() + "' WHERE Products = 'Bottle Saudi 10ltr' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Bottle Saudi 20ltr"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.BottleS20);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 6.00).ToString() + "' WHERE Products = 'Bottle Saudi 20ltr' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Bottle Jor 20ltr"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.BottleJ20);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 4.00).ToString() + "' WHERE Products = 'Bottle Jor 20ltr' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Bottle Jor 10ltr"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.BottleJ10);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 2.75).ToString() + "' WHERE Products = 'Bottle Jor 10ltr' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Gallon 20ltr"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.Gallon20);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 3.00).ToString() + "' WHERE Products = 'Gallon 20ltr' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Gallon 10ltr"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.BottleS20);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 2.25).ToString() + "' WHERE Products = 'Gallon 10ltr' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Coupon Book"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.coupon);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 6.00).ToString() + "' WHERE Products = 'Coupon Book' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Electronic Pump"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.Epump);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 6.00).ToString() + "' WHERE Products = 'Electronic Pump' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Hand Pump"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.handpump);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 5.00).ToString() + "' WHERE Products = 'Hand Pump' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Disponser"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.Disponser);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 7.00).ToString() + "' WHERE Products = 'Disponser' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Filter Fillings Taiwan"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.Fft);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 8.50).ToString() + "' WHERE Products = 'Filter Fillings Taiwan' ";
                        cmd.ExecuteNonQuery();
                    }
                    if (row[1].ToString().Equals("Filter Fillings Chaina"))
                    {
                        double Quntity = double.Parse(row[2].ToString());
                        double All_Quntity = (Quntity + pro.Ffc);
                        cmd.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 5.00).ToString() + "' WHERE Products = 'Filter Fillings Chaina' ";
                        cmd.ExecuteNonQuery();
                    }

                }
                con.Close();

                co1.Open();
                OleDbCommand cm1 = co1.CreateCommand();
                
                foreach (StorsRow row1 in storsDBDataSet.Tables[0].Rows)
                {
                    if (row1[0].ToString().Equals("1"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DCups200 - pro.numCups200).ToString() + "' WHERE Id = '1'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("2"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DCups250 - pro.numCups250).ToString() + "' WHERE Id = '2'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("3"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DPa250 - pro.numPackage250).ToString() + "' WHERE Id = '3'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("4"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DPACU330 - pro.numPackage330).ToString() + "' WHERE Id = '4'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("5"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DPa600 - pro.numPackage600).ToString() + "' WHERE Id = '5'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("6"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DPa1500 - pro.numPackage1500).ToString() + "' WHERE Id = '6'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("7"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DEPump - pro.Epump).ToString() + "' WHERE Id = '7'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("8"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DHPump - pro.handpump).ToString() + "' WHERE Id = '8'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("9"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DDisponser - pro.Disponser).ToString() + "' WHERE Id = '9'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("10"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DFft - pro.Fft).ToString() + "' WHERE Id = '10'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("11"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DBS20 - pro.BottleS20).ToString() + "' WHERE Id = '11'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("12"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DBS10 - pro.BottleS10).ToString() + "' WHERE Id = '12'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("13"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DG20 - pro.Gallon20).ToString() + "' WHERE Id = '13'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("14"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DG10 - pro.Gallon10).ToString() + "' WHERE Id = '14'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("15"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DPACU600 - pro.numAQUADOVA600).ToString() + "' WHERE Id = '15'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("16"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DPACU1500 - pro.numAQUADOVA1500).ToString() + "' WHERE Id = '16'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("17"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DBJ20 - pro.BottleJ20).ToString() + "' WHERE Id = '17'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("18"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DBJ10 - pro.BottleJ10).ToString() + "' WHERE Id = '18'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("19"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DCoupon - pro.coupon).ToString() + "' WHERE Id = '19'";
                        cm1.ExecuteNonQuery();
                    }
                    if (row1[0].ToString().Equals("20"))
                    {
                        cm1.CommandText = "UPDATE Stors SET Quantity = '" + (pro.DFfc - pro.Ffc).ToString() + "' WHERE Id = '20'";
                        cm1.ExecuteNonQuery();
                    }
                }
                
                co1.Close();
                Close();
                new FormHome().Show();
                               
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // filling 10 ltr button
        private void btnFilling10ltr_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.numFilling10ltr += double.Parse(txtNum.Text);
            double pricF10 = 0.25;
            laShow.Text = txtNum.Text + " X " + btnFilling10ltr.Text;
            txtPrice.Text = (Num * pricF10).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        // Bill button
        private void butClear_Click(object sender, EventArgs e)
        {
            Show_Bill();
        }

        private void Show_Bill()
        {
            pro.Bill = "";
            pro.Bill = Bill;
            pro.totalprice = price;
            new Cash().Show();
            
            
        }
        
        // Cups carton button
        private void btnCups200_Click(object sender, EventArgs e)
        {
            
            double Num = double.Parse(txtNum.Text);
            pro.PrevnumCups200 = pro.numCups200;
            pro.numCups200 += double.Parse(txtNum.Text);
            laShow.Text = txtNum.Text + " X " + btnCups200.Text;
            txtPrice.Text = (Num * pro.priceC200).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnCups250_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.prevnumCups250 = pro.numCups250;
            pro.numCups250 += double.Parse(txtNum.Text);
            double pricC250 = 1.25;
            laShow.Text = txtNum.Text + " X " + btnCups250.Text;
            txtPrice.Text = (Num * pricC250).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnPackage250ml_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.numPackage250 += double.Parse(txtNum.Text);
            double pricP250 = 1.15;
            laShow.Text = txtNum.Text + " X " + btnPackage250ml.Text;
            txtPrice.Text = (Num * pricP250).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnPackage600_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.numPackage600 += double.Parse(txtNum.Text);
            double pricP600 = 1.15;
            laShow.Text = txtNum.Text + " X " + btnPackage600.Text;
            txtPrice.Text = (Num * pricP600).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnPackage1500_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.numPackage1500 += double.Parse(txtNum.Text);
            double pricP1500 = 0.90;
            laShow.Text = txtNum.Text + " X " + btnPackage1500.Text;
            txtPrice.Text = (Num * pricP1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnPackage330_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.numPackage330 += double.Parse(txtNum.Text);
            double pricP250 = 1.25;
            laShow.Text = txtNum.Text + " X " + btnPackage330.Text;
            txtPrice.Text = (Num * pricP250).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnAQUPackage600_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.numAQUADOVA600 += double.Parse(txtNum.Text);
            double pricPA600 = 1.25;
            laShow.Text = txtNum.Text + " X " + btnAQUPackage600.Text;
            txtPrice.Text = (Num * pricPA600).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnAQUPackage1500_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.numAQUADOVA1500 += double.Parse(txtNum.Text);
            double pricPA1500 = 1.00;
            laShow.Text = txtNum.Text + " X " + btnAQUPackage1500.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnBS10_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.BottleS10 += double.Parse(txtNum.Text);
            double pricPA1500 = 3.50;
            laShow.Text = txtNum.Text + " X " + btnBS10.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnBS20_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.BottleS20 += double.Parse(txtNum.Text);
            double pricPA1500 = 3.50;
            laShow.Text = txtNum.Text + " X " + btnBS20.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void BtnBJ20_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.BottleJ20 += double.Parse(txtNum.Text);
            double pricPA1500 = 4.00;
            laShow.Text = txtNum.Text + " X " + BtnBJ20.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnBJ10_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.BottleJ10 += double.Parse(txtNum.Text);
            double pricPA1500 = 2.75;
            laShow.Text = txtNum.Text + " X " + btnBJ10.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnG20_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.Gallon20 += double.Parse(txtNum.Text);
            double pricPA1500 = 3.00;
            laShow.Text = txtNum.Text + " X " + btnG20.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnG10_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.Gallon10 += double.Parse(txtNum.Text);
            double pricPA1500 = 2.25;
            laShow.Text = txtNum.Text + " X " + btnG10.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnDisponser_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.Disponser += double.Parse(txtNum.Text);
            double pricPA1500 = 7.00;
            laShow.Text = txtNum.Text + " X " + btnDisponser.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnCoupon_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.coupon += double.Parse(txtNum.Text);
            double pricPA1500 = 6.00;
            laShow.Text = txtNum.Text + " X " + btnCoupon.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnHPump_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.handpump += double.Parse(txtNum.Text);
            double pricPA1500 = 5.00;
            laShow.Text = txtNum.Text + " X " + btnHPump.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnEPump_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.Epump += double.Parse(txtNum.Text);
            double pricPA1500 = 6.00;
            laShow.Text = txtNum.Text + " X " + btnEPump.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnFFC_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.Ffc += double.Parse(txtNum.Text);
            double pricPA1500 = 5.00;
            laShow.Text = txtNum.Text + " X " + btnFFC.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void btnFFT_Click(object sender, EventArgs e)
        {
            double Num = double.Parse(txtNum.Text);
            pro.Fft += double.Parse(txtNum.Text);
            double pricPA1500 = 8.50;
            laShow.Text = txtNum.Text + " X " + btnFFT.Text;
            txtPrice.Text = (Num * pricPA1500).ToString();
            Bill += (laShow.Text + "\n" + txtPrice.Text + "\n\n");
            txtNum.Text = "1";
            price += double.Parse(txtPrice.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // get the data of stors from data base
            con.Open();
            OleDbCommand cmd_F20ltr = con.CreateCommand();
            cmd_F20ltr.CommandText = "select * from Reports where Products= 'Filling 20Ltr'";
            OleDbDataReader reader_F20Ltr = cmd_F20ltr.ExecuteReader();
            while (reader_F20Ltr.Read())
            {
                pro.numFilling20ltr = double.Parse(reader_F20Ltr["Quantity"].ToString());
            }




            foreach (ReportsRow row in finalReportsDBDataSet.Tables[0].Rows)
            {

                if (row[1].ToString().Equals("Filling 10Ltr"))
                {
                    pro.numFilling10ltr = double.Parse(row[2].ToString());
                    
                }
                if (row[1].ToString().Equals("Water cups 200ml"))
                {
                    pro.numCups200 = double.Parse(row[2].ToString());
                    if (pro.DCups200 < 20)
                    {
                        btnCups200.BackColor = Color.Red;
                    }
                }
                if (row[1].ToString().Equals("Water cups 250ml"))
                {
                    pro.numCups250 = double.Parse(row[2].ToString());
                    if (pro.DCups250 < 3)
                    {
                        btnCups250.BackColor = Color.Red;
                    }
                }
                if (row[1].ToString().Equals("Package 250ml"))
                {
                    pro.numPackage250 = double.Parse(row[2].ToString());
                    if (pro.DPa250 < 5)
                    {
                        btnPackage250ml.BackColor = Color.Red;
                    }
                }
                if (row[1].ToString().Equals("Package 330ml"))
                {
                    pro.numPackage330 = double.Parse(row[2].ToString());
                    if (pro.DPACU330 < 3)
                    { btnPackage330.BackColor = Color.Red; }
                }
                if (row[1].ToString().Equals("Package 600ml"))
                {
                    pro.numPackage600 = double.Parse(row[2].ToString());
                    if (pro.DPa600 < 3)
                    { btnPackage600.BackColor = Color.Red; }
                }
                if (row[1].ToString().Equals("Package 1.5ltr"))
                {
                    pro.prevnumPackage1500 = double.Parse(row[2].ToString());
                    if (pro.DPACU330 < 3)
                    { btnPackage330.BackColor = Color.Red; }
                }
                if (row[1].ToString().Equals("Package AQUADOVA 600ml"))
                {
                    pro.numAQUADOVA600 = double.Parse(row[2].ToString());
                    
                }
                if (row[1].ToString().Equals("Package AQUADOVA 1500ml"))
                {
                    pro.numAQUADOVA1500 = double.Parse(row[2].ToString());
                }
                if (row[1].ToString().Equals("Bottle Saudi 10ltr"))
                {
                    pro.BottleS10 = double.Parse(row[2].ToString());
                }
                if (row[1].ToString().Equals("Bottle Saudi 20ltr"))
                {
                    pro.BottleS20 = double.Parse(row[2].ToString());
                }
                if (row[1].ToString().Equals("Bottle Jor 20ltr"))
                {
                    pro.BottleJ20 = double.Parse(row[2].ToString());
                }
                if (row[1].ToString().Equals("Bottle Jor 10ltr"))
                {
                    pro.BottleJ10 = double.Parse(row[2].ToString());
                }
                if (row[1].ToString().Equals("Gallon 20ltr"))
                {
                    pro.Gallon20 = double.Parse(row[2].ToString());
                }
                if (row[1].ToString().Equals("Gallon 10ltr"))
                {
                    double Quntity = double.Parse(row[2].ToString());
                    double All_Quntity = (Quntity + pro.BottleS20);
                    cmd_F20ltr.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 2.25).ToString() + "' WHERE Products = 'Gallon 10ltr' ";
                    cmd_F20ltr.ExecuteNonQuery();
                }
                if (row[1].ToString().Equals("Coupon Book"))
                {
                    double Quntity = double.Parse(row[2].ToString());
                    double All_Quntity = (Quntity + pro.coupon);
                    cmd_F20ltr.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 6.00).ToString() + "' WHERE Products = 'Coupon Book' ";
                    cmd_F20ltr.ExecuteNonQuery();
                }
                if (row[1].ToString().Equals("Electronic Pump"))
                {
                    double Quntity = double.Parse(row[2].ToString());
                    double All_Quntity = (Quntity + pro.Epump);
                    cmd_F20ltr.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 6.00).ToString() + "' WHERE Products = 'Electronic Pump' ";
                    cmd_F20ltr.ExecuteNonQuery();
                }
                if (row[1].ToString().Equals("Hand Pump"))
                {
                    double Quntity = double.Parse(row[2].ToString());
                    double All_Quntity = (Quntity + pro.handpump);
                    cmd_F20ltr.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 5.00).ToString() + "' WHERE Products = 'Hand Pump' ";
                    cmd_F20ltr.ExecuteNonQuery();
                }
                if (row[1].ToString().Equals("Disponser"))
                {
                    double Quntity = double.Parse(row[2].ToString());
                    double All_Quntity = (Quntity + pro.Disponser);
                    cmd_F20ltr.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 7.00).ToString() + "' WHERE Products = 'Disponser' ";
                    cmd_F20ltr.ExecuteNonQuery();
                }
                if (row[1].ToString().Equals("Filter Fillings Taiwan"))
                {
                    double Quntity = double.Parse(row[2].ToString());
                    double All_Quntity = (Quntity + pro.Fft);
                    cmd_F20ltr.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 8.50).ToString() + "' WHERE Products = 'Filter Fillings Taiwan' ";
                    cmd_F20ltr.ExecuteNonQuery();
                }
                if (row[1].ToString().Equals("Filter Fillings Chaina"))
                {
                    double Quntity = double.Parse(row[2].ToString());
                    double All_Quntity = (Quntity + pro.Ffc);
                    cmd_F20ltr.CommandText = "UPDATE Reports SET Quantity = '" + All_Quntity.ToString() + "' , [Total Price] = '" + (All_Quntity * 5.00).ToString() + "' WHERE Products = 'Filter Fillings Chaina' ";
                    cmd_F20ltr.ExecuteNonQuery();
                }

            }
            con.Close();
            foreach (StorsRow row1 in storsDBDataSet.Tables[0].Rows)
            {
                if (row1[0].ToString().Equals("1"))
                {
                    pro.DCups200 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("2"))
                {
                    pro.DCups250 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("3"))
                {
                    pro.DPa250 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("4"))
                {
                    pro.DPACU330 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("5"))
                {
                    pro.DPa600 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("6"))
                {
                    pro.DPa1500 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("7"))
                {
                    pro.DEPump = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("8"))
                {
                    pro.DHPump = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("9"))
                {
                    pro.DDisponser = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("10"))
                {
                    pro.DFft = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("11"))
                {
                    pro.DBS20 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("12"))
                {
                    pro.DBS10 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("13"))
                {
                    pro.DG20 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("14"))
                {
                    pro.DG10 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("15"))
                {
                    pro.DPACU600 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("16"))
                {
                    pro.DPACU1500 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("17"))
                {
                    pro.DBJ20 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("18"))
                {
                    pro.DBJ10 = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("19"))
                {
                    pro.DCoupon = double.Parse(row1[2].ToString());
                }
                if (row1[0].ToString().Equals("20"))
                {
                    pro.DFfc = double.Parse(row1[2].ToString());
                }
            }
            button2.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Cancel()
        {
            pro.numFilling20ltr = pro.prevnumFilling20ltr;
            pro.numFilling10ltr = pro.prevnumFilling10ltr;

            pro.numCups200 = pro.PrevnumCups200;
            pro.numCups250 = pro.prevnumCups250;

            pro.numPackage250 = pro.prevnumPackage250;
            pro.numPackage330 = pro.prevnumPackage330;
            pro.numPackage600 = pro.prevnumPackage600;
            pro.numPackage1500 = pro.prevnumPackage1500;

            pro.numAQUADOVA600 = pro.prevnumAQUADOVA600;
            pro.numAQUADOVA1500 = pro.prevnumAQUADOVA1500;

            pro.coupon = pro.prevcoupon;
            pro.Disponser = pro.prevDisponser;
            pro.Gallon10 = pro.prevGallon10;
            pro.Gallon20 = pro.prevGallon20;
            pro.BottleJ10 = pro.prevBottleJ10;
            pro.BottleJ20 = pro.prevBottleJ20;
            pro.BottleS10 = pro.prevBottleS10;
            pro.BottleS20 = pro.prevBottleS20;
            pro.Ffc = pro.prevFfc;
            pro.Fft = pro.prevFft;




            pro.NDCups200 = 0;
            Bill = "";
            laShow.Text = "";
            txtNum.Text = "1";
            txtPrice.Text = "0.00";
            price = 0;
        }
    }
}
