
namespace Water_Station_Final
{
    partial class Cash
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnsell = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.storsDBDataSet = new Water_Station_Final.StorsDBDataSet();
            this.storsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storsTableAdapter = new Water_Station_Final.StorsDBDataSetTableAdapters.StorsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.storsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 436);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(547, 66);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 508);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(547, 66);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnsell
            // 
            this.btnsell.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsell.Location = new System.Drawing.Point(12, 652);
            this.btnsell.Name = "btnsell";
            this.btnsell.Size = new System.Drawing.Size(547, 61);
            this.btnsell.TabIndex = 3;
            this.btnsell.Text = "Sell";
            this.btnsell.UseVisualStyleBackColor = true;
            this.btnsell.Click += new System.EventHandler(this.btnsell_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(12, 580);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(547, 66);
            this.textBox3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 424);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            // Cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 718);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnsell);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Cash";
            this.Text = "Cash";
            this.Load += new System.EventHandler(this.Cash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnsell;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private StorsDBDataSet storsDBDataSet;
        private System.Windows.Forms.BindingSource storsBindingSource;
        private StorsDBDataSetTableAdapters.StorsTableAdapter storsTableAdapter;
    }
}