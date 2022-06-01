
namespace Water_Station_Final
{
    partial class Rigester
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ButRigester = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictPassword = new System.Windows.Forms.PictureBox();
            this.pictUsername = new System.Windows.Forms.PictureBox();
            this.lainvalid = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.laUsername = new System.Windows.Forms.Label();
            this.laPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dB_EmployeeDataSet = new Water_Station_Final.DB_EmployeeDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Water_Station_Final.DB_EmployeeDataSetTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmployeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(17, 478);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 49);
            this.checkBox1.TabIndex = 67;
            this.checkBox1.Text = "Admin";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ButRigester
            // 
            this.ButRigester.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButRigester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButRigester.ForeColor = System.Drawing.Color.White;
            this.ButRigester.Location = new System.Drawing.Point(139, 478);
            this.ButRigester.Name = "ButRigester";
            this.ButRigester.Size = new System.Drawing.Size(249, 49);
            this.ButRigester.TabIndex = 66;
            this.ButRigester.Text = "Rigester";
            this.ButRigester.UseVisualStyleBackColor = false;
            this.ButRigester.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Water_Station_Final.Properties.Resources.email;
            this.pictureBox1.Location = new System.Drawing.Point(17, 381);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Lucida Calligraphy", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Location = new System.Drawing.Point(54, 381);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 30);
            this.txtEmail.TabIndex = 63;
            this.txtEmail.Tag = "";
            this.txtEmail.Text = "Email";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 26);
            this.label1.TabIndex = 64;
            this.label1.Text = "___________________________________________________";
            // 
            // pictPassword
            // 
            this.pictPassword.BackColor = System.Drawing.Color.White;
            this.pictPassword.Image = global::Water_Station_Final.Properties.Resources._lock;
            this.pictPassword.Location = new System.Drawing.Point(17, 300);
            this.pictPassword.Name = "pictPassword";
            this.pictPassword.Size = new System.Drawing.Size(31, 28);
            this.pictPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictPassword.TabIndex = 62;
            this.pictPassword.TabStop = false;
            // 
            // pictUsername
            // 
            this.pictUsername.BackColor = System.Drawing.Color.White;
            this.pictUsername.Image = global::Water_Station_Final.Properties.Resources.user__1_;
            this.pictUsername.Location = new System.Drawing.Point(16, 229);
            this.pictUsername.Name = "pictUsername";
            this.pictUsername.Size = new System.Drawing.Size(31, 28);
            this.pictUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictUsername.TabIndex = 61;
            this.pictUsername.TabStop = false;
            // 
            // lainvalid
            // 
            this.lainvalid.AutoSize = true;
            this.lainvalid.BackColor = System.Drawing.Color.White;
            this.lainvalid.Font = new System.Drawing.Font("Lucida Calligraphy", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lainvalid.ForeColor = System.Drawing.Color.Red;
            this.lainvalid.Location = new System.Drawing.Point(12, 163);
            this.lainvalid.Name = "lainvalid";
            this.lainvalid.Size = new System.Drawing.Size(344, 27);
            this.lainvalid.TabIndex = 60;
            this.lainvalid.Text = "Invalid Username or Password";
            this.lainvalid.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Lucida Calligraphy", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(54, 300);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ShortcutsEnabled = false;
            this.txtPassword.Size = new System.Drawing.Size(320, 30);
            this.txtPassword.TabIndex = 55;
            this.txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Lucida Calligraphy", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(53, 229);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(320, 30);
            this.txtUsername.TabIndex = 54;
            this.txtUsername.Tag = "";
            this.txtUsername.Text = "Username";
            // 
            // laUsername
            // 
            this.laUsername.BackColor = System.Drawing.Color.White;
            this.laUsername.Location = new System.Drawing.Point(49, 244);
            this.laUsername.Name = "laUsername";
            this.laUsername.Size = new System.Drawing.Size(324, 26);
            this.laUsername.TabIndex = 56;
            this.laUsername.Text = "___________________________________________________";
            // 
            // laPassword
            // 
            this.laPassword.BackColor = System.Drawing.Color.White;
            this.laPassword.Location = new System.Drawing.Point(54, 316);
            this.laPassword.Name = "laPassword";
            this.laPassword.Size = new System.Drawing.Size(324, 26);
            this.laPassword.TabIndex = 57;
            this.laPassword.Text = "___________________________________________________";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 48);
            this.button1.TabIndex = 69;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dB_EmployeeDataSet
            // 
            this.dB_EmployeeDataSet.DataSetName = "DB_EmployeeDataSet";
            this.dB_EmployeeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.dB_EmployeeDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // Rigester
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Water_Station_Final.Properties.Resources.login_form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ButRigester);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictPassword);
            this.Controls.Add(this.pictUsername);
            this.Controls.Add(this.lainvalid);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.laUsername);
            this.Controls.Add(this.laPassword);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1045, 701);
            this.MinimumSize = new System.Drawing.Size(1045, 701);
            this.Name = "Rigester";
            this.Text = "Rigester";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Rigester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmployeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ButRigester;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictPassword;
        private System.Windows.Forms.PictureBox pictUsername;
        private System.Windows.Forms.Label lainvalid;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label laUsername;
        private System.Windows.Forms.Label laPassword;
        private System.Windows.Forms.Button button1;
        private DB_EmployeeDataSet dB_EmployeeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DB_EmployeeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}