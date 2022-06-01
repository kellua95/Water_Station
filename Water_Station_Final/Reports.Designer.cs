
namespace Water_Station_Final
{
    partial class Reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CombReports = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbState = new System.Windows.Forms.GroupBox();
            this.laRed = new System.Windows.Forms.Label();
            this.laYellow = new System.Windows.Forms.Label();
            this.laOrange = new System.Windows.Forms.Label();
            this.laGreen = new System.Windows.Forms.Label();
            this.gbDescription = new System.Windows.Forms.GroupBox();
            this.laResult = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalReportsDBDataSet = new Water_Station_Final.FinalReportsDBDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.reportsTableAdapter = new Water_Station_Final.FinalReportsDBDataSetTableAdapters.ReportsTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.individualPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storsDBDataSet = new Water_Station_Final.StorsDBDataSet();
            this.storsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storsTableAdapter = new Water_Station_Final.StorsDBDataSetTableAdapters.StorsTableAdapter();
            this.tableAdapterManager = new Water_Station_Final.StorsDBDataSetTableAdapters.TableAdapterManager();
            this.storsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbState.SuspendLayout();
            this.gbDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalReportsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CombReports
            // 
            this.CombReports.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombReports.ForeColor = System.Drawing.Color.Black;
            this.CombReports.FormattingEnabled = true;
            this.CombReports.Items.AddRange(new object[] {
            "Report of sales",
            "Report of profits"});
            this.CombReports.Location = new System.Drawing.Point(26, 236);
            this.CombReports.Name = "CombReports";
            this.CombReports.Size = new System.Drawing.Size(344, 37);
            this.CombReports.TabIndex = 0;
            this.CombReports.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(22, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the Report:";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(20, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 76);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 76);
            this.label3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(20, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 76);
            this.label4.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(20, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 76);
            this.label5.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(18, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(279, 60);
            this.label6.TabIndex = 6;
            this.label6.Text = "Green symbolizes that you have achieved the profit target.";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(18, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 58);
            this.label7.TabIndex = 7;
            this.label7.Text = "Yellow symbolizes that you have made a good profits.";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 66);
            this.label8.TabIndex = 8;
            this.label8.Text = "Orange symbolizes that you have made a bad profits.";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(18, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(261, 52);
            this.label9.TabIndex = 9;
            this.label9.Text = "Red symbolizes that you did not make a mentioned profit.";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label10.Location = new System.Drawing.Point(666, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(489, 59);
            this.label10.TabIndex = 10;
            this.label10.Text = "Profit and sales reports";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // gbState
            // 
            this.gbState.Controls.Add(this.laRed);
            this.gbState.Controls.Add(this.laYellow);
            this.gbState.Controls.Add(this.laOrange);
            this.gbState.Controls.Add(this.laGreen);
            this.gbState.Controls.Add(this.label4);
            this.gbState.Controls.Add(this.label5);
            this.gbState.Controls.Add(this.label2);
            this.gbState.Controls.Add(this.label3);
            this.gbState.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbState.Location = new System.Drawing.Point(26, 400);
            this.gbState.Name = "gbState";
            this.gbState.Size = new System.Drawing.Size(344, 347);
            this.gbState.TabIndex = 11;
            this.gbState.TabStop = false;
            this.gbState.Text = "Sales situation";
            // 
            // laRed
            // 
            this.laRed.AutoSize = true;
            this.laRed.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRed.Location = new System.Drawing.Point(209, 267);
            this.laRed.Name = "laRed";
            this.laRed.Size = new System.Drawing.Size(53, 44);
            this.laRed.TabIndex = 9;
            this.laRed.Text = "←";
            this.laRed.Visible = false;
            // 
            // laYellow
            // 
            this.laYellow.AutoSize = true;
            this.laYellow.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laYellow.Location = new System.Drawing.Point(209, 125);
            this.laYellow.Name = "laYellow";
            this.laYellow.Size = new System.Drawing.Size(53, 44);
            this.laYellow.TabIndex = 8;
            this.laYellow.Text = "←";
            this.laYellow.Visible = false;
            // 
            // laOrange
            // 
            this.laOrange.AutoSize = true;
            this.laOrange.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laOrange.Location = new System.Drawing.Point(209, 199);
            this.laOrange.Name = "laOrange";
            this.laOrange.Size = new System.Drawing.Size(53, 44);
            this.laOrange.TabIndex = 7;
            this.laOrange.Text = "←";
            this.laOrange.Visible = false;
            // 
            // laGreen
            // 
            this.laGreen.AutoSize = true;
            this.laGreen.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laGreen.Location = new System.Drawing.Point(209, 50);
            this.laGreen.Name = "laGreen";
            this.laGreen.Size = new System.Drawing.Size(53, 44);
            this.laGreen.TabIndex = 6;
            this.laGreen.Text = "←";
            this.laGreen.Visible = false;
            // 
            // gbDescription
            // 
            this.gbDescription.Controls.Add(this.label6);
            this.gbDescription.Controls.Add(this.label7);
            this.gbDescription.Controls.Add(this.label9);
            this.gbDescription.Controls.Add(this.label8);
            this.gbDescription.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDescription.Location = new System.Drawing.Point(28, 753);
            this.gbDescription.Name = "gbDescription";
            this.gbDescription.Size = new System.Drawing.Size(342, 285);
            this.gbDescription.TabIndex = 12;
            this.gbDescription.TabStop = false;
            // 
            // laResult
            // 
            this.laResult.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laResult.Location = new System.Drawing.Point(28, 300);
            this.laResult.Name = "laResult";
            this.laResult.Size = new System.Drawing.Size(342, 75);
            this.laResult.TabIndex = 13;
            this.laResult.Text = "0.00 Jordanian dinar";
            this.laResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.productsDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.individualPriceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(502, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1276, 802);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Visible = false;
            // 
            // reportsBindingSource
            // 
            this.reportsBindingSource.DataMember = "Reports";
            this.reportsBindingSource.DataSource = this.finalReportsDBDataSet;
            // 
            // finalReportsDBDataSet
            // 
            this.finalReportsDBDataSet.DataSetName = "FinalReportsDBDataSet";
            this.finalReportsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(502, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 74);
            this.button1.TabIndex = 15;
            this.button1.Text = "Show details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 48);
            this.button2.TabIndex = 13;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reportsTableAdapter
            // 
            this.reportsTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(502, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(192, 74);
            this.button3.TabIndex = 16;
            this.button3.Text = "Store Management";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "Total price";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "Total price";
            this.totalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            this.totalPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // individualPriceDataGridViewTextBoxColumn
            // 
            this.individualPriceDataGridViewTextBoxColumn.DataPropertyName = "Individual price";
            this.individualPriceDataGridViewTextBoxColumn.HeaderText = "Individual price";
            this.individualPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.individualPriceDataGridViewTextBoxColumn.Name = "individualPriceDataGridViewTextBoxColumn";
            this.individualPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // productsDataGridViewTextBoxColumn
            // 
            this.productsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.productsDataGridViewTextBoxColumn.DataPropertyName = "Products";
            this.productsDataGridViewTextBoxColumn.FillWeight = 200F;
            this.productsDataGridViewTextBoxColumn.Frozen = true;
            this.productsDataGridViewTextBoxColumn.HeaderText = "Products";
            this.productsDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.productsDataGridViewTextBoxColumn.Name = "productsDataGridViewTextBoxColumn";
            this.productsDataGridViewTextBoxColumn.ReadOnly = true;
            this.productsDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.productsDataGridViewTextBoxColumn.Width = 250;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.Frozen = true;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // storsDBDataSet
            // 
            this.storsDBDataSet.DataSetName = "StorsDBDataSet";
            this.storsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // storsBindingSource
            // 
            this.storsBindingSource.DataMember = "Stors";
            this.storsBindingSource.DataSource = this.storsDBDataSet;
            // 
            // storsTableAdapter
            // 
            this.storsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StorsTableAdapter = this.storsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Water_Station_Final.StorsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // storsDataGridView
            // 
            this.storsDataGridView.AutoGenerateColumns = false;
            this.storsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.storsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.storsDataGridView.DataSource = this.storsBindingSource;
            this.storsDataGridView.Location = new System.Drawing.Point(502, 236);
            this.storsDataGridView.Name = "storsDataGridView";
            this.storsDataGridView.RowHeadersWidth = 62;
            this.storsDataGridView.RowTemplate.Height = 28;
            this.storsDataGridView.Size = new System.Drawing.Size(1276, 802);
            this.storsDataGridView.TabIndex = 16;
            this.storsDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Product";
            this.dataGridViewTextBoxColumn2.HeaderText = "Product";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // Reports
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Water_Station_Final.Properties.Resources.Screenshot_2021_12_25_100755;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1824, 1050);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.laResult);
            this.Controls.Add(this.gbDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CombReports);
            this.Controls.Add(this.gbState);
            this.Controls.Add(this.storsDataGridView);
            this.Controls.Add(this.button3);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(1812, 1006);
            this.Name = "Reports";
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reports_Load);
            this.gbState.ResumeLayout(false);
            this.gbState.PerformLayout();
            this.gbDescription.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalReportsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CombReports;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbState;
        private System.Windows.Forms.GroupBox gbDescription;
        private System.Windows.Forms.Label laResult;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label laRed;
        private System.Windows.Forms.Label laYellow;
        private System.Windows.Forms.Label laOrange;
        private System.Windows.Forms.Label laGreen;
        private System.Windows.Forms.Button button2;
        private FinalReportsDBDataSet finalReportsDBDataSet;
        private System.Windows.Forms.BindingSource reportsBindingSource;
        private FinalReportsDBDataSetTableAdapters.ReportsTableAdapter reportsTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn individualPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private StorsDBDataSet storsDBDataSet;
        private System.Windows.Forms.BindingSource storsBindingSource;
        private StorsDBDataSetTableAdapters.StorsTableAdapter storsTableAdapter;
        private StorsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView storsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}