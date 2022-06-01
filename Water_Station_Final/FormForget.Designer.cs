
namespace Water_Station_Final
{
    partial class FormForget
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
            this.lainvalid = new System.Windows.Forms.Label();
            this.linkLaBack = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.butShowPass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dB_EmployeeDataSet = new Water_Station_Final.DB_EmployeeDataSet();
            this.dBEmployeeDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Water_Station_Final.DB_EmployeeDataSetTableAdapters.EmployeeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmployeeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEmployeeDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lainvalid
            // 
            this.lainvalid.AutoSize = true;
            this.lainvalid.BackColor = System.Drawing.Color.White;
            this.lainvalid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lainvalid.ForeColor = System.Drawing.Color.Red;
            this.lainvalid.Location = new System.Drawing.Point(14, 221);
            this.lainvalid.Name = "lainvalid";
            this.lainvalid.Size = new System.Drawing.Size(308, 29);
            this.lainvalid.TabIndex = 31;
            this.lainvalid.Text = "Invalid Username or Password";
            this.lainvalid.Visible = false;
            // 
            // linkLaBack
            // 
            this.linkLaBack.AutoSize = true;
            this.linkLaBack.BackColor = System.Drawing.Color.White;
            this.linkLaBack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLaBack.Location = new System.Drawing.Point(14, 492);
            this.linkLaBack.Name = "linkLaBack";
            this.linkLaBack.Size = new System.Drawing.Size(220, 29);
            this.linkLaBack.TabIndex = 30;
            this.linkLaBack.TabStop = true;
            this.linkLaBack.Text = "← Back to login page";
            this.linkLaBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLaBack_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Water_Station_Final.Properties.Resources.email;
            this.pictureBox2.Location = new System.Drawing.Point(12, 362);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 44);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Water_Station_Final.Properties.Resources.user__1_;
            this.pictureBox1.Location = new System.Drawing.Point(12, 271);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(65, 271);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(392, 27);
            this.txtUsername.TabIndex = 26;
            this.txtUsername.Text = "Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(72, 362);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(385, 27);
            this.txtEmail.TabIndex = 24;
            this.txtEmail.Text = "Email";
            this.txtEmail.Click += new System.EventHandler(this.txtEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 49);
            this.label1.TabIndex = 23;
            this.label1.Text = "Forget your password?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // butShowPass
            // 
            this.butShowPass.BackColor = System.Drawing.Color.DodgerBlue;
            this.butShowPass.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butShowPass.ForeColor = System.Drawing.Color.White;
            this.butShowPass.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.butShowPass.Location = new System.Drawing.Point(12, 430);
            this.butShowPass.Name = "butShowPass";
            this.butShowPass.Size = new System.Drawing.Size(446, 43);
            this.butShowPass.TabIndex = 22;
            this.butShowPass.Text = "Show password";
            this.butShowPass.UseVisualStyleBackColor = false;
            this.butShowPass.Click += new System.EventHandler(this.butShowPass_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(71, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 31);
            this.label3.TabIndex = 25;
            this.label3.Text = "__________________________________________";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(389, 29);
            this.label4.TabIndex = 27;
            this.label4.Text = "__________________________________________";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 48);
            this.button1.TabIndex = 32;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // FormForget
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Water_Station_Final.Properties.Resources.login_form;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1023, 645);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lainvalid);
            this.Controls.Add(this.linkLaBack);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butShowPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1045, 701);
            this.MinimumSize = new System.Drawing.Size(1045, 701);
            this.Name = "FormForget";
            this.Text = "FormForget";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormForget_Load);
            this.Click += new System.EventHandler(this.FormForget_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_EmployeeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBEmployeeDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lainvalid;
        private System.Windows.Forms.LinkLabel linkLaBack;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butShowPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource dBEmployeeDataSetBindingSource;
        private DB_EmployeeDataSet dB_EmployeeDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private DB_EmployeeDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
    }
}