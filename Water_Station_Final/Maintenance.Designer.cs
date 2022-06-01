
namespace Water_Station_Final
{
    partial class Maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance));
            this.laDescrbtion = new System.Windows.Forms.Label();
            this.comBoxType = new System.Windows.Forms.ComboBox();
            this.laParts = new System.Windows.Forms.Label();
            this.comBoxDescription = new System.Windows.Forms.ComboBox();
            this.laTyps = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laDescrbtion
            // 
            this.laDescrbtion.BackColor = System.Drawing.Color.White;
            this.laDescrbtion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laDescrbtion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.laDescrbtion.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laDescrbtion.ForeColor = System.Drawing.Color.Black;
            this.laDescrbtion.Location = new System.Drawing.Point(539, 278);
            this.laDescrbtion.Name = "laDescrbtion";
            this.laDescrbtion.Size = new System.Drawing.Size(1016, 457);
            this.laDescrbtion.TabIndex = 11;
            this.laDescrbtion.Text = "label2";
            // 
            // comBoxType
            // 
            this.comBoxType.Font = new System.Drawing.Font("Lucida Calligraphy", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxType.ForeColor = System.Drawing.Color.Red;
            this.comBoxType.FormattingEnabled = true;
            this.comBoxType.Location = new System.Drawing.Point(12, 691);
            this.comBoxType.Name = "comBoxType";
            this.comBoxType.Size = new System.Drawing.Size(381, 44);
            this.comBoxType.TabIndex = 10;
            this.comBoxType.SelectedIndexChanged += new System.EventHandler(this.comBoxType_SelectedIndexChanged);
            // 
            // laParts
            // 
            this.laParts.AutoSize = true;
            this.laParts.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laParts.ForeColor = System.Drawing.Color.DodgerBlue;
            this.laParts.Location = new System.Drawing.Point(12, 631);
            this.laParts.Name = "laParts";
            this.laParts.Size = new System.Drawing.Size(240, 39);
            this.laParts.TabIndex = 9;
            this.laParts.Text = "Type of holidays:";
            // 
            // comBoxDescription
            // 
            this.comBoxDescription.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxDescription.ForeColor = System.Drawing.Color.Red;
            this.comBoxDescription.FormattingEnabled = true;
            this.comBoxDescription.Items.AddRange(new object[] {
            "(None)",
            "Malfunction in a car",
            "Pipe failures",
            "Electricity malfunction",
            "No water",
            "Malfunction in the filters",
            "Emergency"});
            this.comBoxDescription.Location = new System.Drawing.Point(19, 278);
            this.comBoxDescription.Name = "comBoxDescription";
            this.comBoxDescription.Size = new System.Drawing.Size(381, 39);
            this.comBoxDescription.TabIndex = 8;
            this.comBoxDescription.SelectedIndexChanged += new System.EventHandler(this.comBoxDescription_SelectedIndexChanged);
            // 
            // laTyps
            // 
            this.laTyps.AutoSize = true;
            this.laTyps.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTyps.ForeColor = System.Drawing.Color.DodgerBlue;
            this.laTyps.Location = new System.Drawing.Point(12, 220);
            this.laTyps.Name = "laTyps";
            this.laTyps.Size = new System.Drawing.Size(240, 39);
            this.laTyps.TabIndex = 7;
            this.laTyps.Text = "Type of holidays:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(709, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 101);
            this.label1.TabIndex = 6;
            this.label1.Text = "Maintenance";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 48);
            this.button1.TabIndex = 12;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Maintenance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Water_Station_Final.Properties.Resources.Screenshot_2021_12_25_100755;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1893, 952);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.laDescrbtion);
            this.Controls.Add(this.comBoxType);
            this.Controls.Add(this.laParts);
            this.Controls.Add(this.comBoxDescription);
            this.Controls.Add(this.laTyps);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laDescrbtion;
        private System.Windows.Forms.ComboBox comBoxType;
        private System.Windows.Forms.Label laParts;
        private System.Windows.Forms.ComboBox comBoxDescription;
        private System.Windows.Forms.Label laTyps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}