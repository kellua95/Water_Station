
namespace Water_Station_Final
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.laUsername = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lainvalid = new System.Windows.Forms.Label();
            this.linkLaForgetPassword = new System.Windows.Forms.LinkLabel();
            this.butExit = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.laTime = new System.Windows.Forms.Label();
            this.laDate = new System.Windows.Forms.Label();
            this.butLogin = new System.Windows.Forms.Button();
            this.laPassword = new System.Windows.Forms.Label();
            this.pictPassword = new System.Windows.Forms.PictureBox();
            this.pictViwe = new System.Windows.Forms.PictureBox();
            this.pictUnViwe = new System.Windows.Forms.PictureBox();
            this.pictUsername = new System.Windows.Forms.PictureBox();
            this.dB_EmployeeDataSet = new Water_Station_Final.DB_EmployeeDataSet();
            this.dBEmployeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Water_Station_Final.DB_EmployeeDataSetTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictViwe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUnViwe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmployeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEmployeeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(48, 234);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(324, 25);
            this.txtPassword.TabIndex = 26;
            this.txtPassword.Text = "Password";
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // laUsername
            // 
            this.laUsername.BackColor = System.Drawing.Color.White;
            this.laUsername.Location = new System.Drawing.Point(44, 170);
            this.laUsername.Name = "laUsername";
            this.laUsername.Size = new System.Drawing.Size(324, 26);
            this.laUsername.TabIndex = 29;
            this.laUsername.Text = "_________________________________________________________";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lainvalid
            // 
            this.lainvalid.AutoSize = true;
            this.lainvalid.BackColor = System.Drawing.Color.White;
            this.lainvalid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lainvalid.ForeColor = System.Drawing.Color.Red;
            this.lainvalid.Location = new System.Drawing.Point(12, 123);
            this.lainvalid.Name = "lainvalid";
            this.lainvalid.Size = new System.Drawing.Size(308, 29);
            this.lainvalid.TabIndex = 35;
            this.lainvalid.Text = "Invalid Username or Password";
            this.lainvalid.Visible = false;
            // 
            // linkLaForgetPassword
            // 
            this.linkLaForgetPassword.AutoSize = true;
            this.linkLaForgetPassword.BackColor = System.Drawing.Color.AliceBlue;
            this.linkLaForgetPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLaForgetPassword.LinkColor = System.Drawing.Color.Black;
            this.linkLaForgetPassword.Location = new System.Drawing.Point(12, 331);
            this.linkLaForgetPassword.Name = "linkLaForgetPassword";
            this.linkLaForgetPassword.Size = new System.Drawing.Size(173, 29);
            this.linkLaForgetPassword.TabIndex = 33;
            this.linkLaForgetPassword.TabStop = true;
            this.linkLaForgetPassword.Text = "Forget Password";
            this.linkLaForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLaForgetPassword_LinkClicked);
            this.linkLaForgetPassword.MouseHover += new System.EventHandler(this.linkLaForgetPassword_MouseHover);
            // 
            // butExit
            // 
            this.butExit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExit.Location = new System.Drawing.Point(893, 585);
            this.butExit.Name = "butExit";
            this.butExit.Size = new System.Drawing.Size(118, 41);
            this.butExit.TabIndex = 32;
            this.butExit.Text = "Exit";
            this.butExit.UseVisualStyleBackColor = true;
            this.butExit.Click += new System.EventHandler(this.butExit_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(48, 155);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 25);
            this.txtUsername.TabIndex = 25;
            this.txtUsername.Tag = "";
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // laTime
            // 
            this.laTime.AutoSize = true;
            this.laTime.BackColor = System.Drawing.Color.SkyBlue;
            this.laTime.Location = new System.Drawing.Point(12, 589);
            this.laTime.Name = "laTime";
            this.laTime.Size = new System.Drawing.Size(43, 20);
            this.laTime.TabIndex = 24;
            this.laTime.Text = "Time";
            // 
            // laDate
            // 
            this.laDate.AutoSize = true;
            this.laDate.BackColor = System.Drawing.Color.SkyBlue;
            this.laDate.Location = new System.Drawing.Point(12, 609);
            this.laDate.Name = "laDate";
            this.laDate.Size = new System.Drawing.Size(44, 20);
            this.laDate.TabIndex = 23;
            this.laDate.Text = "Date";
            // 
            // butLogin
            // 
            this.butLogin.BackColor = System.Drawing.Color.DodgerBlue;
            this.butLogin.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogin.ForeColor = System.Drawing.Color.White;
            this.butLogin.Location = new System.Drawing.Point(222, 319);
            this.butLogin.Name = "butLogin";
            this.butLogin.Size = new System.Drawing.Size(146, 55);
            this.butLogin.TabIndex = 22;
            this.butLogin.Text = "Login";
            this.butLogin.UseVisualStyleBackColor = false;
            this.butLogin.Click += new System.EventHandler(this.butLogin_Click);
            // 
            // laPassword
            // 
            this.laPassword.BackColor = System.Drawing.Color.White;
            this.laPassword.Location = new System.Drawing.Point(48, 250);
            this.laPassword.Name = "laPassword";
            this.laPassword.Size = new System.Drawing.Size(324, 26);
            this.laPassword.TabIndex = 30;
            this.laPassword.Text = "_________________________________________________________";
            // 
            // pictPassword
            // 
            this.pictPassword.BackColor = System.Drawing.Color.White;
            this.pictPassword.Image = global::Water_Station_Final.Properties.Resources._lock;
            this.pictPassword.Location = new System.Drawing.Point(11, 234);
            this.pictPassword.Name = "pictPassword";
            this.pictPassword.Size = new System.Drawing.Size(31, 28);
            this.pictPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictPassword.TabIndex = 28;
            this.pictPassword.TabStop = false;
            // 
            // pictViwe
            // 
            this.pictViwe.BackColor = System.Drawing.Color.White;
            this.pictViwe.Image = global::Water_Station_Final.Properties.Resources.View;
            this.pictViwe.Location = new System.Drawing.Point(337, 234);
            this.pictViwe.Name = "pictViwe";
            this.pictViwe.Size = new System.Drawing.Size(31, 28);
            this.pictViwe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictViwe.TabIndex = 34;
            this.pictViwe.TabStop = false;
            this.pictViwe.Click += new System.EventHandler(this.pictViwe_Click);
            // 
            // pictUnViwe
            // 
            this.pictUnViwe.BackColor = System.Drawing.Color.White;
            this.pictUnViwe.Image = global::Water_Station_Final.Properties.Resources.UnView;
            this.pictUnViwe.Location = new System.Drawing.Point(337, 235);
            this.pictUnViwe.Name = "pictUnViwe";
            this.pictUnViwe.Size = new System.Drawing.Size(31, 28);
            this.pictUnViwe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictUnViwe.TabIndex = 31;
            this.pictUnViwe.TabStop = false;
            this.pictUnViwe.Visible = false;
            this.pictUnViwe.Click += new System.EventHandler(this.pictUnViwe_Click);
            // 
            // pictUsername
            // 
            this.pictUsername.BackColor = System.Drawing.Color.White;
            this.pictUsername.Image = global::Water_Station_Final.Properties.Resources.user__1_;
            this.pictUsername.Location = new System.Drawing.Point(11, 155);
            this.pictUsername.Name = "pictUsername";
            this.pictUsername.Size = new System.Drawing.Size(31, 28);
            this.pictUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictUsername.TabIndex = 27;
            this.pictUsername.TabStop = false;
            // 
            // dB_EmployeeDataSet
            // 
            this.dB_EmployeeDataSet.DataSetName = "DB_EmployeeDataSet";
            this.dB_EmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dBEmployeeDataSetBindingSource
            // 
            this.dBEmployeeDataSetBindingSource.DataSource = this.dB_EmployeeDataSet;
            this.dBEmployeeDataSetBindingSource.Position = 0;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dBEmployeeDataSetBindingSource;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // FormLogin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Water_Station_Final.Properties.Resources.login_form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 645);
            this.Controls.Add(this.pictPassword);
            this.Controls.Add(this.lainvalid);
            this.Controls.Add(this.pictViwe);
            this.Controls.Add(this.linkLaForgetPassword);
            this.Controls.Add(this.butExit);
            this.Controls.Add(this.pictUnViwe);
            this.Controls.Add(this.pictUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.laTime);
            this.Controls.Add(this.laDate);
            this.Controls.Add(this.butLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.laUsername);
            this.Controls.Add(this.laPassword);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1045, 701);
            this.MinimumSize = new System.Drawing.Size(1045, 701);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.Click += new System.EventHandler(this.FormLogin_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictViwe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUnViwe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmployeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEmployeeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label laUsername;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lainvalid;
        private System.Windows.Forms.PictureBox pictViwe;
        private System.Windows.Forms.LinkLabel linkLaForgetPassword;
        private System.Windows.Forms.Button butExit;
        private System.Windows.Forms.PictureBox pictUnViwe;
        private System.Windows.Forms.PictureBox pictUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label laTime;
        private System.Windows.Forms.Label laDate;
        private System.Windows.Forms.Button butLogin;
        private System.Windows.Forms.Label laPassword;
        private System.Windows.Forms.BindingSource dBEmployeeDataSetBindingSource;
        private DB_EmployeeDataSet dB_EmployeeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DB_EmployeeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}

