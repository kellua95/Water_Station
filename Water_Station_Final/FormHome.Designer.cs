
namespace Water_Station_Final
{
    partial class FormHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.ibutLogout = new FontAwesome.Sharp.IconButton();
            this.ibutReports = new FontAwesome.Sharp.IconButton();
            this.ibutMantinans = new FontAwesome.Sharp.IconButton();
            this.ibutRigester = new FontAwesome.Sharp.IconButton();
            this.ibutExpenses = new FontAwesome.Sharp.IconButton();
            this.ibutPOS = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butMenu = new FontAwesome.Sharp.IconButton();
            this.lawat = new System.Windows.Forms.Label();
            this.lacom = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.laTime = new System.Windows.Forms.Label();
            this.laDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelmenu.Controls.Add(this.ibutLogout);
            this.panelmenu.Controls.Add(this.ibutReports);
            this.panelmenu.Controls.Add(this.ibutMantinans);
            this.panelmenu.Controls.Add(this.ibutRigester);
            this.panelmenu.Controls.Add(this.ibutExpenses);
            this.panelmenu.Controls.Add(this.ibutPOS);
            this.panelmenu.Controls.Add(this.panel1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(250, 952);
            this.panelmenu.TabIndex = 20;
            // 
            // ibutLogout
            // 
            this.ibutLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibutLogout.FlatAppearance.BorderSize = 0;
            this.ibutLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibutLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibutLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.ibutLogout.IconColor = System.Drawing.Color.Black;
            this.ibutLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibutLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibutLogout.Location = new System.Drawing.Point(0, 862);
            this.ibutLogout.Name = "ibutLogout";
            this.ibutLogout.Size = new System.Drawing.Size(250, 90);
            this.ibutLogout.TabIndex = 12;
            this.ibutLogout.Tag = "Logout";
            this.ibutLogout.Text = "Logout";
            this.ibutLogout.UseVisualStyleBackColor = true;
            this.ibutLogout.Click += new System.EventHandler(this.ibutLogout_Click);
            // 
            // ibutReports
            // 
            this.ibutReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibutReports.FlatAppearance.BorderSize = 0;
            this.ibutReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibutReports.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibutReports.ForeColor = System.Drawing.Color.Black;
            this.ibutReports.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.ibutReports.IconColor = System.Drawing.Color.Black;
            this.ibutReports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibutReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibutReports.Location = new System.Drawing.Point(0, 479);
            this.ibutReports.Name = "ibutReports";
            this.ibutReports.Size = new System.Drawing.Size(250, 90);
            this.ibutReports.TabIndex = 11;
            this.ibutReports.Tag = "         Sales Reports";
            this.ibutReports.Text = "         Sales Reports";
            this.ibutReports.UseVisualStyleBackColor = true;
            this.ibutReports.Click += new System.EventHandler(this.ibutReports_Click);
            // 
            // ibutMantinans
            // 
            this.ibutMantinans.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibutMantinans.FlatAppearance.BorderSize = 0;
            this.ibutMantinans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibutMantinans.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibutMantinans.ForeColor = System.Drawing.Color.Black;
            this.ibutMantinans.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.ibutMantinans.IconColor = System.Drawing.Color.Black;
            this.ibutMantinans.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibutMantinans.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibutMantinans.Location = new System.Drawing.Point(0, 389);
            this.ibutMantinans.Name = "ibutMantinans";
            this.ibutMantinans.Size = new System.Drawing.Size(250, 90);
            this.ibutMantinans.TabIndex = 10;
            this.ibutMantinans.Tag = "    Mantinans";
            this.ibutMantinans.Text = "    Mantinans";
            this.ibutMantinans.UseVisualStyleBackColor = true;
            this.ibutMantinans.Click += new System.EventHandler(this.ibutMantinans_Click);
            // 
            // ibutRigester
            // 
            this.ibutRigester.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibutRigester.FlatAppearance.BorderSize = 0;
            this.ibutRigester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibutRigester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibutRigester.ForeColor = System.Drawing.Color.Black;
            this.ibutRigester.IconChar = FontAwesome.Sharp.IconChar.User;
            this.ibutRigester.IconColor = System.Drawing.Color.Black;
            this.ibutRigester.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibutRigester.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibutRigester.Location = new System.Drawing.Point(0, 299);
            this.ibutRigester.Name = "ibutRigester";
            this.ibutRigester.Size = new System.Drawing.Size(250, 90);
            this.ibutRigester.TabIndex = 9;
            this.ibutRigester.Tag = "       Rigester New";
            this.ibutRigester.Text = "       Rigester New";
            this.ibutRigester.UseVisualStyleBackColor = true;
            this.ibutRigester.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // ibutExpenses
            // 
            this.ibutExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibutExpenses.FlatAppearance.BorderSize = 0;
            this.ibutExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibutExpenses.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibutExpenses.ForeColor = System.Drawing.Color.Black;
            this.ibutExpenses.IconChar = FontAwesome.Sharp.IconChar.StoreAlt;
            this.ibutExpenses.IconColor = System.Drawing.Color.Black;
            this.ibutExpenses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibutExpenses.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibutExpenses.Location = new System.Drawing.Point(0, 209);
            this.ibutExpenses.Name = "ibutExpenses";
            this.ibutExpenses.Size = new System.Drawing.Size(250, 90);
            this.ibutExpenses.TabIndex = 8;
            this.ibutExpenses.Tag = "Expenses";
            this.ibutExpenses.Text = "Expenses";
            this.ibutExpenses.UseVisualStyleBackColor = true;
            this.ibutExpenses.Click += new System.EventHandler(this.ibutExpenses_Click);
            // 
            // ibutPOS
            // 
            this.ibutPOS.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ibutPOS.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibutPOS.FlatAppearance.BorderSize = 0;
            this.ibutPOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibutPOS.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibutPOS.ForeColor = System.Drawing.Color.Black;
            this.ibutPOS.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.ibutPOS.IconColor = System.Drawing.Color.Black;
            this.ibutPOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibutPOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ibutPOS.Location = new System.Drawing.Point(0, 119);
            this.ibutPOS.Name = "ibutPOS";
            this.ibutPOS.Size = new System.Drawing.Size(250, 90);
            this.ibutPOS.TabIndex = 7;
            this.ibutPOS.Tag = "      Point Of Sale";
            this.ibutPOS.Text = "      Point Of Sale";
            this.ibutPOS.UseVisualStyleBackColor = false;
            this.ibutPOS.Click += new System.EventHandler(this.ibutPOS_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butMenu);
            this.panel1.Controls.Add(this.lawat);
            this.panel1.Controls.Add(this.lacom);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 119);
            this.panel1.TabIndex = 1;
            // 
            // butMenu
            // 
            this.butMenu.FlatAppearance.BorderSize = 0;
            this.butMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.butMenu.IconColor = System.Drawing.Color.Black;
            this.butMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.butMenu.Location = new System.Drawing.Point(166, 3);
            this.butMenu.Name = "butMenu";
            this.butMenu.Size = new System.Drawing.Size(75, 75);
            this.butMenu.TabIndex = 6;
            this.butMenu.UseVisualStyleBackColor = true;
            this.butMenu.Click += new System.EventHandler(this.butMenu_Click);
            // 
            // lawat
            // 
            this.lawat.AutoSize = true;
            this.lawat.Font = new System.Drawing.Font("Lucida Calligraphy", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lawat.ForeColor = System.Drawing.Color.Black;
            this.lawat.Location = new System.Drawing.Point(3, 76);
            this.lawat.Name = "lawat";
            this.lawat.Size = new System.Drawing.Size(130, 21);
            this.lawat.TabIndex = 5;
            this.lawat.Text = "Water Station";
            // 
            // lacom
            // 
            this.lacom.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lacom.ForeColor = System.Drawing.Color.Black;
            this.lacom.Location = new System.Drawing.Point(3, 9);
            this.lacom.Name = "lacom";
            this.lacom.Size = new System.Drawing.Size(157, 67);
            this.lacom.TabIndex = 4;
            this.lacom.Text = "Yarmouk River";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImage = global::Water_Station_Final.Properties.Resources.Screenshot_2021_12_25_123406;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(1292, 501);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(300, 180);
            this.button6.TabIndex = 18;
            this.button6.Text = "Sales Reports";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = global::Water_Station_Final.Properties.Resources.Screenshot_2021_12_25_112750;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(986, 315);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(300, 366);
            this.button5.TabIndex = 17;
            this.button5.Text = "Sales";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::Water_Station_Final.Properties.Resources.Screenshot_2021_12_25_1109171;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1292, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 180);
            this.button3.TabIndex = 15;
            this.button3.Text = "Maintenance";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::Water_Station_Final.Properties.Resources.Screenshot_2021_12_31_180837;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(680, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 180);
            this.button2.TabIndex = 14;
            this.button2.Text = "Expenses";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::Water_Station_Final.Properties.Resources.inclined_key;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(680, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 180);
            this.button1.TabIndex = 13;
            this.button1.Text = "Rigester new employee";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Location = new System.Drawing.Point(1019, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 54);
            this.label2.TabIndex = 12;
            this.label2.Text = "Welcom!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.Location = new System.Drawing.Point(729, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(771, 57);
            this.label1.TabIndex = 11;
            this.label1.Text = "Yarmouk River Water Station";
            // 
            // laTime
            // 
            this.laTime.AutoSize = true;
            this.laTime.BackColor = System.Drawing.Color.SkyBlue;
            this.laTime.Location = new System.Drawing.Point(1694, 903);
            this.laTime.Name = "laTime";
            this.laTime.Size = new System.Drawing.Size(43, 20);
            this.laTime.TabIndex = 26;
            this.laTime.Text = "Time";
            this.laTime.Click += new System.EventHandler(this.laTime_Click);
            // 
            // laDate
            // 
            this.laDate.AutoSize = true;
            this.laDate.BackColor = System.Drawing.Color.SkyBlue;
            this.laDate.Location = new System.Drawing.Point(1694, 923);
            this.laDate.Name = "laDate";
            this.laDate.Size = new System.Drawing.Size(44, 20);
            this.laDate.TabIndex = 25;
            this.laDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Water_Station_Final.Properties.Resources.Screenshot_2021_12_25_100755;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1893, 952);
            this.Controls.Add(this.laTime);
            this.Controls.Add(this.laDate);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1915, 1006);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private FontAwesome.Sharp.IconButton ibutLogout;
        private FontAwesome.Sharp.IconButton ibutReports;
        private FontAwesome.Sharp.IconButton ibutMantinans;
        private FontAwesome.Sharp.IconButton ibutRigester;
        private FontAwesome.Sharp.IconButton ibutExpenses;
        private FontAwesome.Sharp.IconButton ibutPOS;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton butMenu;
        private System.Windows.Forms.Label lawat;
        private System.Windows.Forms.Label lacom;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laTime;
        private System.Windows.Forms.Label laDate;
        private System.Windows.Forms.Timer timer1;
    }
}